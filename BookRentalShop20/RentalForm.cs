using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShop20
{
    public partial class RentalForm : MetroForm
    {
        string mode = "";
        public RentalForm()
        {
            InitializeComponent();
        }

        private void DivForm_Load(object sender, EventArgs e)
        {
            DtpRentalDate.CustomFormat = " ";
            DtpReturnDate.Format = DateTimePickerFormat.Custom;
            DtpReturnDate.CustomFormat = " ";
            DtpReturnDate.Format = DateTimePickerFormat.Custom;
            UpdateData();   //  데이터그리드에 DB 데이터 로딩하기
            UpdateCboDivision();
            UpdateCboBookIdx();
        }

        private void UpdateCboBookIdx()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Idx, Names " +
                                  "  FROM bookstbl ";
                //" INNER JOIN membertbl AS m ON r.memberIdx = m.Idx ";
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> temps = new Dictionary<string, string>();
                while (reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                CboBookIdx.DataSource = new BindingSource(temps, null);
                CboBookIdx.DisplayMember = "Value";
                CboBookIdx.ValueMember = "Key";
                CboBookIdx.SelectedIndex = -1;
            }
        }

        private void UpdateCboDivision()
        {
            using(SqlConnection conn = new SqlConnection(Commons.CONSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Idx, Names " +
                                  "  FROM membertbl ";
                                  //" INNER JOIN membertbl AS m ON r.memberIdx = m.Idx ";
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> temps = new Dictionary<string, string>();
                while (reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                CboMemberIdx.DataSource = new BindingSource(temps, null);
                CboMemberIdx.DisplayMember = "Value";
                CboMemberIdx.ValueMember = "Key";
                CboMemberIdx.SelectedIndex = -1;
            }
        }

        private void UpdateData()
        {
            //throw new NotImplementedException();
            using (SqlConnection conn = new SqlConnection(Commons.CONSTRING))
            {
                conn.Open();    //  DB열기
                string strQuery = "SELECT r.idx AS '대여번호', " +
                                  "      m.Names AS '대여회원', " +
                                  "      r.memberIdx AS '멤버번호', " +
                                  "      t.Names AS '장르', " +
                                  "      b.Names AS '대여책제목'," +
                                  "      b.ISBN, " +
                                  "      r.rentalDate AS '대여일', " + // 6
                                  "      r.returnDate AS '반납일' " + // 7
                                  "  FROM rentaltbl AS r " +
                                  " INNER JOIN membertbl AS m ON r.memberIdx = m.Idx " +
                                  " INNER JOIN bookstbl AS b ON r.bookIdx = b.Idx " +
                                  "INNER JOIN divtbl AS t ON b.division = t.division; "; //  검색할 쿼리문
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);    //  플러그에 쿼리문이랑 데이터 연결할꺼
                DataSet ds = new DataSet(); //  데이터 통을 만듬
                dataAdapter.Fill(ds, "rentaltbl");     //  데이터 통을 채움 divtbl이라는 이름으로

                GrdRentalTbl.DataSource = ds;      //  GrdDivtbl에 부어넣음
                GrdRentalTbl.DataMember = "rentaltbl";
            }
            DataGridViewColumn column = GrdRentalTbl.Columns[2]; 
            column.Visible = false;
            column = GrdRentalTbl.Columns[7]; 
            column.Visible = false;
        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                DataGridViewRow data = GrdRentalTbl.Rows[e.RowIndex];  //  Rows중에 한 행을 선택했으므로 DataGridViewRow이다.
                TxtIdx.Text = data.Cells[0].Value.ToString();    
                TxtIdx.ReadOnly = true;
                TxtIdx.BackColor = Color.Beige;
                CboMemberIdx.SelectedIndex = CboMemberIdx.FindString(data.Cells[1].Value.ToString());   //  글자로 findstring으로 인덱스 찾음
                CboBookIdx.SelectedIndex = CboBookIdx.FindString(data.Cells[4].Value.ToString());   //  글자로 findstring으로 인덱스 찾음

                DtpRentalDate.CustomFormat = "yyyy-MM-dd";
                DtpRentalDate.Format = DateTimePickerFormat.Custom;
                DtpRentalDate.Value = DateTime.Parse(data.Cells[6].Value.ToString());

                DtpReturnDate.CustomFormat = "yyyy-MM-dd";
                DtpReturnDate.Format = DateTimePickerFormat.Custom;
                if(String.IsNullOrEmpty(data.Cells[7].Value.ToString()))
                {
                    DtpReturnDate.CustomFormat = " ";
                    DtpReturnDate.Format = DateTimePickerFormat.Custom;
                }
                else 
                {
                    DtpReturnDate.CustomFormat = "yyyy-MM-dd";
                    DtpReturnDate.Format = DateTimePickerFormat.Custom;
                    DtpReturnDate.Value = DateTime.Parse(data.Cells[7].Value.ToString());
                }

                mode = "UPDATE";    //수정은 UPDATE
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextControls();
            mode = "INSERT"; //신규는 INSERT
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveProcess();
        }

        private void ClearTextControls()
        {
            TxtIdx.Text = "";
            TxtIdx.ReadOnly = true;
            CboMemberIdx.SelectedIndex = -1;
            CboBookIdx.SelectedIndex = -1;
            TxtIdx.BackColor = Color.Beige;
            DtpRentalDate.CustomFormat = " ";
            DtpRentalDate.Format = DateTimePickerFormat.Custom;
            DtpReturnDate.CustomFormat = " ";
            DtpReturnDate.Format = DateTimePickerFormat.Custom;
        }

        private void SaveProcess()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONSTRING))
            {
                if(String.IsNullOrEmpty(mode))
                {
                    MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }    
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (mode == "UPDATE")
                {
                    cmd.CommandText = "UPDATE dbo.rentaltbl " +
                                      "   SET memberIdx = @memberIdx, " +
                                      "       bookIdx = @bookIdx, " +
                                      "       rentalDate = @rentalDate, " +
                                      "       returnDate = @returnDate " +
                                      " WHERE Idx = @Idx";
                    SqlParameter parmIdx = new SqlParameter("@Idx", SqlDbType.Int, 100);
                    parmIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(parmIdx);
                }
                else if (mode == "INSERT")
                {
                    cmd.CommandText = "INSERT INTO dbo.rentaltbl (memberIdx,bookIdx,rentalDate,returnDate) " +
                                      "VALUES (@memberIdx ,@bookIdx,@rentalDate,@returnDate) ";
                }

                SqlParameter parmMemberIdx = new SqlParameter("@memberIdx", SqlDbType.Char, 4);
                parmMemberIdx.Value = CboMemberIdx.SelectedValue;
                cmd.Parameters.Add(parmMemberIdx);


                SqlParameter parmBookIdx = new SqlParameter("@bookIdx", SqlDbType.Char, 4);
                parmBookIdx.Value = CboBookIdx.SelectedValue;
                cmd.Parameters.Add(parmBookIdx);


                SqlParameter parmRentalDate = new SqlParameter("@rentalDate", SqlDbType.Date);
                parmRentalDate.Value = DtpRentalDate.Value;
                cmd.Parameters.Add(parmRentalDate);

                SqlParameter parmReturnDate = new SqlParameter("@returnDate", SqlDbType.Date);
                parmReturnDate.Value = DtpReturnDate.Value;
                cmd.Parameters.Add(parmReturnDate);


                cmd.ExecuteNonQuery();
            }
            UpdateData();
            ClearTextControls();
        }

        private void TxtDivision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                BtnSave_Click(sender, new EventArgs());
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            mode = "DELETE";
            if (String.IsNullOrEmpty(TxtIdx.Text))
            {
                MetroMessageBox.Show(this, "빈값은 삭제할 수 없습니다", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DeleteProcess();
        }

        private void DeleteProcess()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM dbo.divtbl" +
                                  " WHERE Division = @Division";

                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDivision.Value = TxtIdx.Text;
                cmd.Parameters.Add(parmDivision);
                cmd.ExecuteNonQuery();
            }
            UpdateData();
            ClearTextControls();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            DtpRentalDate.CustomFormat = "yyyy-MM-dd";
            DtpRentalDate.Format = DateTimePickerFormat.Custom;
        }

        private void DtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            DtpReturnDate.CustomFormat = "yyyy-MM-dd";
            DtpReturnDate.Format = DateTimePickerFormat.Custom;
        }
    }
}
