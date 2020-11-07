using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class DivForm : MetroForm
    {
        string mode = "";

        public object DeleteProcess { get; private set; }

        public DivForm()
        {
            InitializeComponent();
        }

        private void DivForm_Load(object sender, EventArgs e)
        { //직접 코딩해서 DB를 로드한다.
            UpdateData();//데이터 그리드 DB 데이터 로딩하기

        }

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open(); //DB접속
                //쿼리 직접 치기 귀찮으니 ssms 가서 테이블우클릭 -> 새쿼리편집창해서 편집한 후 가지고온다.

                //마우스 클릭으로 하던걸 코딩으로 한다.
                //제일 중요하다.
                string strQuery = "SELECT Division,Names FROM divtbl";
                //SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                //위에는 연결선 같은 역할을 한다.
                //밑에 이걸로 데이터를 담는 통
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "divtbl"); //통에다가 divtbl을 이름으로 채운다.

                GrdDivTbl.DataSource = ds; //그리드의 데이터 소스에다가 붓는다.
                GrdDivTbl.DataMember = "divtbl";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>-1)
            {//그리드 뷰의 한 행을 클릭하면 텍스트에 디비전과 네임이 나온다.
                DataGridViewRow data = GrdDivTbl.Rows[e.RowIndex]; //그리드의 인덱스에 대한 값 저장
                //배열의 행들 : DataGridViewRowCollection
                //배열의 한 행 : DataGridViewRow

                txtDivision.Text = data.Cells[0].Value.ToString();
                txtNames.Text=data.Cells[1].Value.ToString();

                txtDivision.BackColor = Color.Beige; //텍스트를 노란색으로 하여 수정이 불가하게 설정
                txtDivision.ReadOnly = true;
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
            if (string.IsNullOrEmpty(txtDivision.Text)||string.IsNullOrEmpty(txtNames.Text))
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
            txtDivision.Text = txtNames.Text = "";
            txtDivision.ReadOnly = false;
            txtDivision.BackColor = Color.White;
            txtDivision.Focus();
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
                    cmd.CommandText = "UPDATE dbo.divtbl  " +
                               "   SET Names = @Names  " +
                               " WHERE Division = @Division  ";
                    SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.NVarChar, 45);
                    parmNames.Value = txtNames.Text;
                    cmd.Parameters.Add(parmNames); //이름 업데이트!


                    SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                    parmDivision.Value = txtDivision.Text;
                    cmd.Parameters.Add(parmDivision);//디비전 업데이트!

                    cmd.ExecuteNonQuery();//excute는 넣을 때 쓰는건 NonQuery 그 외에건 가져올 때
                    UpdateData();
                }
                else if (mode == "INSERT")
                {
                    cmd.CommandText = "INSERT INTO dbo.divtbl(Division,Names)" +
                                      "VALUES(@Division, @Names)";
                    SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.NVarChar, 45);
                    parmNames.Value = txtNames.Text;
                    cmd.Parameters.Add(parmNames);//이름 업데이트!

                    SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                    parmDivision.Value = txtDivision.Text;
                    cmd.Parameters.Add(parmDivision);//디비전 업데이트!

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
            if (string.IsNullOrEmpty(txtDivision.Text) || string.IsNullOrEmpty(txtNames.Text))
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

                cmd.CommandText = " DELETE FROM dbo.divtbl WHERE Division = @Division ";
                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDivision.Value = txtDivision.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();
                UpdateData();
                ClearTextControls();
            }
        }
    }
}
