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
    public partial class UserForm : MetroForm
    {
        string mode = "";

        public object DeleteProcess { get; private set; }

        public UserForm()
        {
            InitializeComponent();
        }

        private void DivForm_Load(object sender, EventArgs e)
        { //직접 코딩해서 DB를 로드한다.
            UpdateData();//데이터 그리드 DB 데이터 로딩하기

        }

        //사용자 데이터 가져요기
        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open(); //DB접속
                //쿼리 직접 치기 귀찮으니 ssms 가서 테이블우클릭 -> 새쿼리편집창해서 편집한 후 가지고온다.

                //마우스 클릭으로 하던걸 코딩으로 한다.
                //제일 중요하다.
                string strQuery = "SELECT id,userID,password,lastLoginDt,loginIpAddr FROM dbo.userTbl";
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                //위에는 연결선 같은 역할을 한다.
                //밑에 이걸로 데이터를 담는 통
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "userTbl"); //통에다가 divtbl을 이름으로 채운다.

                GrdUserTbl.DataSource = ds; //그리드의 데이터 소스에다가 붓는다.
                GrdUserTbl.DataMember = "userTbl";
            }

            DataGridViewColumn column = GrdUserTbl.Columns[0]; //id 컬럼         
            column.Width = 40;
            column = GrdUserTbl.Columns[1];
            column.Width = 80;
            column.HeaderText = "아이디";
            column = GrdUserTbl.Columns[2];
            column.Width = 100;
            column.HeaderText = "패스워드";
            column = GrdUserTbl.Columns[3];
            column.Width = 120;
            column.HeaderText = "최종 접속시간";
            column = GrdUserTbl.Columns[4];
            column.Width = 150;
            column.HeaderText = "접속아이피주소";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextControls();
            mode = "INSERT"; //신규 INSERT
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUserID.Text)||string.IsNullOrEmpty(TxtPassword.Text))
            {
                MetroMessageBox.Show(this, "빈 값은 저장할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //메세지 박스 빠져 나오기 뭐 안되면 리턴하자
            }

            SaveProcess();
            UpdateData();//이미 수정함
            //값이 바로 바꾼것으로 보이기 위한 부분.
            ClearTextControls();
        }

        private void ClearTextControls()
        {
            
            TxtId.Text = TxtUserID.Text = TxtPassword.Text = "";
            
            TxtUserID.Focus();
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
                    cmd.CommandText = " UPDATE dbo.userTbl " + 
                                      " SET userID = @UserID,password = @Password " +
                                      " WHERE Id = @Id ";
                    SqlParameter parmUserID = new SqlParameter("@UserID", SqlDbType.VarChar, 12);
                    parmUserID.Value = TxtUserID.Text;
                    cmd.Parameters.Add(parmUserID); //아이디 업데이트!


                    SqlParameter parmPassword = new SqlParameter("@Password", SqlDbType.VarChar, 20);
                    parmPassword.Value = TxtPassword.Text;
                    cmd.Parameters.Add(parmPassword);//비밀번호 업데이트!

                    
                    SqlParameter parmID = new SqlParameter("@Id", SqlDbType.Int);
                    parmID.Value = TxtId.Text;
                    cmd.Parameters.Add(parmID);//순번 업데이트!

                    cmd.ExecuteNonQuery();//excute는 넣을 때 쓰는건 NonQuery 그 외에건 가져올 때
                    UpdateData();

                }
                else if (mode == "INSERT")
                {
                    cmd.CommandText = "INSERT INTO dbo.userTbl (userID, password) VALUES (@UserID, @Password)";
                    
                    SqlParameter parmUserID = new SqlParameter("@UserID", SqlDbType.VarChar, 12);
                    parmUserID.Value = TxtUserID.Text;
                    cmd.Parameters.Add(parmUserID); //아이디 업데이트!


                    SqlParameter parmPassword = new SqlParameter("@Password", SqlDbType.VarChar, 20);
                    parmPassword.Value = TxtPassword.Text;
                    cmd.Parameters.Add(parmPassword);//비밀번호 업데이트!

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
                parmDivision.Value = TxtUserID.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();
                UpdateData();
                ClearTextControls();
            }
        }
    }
}
