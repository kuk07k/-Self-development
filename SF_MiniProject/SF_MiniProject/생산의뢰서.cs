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

namespace SF_MiniProject
{
    public partial class 생산의뢰서 : MetroForm
    {
        string strConnString = Commons.CONNSTRING;
        private string FacName;
        private int number;
        
        public string GetFacName
        {
            get { return this.FacName; }
            set { this.FacName = value; } // 폼과 폼사이 데이터 전송 셀클릭시 DB값 받아서 저장
        }

        public int GetNumber
        {
            get { return this.number; } // 보내기
            set { this.number = value; } // 받기 
        }

        public 생산의뢰서()
        {
            InitializeComponent();
        }

        private void 매칭확정_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(MainForm.ActiveForm, "공장매칭을 확정하시겠습니까?", "확인",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    string strQurey = ""; // 쿼리만들기

                    //INSERT 할때 쿼리
                    strQurey = "INSERT INTO Sample2(FacName, FacLocation, Size, Fabric, Division, Price) " +
                               "    VALUES (@FacName, @FacLocation, @Size, @Fabric, @Division, @Price) ";

                    cmd.CommandText = strQurey;

                    SqlParameter parmFacName = new SqlParameter("@FacName", SqlDbType.NChar, 10);
                    parmFacName.Value = CboName.Text;
                    cmd.Parameters.Add(parmFacName);

                    SqlParameter parmFacLocation = new SqlParameter("@FacLocation", SqlDbType.NVarChar, 10);
                    parmFacLocation.Value = CboFacLocation.Text;
                    cmd.Parameters.Add(parmFacLocation);

                    SqlParameter parmSize = new SqlParameter("@Size", SqlDbType.NChar, 3);
                    parmSize.Value = CboSize.Text;
                    cmd.Parameters.Add(parmSize);

                    SqlParameter parmFabric = new SqlParameter("@Fabric", SqlDbType.NVarChar, 10);
                    parmFabric.Value = CboFabric.Text;
                    cmd.Parameters.Add(parmFabric);

                    SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.NVarChar, 15);
                    parmDivision.Value = CboDivision.Text;
                    cmd.Parameters.Add(parmDivision);

                    SqlParameter parmPrice = new SqlParameter("@Price", SqlDbType.Int);
                    parmPrice.Value = Price.Text;
                    cmd.Parameters.Add(parmPrice);

                    cmd.ExecuteNonQuery();
                }
                MetroMessageBox.Show(MainForm.ActiveForm, "공장매칭이 확정되었습니다", "완료",
                             MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            UpdateData();
        }

        private void 매칭제거_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(MainForm.ActiveForm, "공장매칭을 취소하시겠습니까?", "확인",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                DeleteProcess();

                MetroMessageBox.Show(MainForm.ActiveForm, "공장매칭이 취소되었습니다", "완료",
                             MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            UpdateData();
        }

        private void 생산의뢰서_Load(object sender, EventArgs e)
        {
            OrderDate.Text = Commons.Date2;
            DeadLine.Text = Commons.Date3;

            if (!string.IsNullOrEmpty(FacName))
            {
                using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "SELECT FacName, FacLocation, Size, Fabric, Division, Price " +
                                      " FROM Sample1 " +
                                      " WHERE FacName = @FacName ";
                    SqlParameter param = new SqlParameter("@FacName", SqlDbType.NChar, 10);
                    param.Value = FacName;
                    cmd.Parameters.Add(param);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    CboName.Text        = reader[0].ToString();
                    CboFacLocation.Text = reader[1].ToString();
                    CboSize.Text        = reader[2].ToString();
                    CboFabric.Text      = reader[3].ToString();
                    CboDivision.Text    = reader[4].ToString();
                    Price.Text          = (int.Parse(reader[5].ToString()) * (number/50)).ToString();

                }
            }
            UpdateData(); // 데이터그리드 DB 데이터 로딩하기
        }

        private void GridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GridView2.Rows[e.RowIndex];
                CboName.Text         = data.Cells[0].Value.ToString();
                CboFacLocation.Text  = data.Cells[1].Value.ToString();
                CboSize.Text         = data.Cells[2].Value.ToString();
                CboFabric.Text       = data.Cells[3].Value.ToString();
                CboDivision.Text     = data.Cells[4].Value.ToString();
                Price.Text           = data.Cells[5].Value.ToString();
            }
        }

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open(); // DB 열기
                String strQuery = "SELECT FacName AS Name, FacLocation AS Location, Size, Fabric, Division, Price FROM Sample2";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn); // 명령 수행(sqlcommand 역할까지 수행)
                DataSet ds = new DataSet(); // 데이터를 담는통 (테이블)
                dataAdapter.Fill(ds, "Sample2"); // ds 통에다가 Sample2 이름으로 채운다

                GridView2.DataSource = ds; // GridView2에 붓는다
                GridView2.DataMember = "Sample2";
            }
        }

        private void DeleteProcess()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM dbo.Sample2 WHERE FacName = @FacName";

                SqlParameter parmFacName = new SqlParameter("@FacName", SqlDbType.NChar, 10);
                parmFacName.Value = CboName.Text;
                cmd.Parameters.Add(parmFacName);

                cmd.ExecuteNonQuery();
            }
        }

        private void 첨부_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "jpg";
            openFile.Filter = "Images Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            openFile.ShowDialog();
            if (openFile.FileNames.Length > 0)
            {
                foreach (string filename in openFile.FileNames)
                {
                    this.textBox1.Text = filename;
                }
            }
        }
    }
}
