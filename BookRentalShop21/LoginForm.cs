using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShop20
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        /// Cancel 버튼 클릭 이벤트
        private void BtnCancel_Click(object sender, EventArgs e)
        {

            //Application.Exit();// 요건안될때가있다.
            Environment.Exit(0);  
        }


        private void BtnOk_Click(object sender, EventArgs e)
        {

            LoginProcess();
        }

        //아이디에서 엔터키 누르면 비밀번호 텍스트로
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //엔터 소문자 char는 원래 자료형 
            //Char은 닷넷을 위해 만든 새로 만든클래스
            if (e.KeyChar == (char)13)   
            {
                txtPassword.Focus();
            }
        }

        //비밀번호에서 엔터 누르면 OK버튼과 동일한 처리
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)  
            {
                // 로그인 처리 버튼 이벤트
                LoginProcess();   
            }
        }

        private void LoginProcess() 
        {
          
            if (string.IsNullOrEmpty(txtId.Text) ||
                 string.IsNullOrEmpty(txtPassword.Text))
            {
                //throw new NotImplementedException(); 
                //빈칸에 대한 오류발생 메세지

                //두가지 방법이 가능
                //if((TxtUserID.Text==null || TxtUserID.Text=="") || (TxtUserPW.Text==null || TxtUserPW.Text==""))
                MetroMessageBox.Show(this, "아이디/패스워드를 입력하세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
              
            string struserID = string.Empty;

            try // 아이디 비밀번호가 틀릴 때 생기는 에러 핸들링
            {
                using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))//위에 만든 문자열을 집어넣으면 접속시작.
                {
                    conn.Open();  //using을 쓰면 Close해줘야하지만 아니라면 Close 꼭 해야한다. 아니면 계속 접속되어있다.
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    //해킹을 당할 수가 있으므로 @로 바꿔서 작업해준다.
                    cmd.CommandText = "SELECT userID FROm userTbl " +
                                      " WHERE userID = @userID " +
                                      "   AND password = @password ";
                    //sql에 들어갈 명령문을 넣어준다. 거의 INSERT SELECT UPDATEE DELETE만 사용한다.


                    SqlParameter parmUserId = new SqlParameter("@userID", SqlDbType.VarChar, 12);
                    parmUserId.Value = txtId.Text;
                    cmd.Parameters.Add(parmUserId); //아이디 가져오기


                    SqlParameter parmUserPassword = new SqlParameter("@password", SqlDbType.VarChar, 20);
                    parmUserPassword.Value = txtPassword.Text;
                    cmd.Parameters.Add(parmUserPassword);//비밀번호 가져오기

                    SqlDataReader reader = cmd.ExecuteReader();//select 한 가상의 테이블을 돌려받는다.
                    reader.Read();

                    this.Close();
                    struserID = reader["userID"] != null ? reader["userID"].ToString() : "";
                    //reader["userID"] != null 이 참이라면 reader["userID"].ToString() 거짓이라면 빈 문자열
                    
                    if (struserID != "")
                    {
                        Commons.LOGINUSERID = struserID;
                        MetroMessageBox.Show(this, "접속성공", "로그인성공");
                        this.Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "접속실패", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //Debug.WriteLine("On the Debug");
                }

            }
            catch (Exception ex) //오류에 대한 핸들링
            {
                MetroMessageBox.Show(this, $"Error : {ex.StackTrace}","오류",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
                
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


