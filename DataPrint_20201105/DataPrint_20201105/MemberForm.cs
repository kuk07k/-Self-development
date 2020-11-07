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
    public partial class MemberForm : MetroForm
    {
        string mode = "";

        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            UpdateData();//데이터 그리드 DB 데이터 로딩하기
        }

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(commons.CONNSTRING)) // DB불러오기
            {
                conn.Open(); //DB접속

                string strQuery = " SELECT Idx,Names,Levels,Addr,Mobile,Email " +
                                  " FROM dbo.membertbl " + 
                                  " ORDER BY Idx ";
  
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn); //SqlDataAdapter : 쿼리와 데이터 통을 연결(연결선 역할)

                DataSet ds = new DataSet(); //DataSet : 데이터를 담는 통
                dataAdapter.Fill(ds, "membertbl"); //통에다가 membertbl 이름으로 채운다.

                GrdMemberTbl.DataSource = ds; //그리드의 데이터 소스에다가 붓는다.
                GrdMemberTbl.DataMember = "membertbl";
            }
        }

        //db저장 프로세스
        private void SaveProcess()
        {
            if (string.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            using (SqlConnection conn = new SqlConnection(commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (mode == "UPDATE")
                {
                    cmd.CommandText = " UPDATE dbo.membertbl " +
                                      " SET Names = @Names " +
                                      " ,Levels = @Levels " +
                                      " , Addr = @Addr " +
                                      " , Mobile = @Mobile " +
                                      " , Email = @Email " +
                                      " WHERE Idx = @Idx ";

                    SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.VarChar, 45);
                    parmNames.Value = TxtNames.Text;
                    cmd.Parameters.Add(parmNames); //이름 업데이트!

                    SqlParameter parmLevels = new SqlParameter("@Levels", SqlDbType.Char, 1);
                    parmLevels.Value = CboLevels.SelectedItem;
                    cmd.Parameters.Add(parmLevels);//레벨 업데이트

                    SqlParameter parmAddr = new SqlParameter("@Addr", SqlDbType.VarChar, 100);
                    parmAddr.Value = TxtAddr.Text;
                    cmd.Parameters.Add(parmAddr);

                    SqlParameter parmMobile = new SqlParameter("@Mobile", SqlDbType.VarChar, 13);
                    parmMobile.Value = TxtMobile.Text;
                    cmd.Parameters.Add(parmMobile);

                    SqlParameter parmEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                    parmEmail.Value = TxtEmail.Text;
                    cmd.Parameters.Add(parmEmail);

                    SqlParameter parmIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    parmIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(parmIdx);

                    cmd.ExecuteNonQuery();//excute는 넣을 때 쓰는건 NonQuery 그 외에건 가져올 때
                    UpdateData();

                }
                else if (mode == "INSERT")
                {
                    cmd.CommandText = "INSERT INTO dbo.membertbl " +
                                      " (Names, Levels, Addr, Mobile, Email) " +
                                      " VALUES(@Names, @Levels, @Addr, " +
                                      " @Mobile, @Email )";
                    SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.VarChar, 45);
                    parmNames.Value = TxtNames.Text;
                    cmd.Parameters.Add(parmNames); //이름 업데이트!

                    SqlParameter parmLevels = new SqlParameter("@Levels", SqlDbType.Char, 1);
                    parmLevels.Value = CboLevels.SelectedItem;
                    cmd.Parameters.Add(parmLevels);//레벨 업데이트

                    SqlParameter parmAddr = new SqlParameter("@Addr", SqlDbType.VarChar, 100);
                    parmAddr.Value = TxtAddr.Text;
                    cmd.Parameters.Add(parmAddr);

                    SqlParameter parmMobile = new SqlParameter("@Mobile", SqlDbType.VarChar, 13);
                    parmMobile.Value = TxtMobile.Text;
                    cmd.Parameters.Add(parmMobile);

                    SqlParameter parmEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                    parmEmail.Value = TxtEmail.Text;
                    cmd.Parameters.Add(parmEmail);


                    cmd.ExecuteNonQuery();//excute는 넣을 때 쓰는건 NonQuery 그 외에건 가져올 때
                    UpdateData();

                }

            }
        }

        private void DeleteProcess()
        {
            using (SqlConnection conn = new SqlConnection(commons.CONNSTRING))
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

        private void ClearTextControls()
        {
            TxtIdx.Text = TxtMobile.Text = "";
            TxtNames.Text = TxtMobile.Text = "";
            TxtAddr.Text = TxtMobile.Text = "";
            TxtMobile.Text = TxtMobile.Text = "";
            CboLevels.SelectedIndex = -1;
            TxtEmail.Text = TxtEmail.Text = "";
            TxtIdx.Text = TxtMobile.Text = "";
            TxtIdx.ReadOnly = true;
            TxtIdx.BackColor = Color.Beige;
            TxtNames.Focus();
        }

        //버튼 클릭

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextControls();
            mode = "INSERT"; //신규 INSERT
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAddr.Text)
               || string.IsNullOrEmpty(TxtMobile.Text)
               || string.IsNullOrEmpty(TxtEmail.Text)
               || string.IsNullOrEmpty(TxtNames.Text))
            {
                MetroMessageBox.Show(this, "빈 값은 저장할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //메세지 박스 버그 있을시, 리턴
            }

            SaveProcess();
            UpdateData();//데이터 그리드 DB 데이터 로딩하기 //값이 바로 바꾼것으로 보이기 위한 부분.
            ClearTextControls();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAddr.Text) || string.IsNullOrEmpty(TxtMobile.Text))
            {
                MetroMessageBox.Show(this, "빈 값은 삭제할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //메세지 박스 빠져 나오기 뭐 안되면 리턴하자
            }
            DeleteProcess();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            UpdateData();
            ClearTextControls();
        }

        private void TxtNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnSave_Click(sender, new EventArgs()); //txtNames_Keypress에서 엔터치면 바로 저장
            }
        }

        // 그리드뷰 데이터를 텍스트에 출력

        private void GrdMemberTbl_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // -1일때 == 선택이 안되어있을때
            {
                DataGridViewRow data = GrdMemberTbl.Rows[e.RowIndex]; //그리드의 인덱스에 대한 값 저장
                //배열의 행들 : DataGridViewRowCollection
                //배열의 한 행 : DataGridViewRow

                TxtIdx.BackColor = Color.Beige; //텍스트를 노란색으로 하여 수정이 불가하게 설정
                TxtIdx.ReadOnly = true;

                TxtIdx.Text = data.Cells[0].Value.ToString();
                TxtNames.Text = data.Cells[1].Value.ToString();
                CboLevels.SelectedIndex = CboLevels.FindString(data.Cells[2].Value.ToString()); //괄호안에 인덱스를 가지고 논다.
                TxtAddr.Text = data.Cells[3].Value.ToString();
                TxtMobile.Text = data.Cells[4].Value.ToString();
                TxtEmail.Text = data.Cells[5].Value.ToString();

                mode = "UPDATE";
            }
        }
    }
}
