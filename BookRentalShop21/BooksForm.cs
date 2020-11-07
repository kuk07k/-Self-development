using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class BooksForm : MetroForm
    {

        string mode = "";

        public object DeleteProcess { get; private set; }

        public BooksForm()
        {
            InitializeComponent();
        }
        private void MemberForm_Load(object sender, EventArgs e)
        {
            DtpReleaseDate.CustomFormat = "yyyy-MM-dd"; //공백 반드시 들어간다.
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
            //직접 코딩해서 DB를 로드한다.
            UpdateData();//데이터 그리드 DB 데이터 로딩하기
            UpdateCboDivision();
        }

        private void UpdateCboDivision()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Division, Names FROM divtbl";
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> temps = new Dictionary<string, string>();
                //사전에 대한 데이터 앞에 값에 대한 벨류 <키, 벨류>
                // B001에 대한 벨류 -> 공포 스릴러
                // B002에 대한 벨류 -> 로맨스
                while (reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                CboDivision.DataSource = new BindingSource(temps, null);
                CboDivision.DisplayMember = "Value";
                CboDivision.ValueMember = "Key";
                CboDivision.SelectedIndex = -1;
            }
        }

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open(); //DB접속
                //쿼리 직접 치기 귀찮으니 ssms 가서 테이블우클릭 -> 새쿼리편집창해서 편집한 후 가지고온다.

                //마우스 클릭으로 하던걸 코딩으로 한다.
                //제일 중요하다.
                string strQuery = " SELECT b.Idx ,b.Author, b.Division, b.Names AS 'DivNames', " +
                                   " b.ReleaseDate,b.ISBN, " +
                                    " REPLACE(CONVERT(VARCHAR, CAST(b.price AS MONEY), 1), '.00', '') AS Price " +
                                    " FROM dbo.bookstbl AS b " +
                                    " INNER JOIN dbo.divtbl AS d " +
                                    " ON b.Division = d.Division ";
                //SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                //위에는 연결선 같은 역할을 한다.
                //밑에 이걸로 데이터를 담는 통
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "bookstbl"); //통에다가 divtbl을 이름으로 채운다.

                GrdBooksTbl.DataSource = ds; //그리드의 데이터 소스에다가 붓는다.
                GrdBooksTbl.DataMember = "bookstbl";
            }

            DataGridViewColumn column = GrdBooksTbl.Columns[2]; //division 컬럼         
            column.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {//그리드 뷰의 한 행을 클릭하면 텍스트에 디비전과 네임이 나온다.
                DataGridViewRow data = GrdBooksTbl.Rows[e.RowIndex]; //그리드의 인덱스에 대한 값 저장
                //배열의 행들 : DataGridViewRowCollection
                //배열의 한 행 : DataGridViewRow

                TxtIdx.Text = data.Cells[0].Value.ToString();


                TxtIdx.BackColor = Color.Beige; //텍스트를 노란색으로 하여 수정이 불가하게 설정
                TxtIdx.ReadOnly = true;

                TxtAuthor.Text = data.Cells[1].Value.ToString();
                //CboDivision.SelectedIndex= CboDivision.FindString(data.Cells[3].Value.ToString()); //글자를 가져온다
                CboDivision.SelectedValue = data.Cells[2].Value; //글자가 가리키는 값을 가져온다.

                DtpReleaseDate.CustomFormat = "yyyy-MM-dd"; //공백 반드시 들어간다.
                DtpReleaseDate.Format = DateTimePickerFormat.Custom;

                TxtNames.Text = data.Cells[3].Value.ToString();
                DtpReleaseDate.Value = DateTime.Parse(data.Cells[4].Value.ToString());
                TxtISBN.Text = data.Cells[5].Value.ToString();
                TxtPrice.Text = data.Cells[6].Value.ToString();

                mode = "UPDATE";
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextControls();
            mode = "INSERT"; //신규 INSERT
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNames.Text)
                || string.IsNullOrEmpty(TxtISBN.Text)
                || string.IsNullOrEmpty(TxtPrice.Text)
                || string.IsNullOrEmpty(TxtAuthor.Text)
                )
            {
                MetroMessageBox.Show(this, "빈 값은 저장할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //메세지 박스 빠져 나오기 뭐 안되면 리턴하자
            }

            SaveProcess();
            UpdateData();//데이터 그리드 DB 데이터 로딩하기
            //값이 바로 바꾼것으로 보이기 위한 부분.
            ClearTextControls();
        }

        private void ClearTextControls()
        {

            TxtIdx.Text = "";
            TxtAuthor.Text = "";
            TxtISBN.Text = "";
            TxtNames.Text = "";
            TxtPrice.Text = "";
            CboDivision.SelectedIndex = -1;

            //데이트피커 초기화
            DtpReleaseDate.CustomFormat = " "; //공백 반드시 들어간다.
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
            //이러면 날짜가 아예 안나온다. 선택할 때 또 코딩해야한다.


            TxtIdx.ReadOnly = true;
            TxtIdx.BackColor = Color.Beige;
            TxtAuthor.Focus();
        }

        //db저장 프로세스
        private void SaveProcess()
        {
            if (string.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (mode == "UPDATE")
                {
                    cmd.CommandText = " UPDATE dbo.bookstbl " +
                                      " SET Author = @Author, "+
                                      " Division = @Division, " +
                                      " Names = @Names, " +
                                      " ReleaseDate = @ReleaseDate, " +
                                      " ISBN = @ISBN, " +
                                      " Price = @Price " +
                                      "  WHERE Idx = @Idx ";

                    SqlParameter parmAuthor = new SqlParameter("@Author", SqlDbType.VarChar, 45);
                    parmAuthor.Value = TxtAuthor.Text;
                    cmd.Parameters.Add(parmAuthor); //이름 업데이트!

                    SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                    parmDivision.Value = CboDivision.SelectedValue;
                    cmd.Parameters.Add(parmDivision);//레벨 업데이트

                    SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.VarChar, 100);
                    parmNames.Value = TxtNames.Text;
                    cmd.Parameters.Add(parmNames); 

                    SqlParameter parmReleaseDate = new SqlParameter("@ReleaseDate", SqlDbType.Date);
                    parmReleaseDate.Value = DtpReleaseDate.Value;
                    cmd.Parameters.Add(parmReleaseDate); 

                    SqlParameter parmISBN = new SqlParameter("@ISBN", SqlDbType.VarChar, 200);
                    parmISBN.Value = TxtISBN.Text;
                    cmd.Parameters.Add(parmISBN); 

                    SqlParameter parmPrice = new SqlParameter("@Price", SqlDbType.Decimal,10);
                    parmPrice.Value = TxtPrice.Text;
                    cmd.Parameters.Add(parmPrice);

                    SqlParameter parmIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    parmIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(parmIdx);
                    
                    cmd.ExecuteNonQuery();//excute는 넣을 때 쓰는건 NonQuery 그 외에건 가져올 때
                    UpdateData();

                }
                else if (mode == "INSERT")
                {
                    cmd.CommandText = " INSERT INTO dbo.bookstbl(Author,Division,Names,ReleaseDate,ISBN,Price) " +
                                      "  VALUES(@Author, @Division, @Names, @ReleaseDate, @ISBN, @Price)";
                    SqlParameter parmAuthor = new SqlParameter("@Author", SqlDbType.VarChar, 45);
                    parmAuthor.Value = TxtAuthor.Text;
                    cmd.Parameters.Add(parmAuthor); //이름 업데이트!

                    SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                    parmDivision.Value = CboDivision.SelectedValue;
                    cmd.Parameters.Add(parmDivision);//레벨 업데이트

                    SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.VarChar, 100);
                    parmNames.Value = TxtNames.Text;
                    cmd.Parameters.Add(parmNames);

                    SqlParameter parmReleaseDate = new SqlParameter("@ReleaseDate", SqlDbType.Date);
                    parmReleaseDate.Value = DtpReleaseDate.Value;
                    cmd.Parameters.Add(parmReleaseDate);

                    SqlParameter parmISBN = new SqlParameter("@ISBN", SqlDbType.VarChar, 200);
                    parmISBN.Value = TxtISBN.Text;
                    cmd.Parameters.Add(parmISBN);

                    SqlParameter parmPrice = new SqlParameter("@Price", SqlDbType.Decimal, 10);
                    parmPrice.Value = TxtPrice.Text;
                    cmd.Parameters.Add(parmPrice);


                    cmd.ExecuteNonQuery();//excute는 넣을 때 쓰는건 NonQuery 그 외에건 가져올 때
                    UpdateData();

                }

            }
        }

        private void txtNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                BtnSave_Click(sender, new EventArgs());
                //txtNames_Keypress에서 엔터치면 바로 저장
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNames.Text) || string.IsNullOrEmpty(TxtISBN.Text))
            {
                MetroMessageBox.Show(this, "빈 값은 삭제할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //메세지 박스 빠져 나오기 뭐 안되면 리턴하자
            }
            DeleteProcess2();

        }

        private void DeleteProcess2()
        {
            using(SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = " DELETE FROM dbo.membertbl WHERE Idx = @Idx ";
                SqlParameter parmIdx = new SqlParameter("@Idx", SqlDbType.Int);
                parmIdx.Value = TxtIdx.Text;
                cmd.Parameters.Add(parmIdx);

                cmd.ExecuteNonQuery();
                UpdateData();
                ClearTextControls();
            }
        }

        private void GrdMemberTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            DtpReleaseDate.CustomFormat = "yyyy-MM-dd"; //공백 반드시 들어간다.
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
        }
    }
}
