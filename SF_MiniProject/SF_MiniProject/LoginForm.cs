using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace SF_MiniProject
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {

            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Loginprocess();
        }

        private void TxtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtPassWordID.Focus();
            }
        }
        private void TxtPassWordID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Loginprocess();
            }
        }
        private void Loginprocess()
        {
            if (string.IsNullOrEmpty(TxtUserID.Text) || string.IsNullOrEmpty(TxtPassWordID.Text))
            {
                MetroMessageBox.Show(this, "ID / Password를 입력하세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                string struserid = string.Empty;

                try
                {
                    using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT userID FROM userTbl " +
                                          " WHERE userID = @userID " +
                                          " AND password = @password ";

                        SqlParameter parmUserId = new SqlParameter("@userID", SqlDbType.VarChar, 12);
                        parmUserId.Value = TxtUserID.Text;
                        cmd.Parameters.Add(parmUserId);
                        SqlParameter parmPassword = new SqlParameter("@password", SqlDbType.VarChar, 20);
                        parmPassword.Value = TxtPassWordID.Text;
                        cmd.Parameters.Add(parmPassword);

                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        struserid = reader["userID"] != null ? reader["userID"].ToString() : "";

                        if (struserid != "")
                        {
                            Commons.LOGINUSERID = struserid; // 자식창으로 값을 할당
                            MetroMessageBox.Show(this, "로그인 성공", "환영합니다!");
                            this.Close(); // 로그인 폼이 닫힘
                        }
                    }
                }
                catch
                {
                    MetroMessageBox.Show(this, "Error : ID / Password가 틀렸습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
