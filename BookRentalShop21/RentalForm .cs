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
    public partial class RentalForm : MetroForm
    {

        string mode = "";

        public object DeleteProcess { get; private set; }

        public RentalForm()
        {
            InitializeComponent();
        }
        private void MemberForm_Load(object sender, EventArgs e)
        {
            DtpRentalDate.CustomFormat = "yyyy-MM-dd"; //공백 반드시 들어간다.
            DtpRentalDate.Format = DateTimePickerFormat.Custom;

            DtpReturnDate.CustomFormat = "yyyy-MM-dd"; //공백 반드시 들어간다.
            DtpReturnDate.Format = DateTimePickerFormat.Custom;
            //직접 코딩해서 DB를 로드한다.
            UpdateData();//데이터 그리드 DB 데이터 로딩하기
            UpdateCboDivision();
            UpdateCboName();
        }

        private void UpdateCboDivision()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Idx, Names FROM bookstbl";
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> temps = new Dictionary<string, string>();
                //사전에 대한 데이터 앞에 값에 대한 벨류 <키, 벨류>
                // B001에 대한 벨류 -> 공포 스릴러
                // B002에 대한 벨류 -> 로맨스
                while (reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                CboBook.DataSource = new BindingSource(temps, null);
                CboBook.DisplayMember = "Value";
                CboBook.ValueMember = "Key";
                CboBook.SelectedIndex = -1;
            }
        }
        private void UpdateCboName()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Idx, Names FROM dbo.membertbl";
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> temps = new Dictionary<string, string>();
                //사전에 대한 데이터 앞에 값에 대한 벨류 <키, 벨류>
                // B001에 대한 벨류 -> 공포 스릴러
                // B002에 대한 벨류 -> 로맨스
                while (reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                CboName.DataSource = new BindingSource(temps, null);
                CboName.DisplayMember = "Value";
                CboName.ValueMember = "Key";
                CboName.SelectedIndex = -1;
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
                string strQuery = " SELECT r.idx AS '대여번호', m.Names AS '대여회원', " +
                                  " t.Names AS '장르', b.Names AS '대여책제목', b.ISBN, " +
                                  " r.rentalDate  ,r.returnDate  " +
                                  " FROM rentaltbl AS r " +
                                  " INNER JOIN membertbl AS m " +
                                  " ON r.memberIdx = m.Idx " +
                                  " INNER JOIN bookstbl AS b " +
                                  " ON r.bookIdx = b.Idx " +
                                  " INNER JOIN divtbl AS t " +
                                  " ON b.division = t.division; ";
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                //위에는 연결선 같은 역할을 한다.
                //밑에 이걸로 데이터를 담는 통
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "rentaltbl"); //통에다가 divtbl을 이름으로 채운다.

                GrdBooksTbl.DataSource = ds; //그리드의 데이터 소스에다가 붓는다.
                GrdBooksTbl.DataMember = "rentaltbl";
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


                TxtIdx.BackColor = Color.Beige;


                CboName.Text = GrdBooksTbl[1, e.RowIndex].Value.ToString();
                CboBook.SelectedValue = CboBook.FindString(data.Cells[2].Value.ToString());

                CboBook.Text = data.Cells[3].Value.ToString();

                DtpRentalDate.CustomFormat = "yyyy-MM-dd";
                DtpRentalDate.Format = DateTimePickerFormat.Custom;

                DtpReturnDate.CustomFormat = "yyyy-MM-dd";
                DtpReturnDate.Format = DateTimePickerFormat.Custom;

                DtpRentalDate.Value = DateTime.Parse(data.Cells[5].Value.ToString());
                
                try
                {
                    DtpReturnDate.Value = DateTime.Parse(data.Cells[6].Value.ToString());
                }
                catch (Exception)
                {
                }


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
            //if (string.IsNullOrEmpty(TxtIdx.Text)
            //    || string.IsNullOrEmpty(CboBook.Text)
            //    || string.IsNullOrEmpty(CboBook.Text)
            //    || string.IsNullOrEmpty(CboName.Text)
            //    )
            //{
            //    MetroMessageBox.Show(this, "빈 값은 저장할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return; //메세지 박스 빠져 나오기 뭐 안되면 리턴하자
            //}

            SaveProcess();
            UpdateData();//데이터 그리드 DB 데이터 로딩하기
            //값이 바로 바꾼것으로 보이기 위한 부분.
            ClearTextControls();
        }

        private void ClearTextControls()
        {

            TxtIdx.Text = "";

            CboName.Text = "";
            CboBook.Text = "";

            CboBook.SelectedIndex = -1;
            CboName.SelectedIndex = -1;

            //데이트피커 초기화
            DtpRentalDate.CustomFormat = " "; //공백 반드시 들어간다.
            DtpRentalDate.Format = DateTimePickerFormat.Custom;
            //이러면 날짜가 아예 안나온다. 선택할 때 또 코딩해야한다.
            DtpReturnDate.CustomFormat = " "; //공백 반드시 들어간다.
            DtpReturnDate.Format = DateTimePickerFormat.Custom;

           
            TxtIdx.BackColor = Color.Beige;
            CboBook.Focus();
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
                    cmd.CommandText = "UPDATE dbo.rentaltbl " +
                                      "   SET memberIdx = @memberIdx " +
                                      "     , bookIdx = @bookIdx " +
                                      "     , rentalDate = @rentalDate " +
                                      "     , returnDate = @returnDate " +
                                      " WHERE Idx = @Idx ";

                    SqlParameter parmrentalDate = new SqlParameter("@rentalDate", SqlDbType.Date);
                    parmrentalDate.Value = DtpRentalDate.Value;
                    cmd.Parameters.Add(parmrentalDate);

                    SqlParameter parmreturnDate = new SqlParameter("@returnDate", SqlDbType.Date);
                    parmreturnDate.Value = DtpReturnDate.Value;
                    cmd.Parameters.Add(parmreturnDate);


                    SqlParameter parMemberIdx = new SqlParameter("@memberIdx", SqlDbType.Int);
                    parMemberIdx.Value = CboName.SelectedValue;
                    cmd.Parameters.Add(parMemberIdx);

                    SqlParameter parmBookIdx = new SqlParameter("@bookIdx", SqlDbType.Int);
                    parmBookIdx.Value = CboBook.SelectedValue;
                    cmd.Parameters.Add(parmBookIdx);

                    SqlParameter parmIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    parmIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(parmIdx);

                    cmd.ExecuteNonQuery();//excute는 넣을 때 쓰는건 NonQuery 그 외에건 가져올 때
                    UpdateData();

                }
                else if (mode == "INSERT")
                {
                    cmd.CommandText = "INSERT INTO dbo.rentaltbl (memberIdx,bookId,rentalDate,returnDate)" +
                                      "   VALUES memberIdx = @memberIdx " +
                                      "     , bookIdx = @bookIdx " +
                                      "     , rentalDate = @rentalDate " +
                                      "     , returnDate = @returnDate " +
                                      " WHERE Idx = @Idx ";

                    SqlParameter parmrentalDate = new SqlParameter("@rentalDate", SqlDbType.Date);
                    parmrentalDate.Value = DtpRentalDate.Value;
                    cmd.Parameters.Add(parmrentalDate);

                    SqlParameter parmreturnDate = new SqlParameter("@returnDate", SqlDbType.Date);
                    parmreturnDate.Value = DtpReturnDate.Value;
                    cmd.Parameters.Add(parmreturnDate);


                    SqlParameter parMemberIdx = new SqlParameter("@memberIdx", SqlDbType.Int);
                    parMemberIdx.Value = CboName.SelectedValue;
                    cmd.Parameters.Add(parMemberIdx);

                    SqlParameter parmBookIdx = new SqlParameter("@bookIdx", SqlDbType.Int);
                    parmBookIdx.Value = CboBook.SelectedValue;
                    cmd.Parameters.Add(parmBookIdx);

                    SqlParameter parmIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    parmIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(parmIdx);

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
            if (string.IsNullOrEmpty(CboBook.Text) || string.IsNullOrEmpty(CboBook.Text))
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

        
        private void DtpRentalDate_ValueChanged(object sender, EventArgs e)
        {
            DtpRentalDate.CustomFormat = "yyyy-MM-dd"; //공백 반드시 들어간다.
            DtpRentalDate.Format = DateTimePickerFormat.Custom;
        }

        private void DtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            DtpReturnDate.CustomFormat = "yyyy-MM-dd"; //공백 반드시 들어간다.
            DtpReturnDate.Format = DateTimePickerFormat.Custom;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            
            TxtIdx.Text = "";
            CboBook.SelectedIndex = -1;
            CboName.SelectedIndex = -1;
            DtpReturnDate.CustomFormat = " "; 
            DtpReturnDate.Format = DateTimePickerFormat.Custom;
        }
    }
}
