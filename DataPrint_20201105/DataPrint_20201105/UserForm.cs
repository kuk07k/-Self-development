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
using MetroFramework;
using MetroFramework.Forms;

namespace DataPrint_20201105
{
    public partial class UserForm : MetroForm
    {
        string mode = "";

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            UpdateData(); // 데이터그리드 DB 데이터 로딩하기
        }

        // 사용자 데이터 가져오기
        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(commons.CONNSTRING))
            {
                conn.Open(); // DB 열기
                string strQuery = "SELECT id,userID,password,lastLoginDt,loginIpAddr "
                                 + " FROM userTbl ";
                //SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "userTbl");

                GrdUserTbl.DataSource = ds;
                GrdUserTbl.DataMember = "userTbl";
            }

            DataGridViewColumn column = GrdUserTbl.Columns[0]; // id컬럼
            column.Width = 40;
            column.HeaderText = "순번";
            column = GrdUserTbl.Columns[1]; // userID 컬럼
            column.Width = 80;
            column.HeaderText = "아이디";
            column = GrdUserTbl.Columns[2]; // Password 컬럼
            column.Width = 100;
            column.HeaderText = "패스워드";
            column = GrdUserTbl.Columns[3]; // 최종 접속 시간
            column.Width = 120;
            column.HeaderText = "최종접속시간";
            column = GrdUserTbl.Columns[4]; // 접속 아이피 주소
            column.Width = 150;
            column.HeaderText = "접속아이피주소";
        }

        // 입력창 초기화
        private void ClearTextControls()
        {
            TxtId.Text = "";
            TxtUserID.Text = "";
            TxtPassword.Text = "";
            TxtUserID.Focus();
        }

        private void DeleteProcess()
        {
            using (SqlConnection conn = new SqlConnection(commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM userTbl "
                                + " WHERE userID = @userID";
                SqlParameter parmDivision = new SqlParameter("@userID", SqlDbType.VarChar, 12);
                parmDivision.Value = TxtUserID.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();
            }
        }

        // DB 저장 프로세스
        private void SaveProcess()
        {
            if (string.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string strQuery = "";

                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE dbo.userTbl "
                               + " SET userID = @userID, password = @password "
                             + " WHERE id = @id";
                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO userTbl (userID, password) "
                            + " VALUES(@userID, @password)";
                }
                cmd.CommandText = strQuery;

                SqlParameter parmUserID = new SqlParameter("@userID", SqlDbType.VarChar, 12);
                parmUserID.Value = TxtUserID.Text;
                cmd.Parameters.Add(parmUserID);

                SqlParameter parmPassword = new SqlParameter("@password", SqlDbType.VarChar, 20);
                parmPassword.Value = TxtPassword.Text;
                cmd.Parameters.Add(parmPassword);

                if (mode == "UPDATE")
                {
                    SqlParameter parmId = new SqlParameter("@id", SqlDbType.Int);
                    parmId.Value = TxtId.Text;
                    cmd.Parameters.Add(parmId);
                }

                cmd.ExecuteNonQuery();
            }
        }
        
        // Cell 클릭시
        private void GrdUserTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdUserTbl.Rows[e.RowIndex];
                TxtId.Text = data.Cells[0].Value.ToString();
                TxtUserID.Text = data.Cells[1].Value.ToString();
                TxtPassword.Text = data.Cells[2].Value.ToString();

                mode = "UPDATE"; // 수정은 UPDATE
            }
        }

        // 버튼

        // 새로운 데이터 저장
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextControls();

            mode = "INSERT"; // 신규는 INSERT
        }

        // 데이터 삭제
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteProcess();
            UpdateData();
        }

        // 데이터 수정
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUserID.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MetroMessageBox.Show(this, "빈값은 저장할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveProcess();
            UpdateData();
            ClearTextControls();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearTextControls();
            UpdateData();
        }

       
    }
}
