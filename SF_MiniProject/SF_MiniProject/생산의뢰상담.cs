using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace SF_MiniProject
{
    public partial class 생산의뢰상담 : MetroForm
    {
        string strConnString = Commons.CONNSTRING;

        public 생산의뢰상담()
        {
            InitializeComponent();
        }

        private void MatchingMessageBox()
        {
            MetroMessageBox.Show(MainForm.ActiveForm, GridView.Rows.Count.ToString() + "개의 공장이 매칭되었습니다", "매칭 완료",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 공장매칭_Click(object sender, EventArgs e)
        {
            Matching();
            //HopeDate();
        }

        private void 생산의뢰_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MainForm.ActiveForm, "원하는 공장을 선택해주세요", "",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowmetheMoney()
        {
            int Price = 0;
            
            if (CboNumber.SelectedIndex == -1)
            {
                UnitPrice.Text = "";
            }

            else 
            {
                //=================================================================//
                int a = 0;
                if ("면" == CboFabric.SelectedItem.ToString()) { a = 100; }

                else if ("린넨" == CboFabric.SelectedItem.ToString()) { a = 200; }

                else { a = 300; }
                //=================================================================//
                int b = 0;
                if ("상의" == CboDivision.SelectedItem.ToString()) { b = 500; }

                else if ("하의" == CboDivision.SelectedItem.ToString()) { b = 600; }

                else { b = 700; }
                //=================================================================//

                int c = a + b;
                int d;
                if ("50" == CboNumber.SelectedItem.ToString()) { d = 50; }

                else if ("100" == CboNumber.SelectedItem.ToString()) { d = 100; }

                else if ("150" == CboNumber.SelectedItem.ToString()) { d = 150; }
       
                else if ("200" == CboNumber.SelectedItem.ToString()) { d = 200; }
   
                else if ("250" == CboNumber.SelectedItem.ToString()) { d = 250; }
   
                else { d = 300; }

                Price = c * d;
                UnitPrice.Text = Price.ToString("#,###");
            }
        }

        private void HopeDate()
        {
            int a = 0; // 생산지
            int plusdate = 0;
            if ("서울" == CboFacLocation.SelectedItem.ToString())
            {
                a = 1;
                int b = 0; //배송지: 서울~서울,대구,부산
                if ("서울" == CboLocation.SelectedItem.ToString()) { b = 1; }
                else if ("대구" == CboLocation.SelectedItem.ToString()) { b = 2; }
                else { b = 3; } //서울에서 부산으로
                plusdate = a + b;

            }
            else if ("대구" == CboFacLocation.SelectedItem.ToString())
            {
                a = 1;
                int c = 0; //배송지: 대구~서울,대구,부산
                if ("서울" == CboLocation.SelectedItem.ToString()) { c = 2; }
                else if ("대구" == CboLocation.SelectedItem.ToString()) { c = 1; }
                else { c = 2; }//대구에서 부산으로
                plusdate = a + c;
            }
            else
            {
                a = 1;
                int d = 0; //배송지: 부산~서울,대구,부산
                if ("서울" == CboLocation.SelectedItem.ToString()) { d = 3; }
                else if ("대구" == CboLocation.SelectedItem.ToString()) { d = 2; }
                else { d = 1; } //부산에서 부산으로
                plusdate = a + d;
            }

            if (OrderDateTimePicker.Value == DateTime.Now) // 만약 주문날짜가 지금 날짜라면
            {
                DeadLineTimePicker.Value = DateTime.Now.AddDays(plusdate);
                Commons.Date2 = DateTime.Now.ToString("yyyy년 MM월 dd일 dddd "); // 의뢰서 부분 날짜 표현 방법
                Commons.Date3 = DateTime.Now.AddDays(plusdate).ToString("yyyy년 MM월 dd일 dddd ");
            }
            else if (DateTime.Compare(DateTime.Now, OrderDateTimePicker.Value) > 0)
            {
                OrderDateTimePicker.Value = DateTime.Now;
                DeadLineTimePicker.Value = DateTime.Now.AddDays(plusdate);
                Commons.Date2 = DateTime.Now.ToString("yyyy년 MM월 dd일 dddd "); // 의뢰서 부분 날짜 표현 방법
                Commons.Date3 = DateTime.Now.AddDays(plusdate).ToString("yyyy년 MM월 dd일 dddd ");
                //MetroMessageBox.Show(MainForm.ActiveForm, "현재 날짜 이후로 선택해주세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DeadLineTimePicker.Value = OrderDateTimePicker.Value.AddDays(plusdate);
                Commons.Date2 = OrderDateTimePicker.Value.ToString("yyyy년 MM월 dd일 dddd ");
                Commons.Date3 = OrderDateTimePicker.Value.AddDays(plusdate).ToString("yyyy년 MM월 dd일 dddd ");
            }
        }

        private void OrderDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            OrderDateTimePicker.CustomFormat = "yyyy년 MM월 dd일 dddd ";   
            OrderDateTimePicker.Format = DateTimePickerFormat.Custom;
        }

        private void Matching()
        {
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open();

                //6개 전부 선택했을때
                if (CboDivision.SelectedIndex != -1
                    && CboSize.SelectedIndex != -1
                    && CboFabric.SelectedIndex != -1
                    && CboFacLocation.SelectedIndex != -1
                    && CboNumber.SelectedIndex != -1
                    && CboLocation.SelectedIndex != -1)
                {
                    string strQuery = " SELECT FacName AS Name, FacLocation AS Location, Size, Fabric, Division, (Price * @Price) AS Price, Grade " +
                                      " FROM dbo.Sample1 " +
                                      " WHERE Size = @Size " +
                                      " and Fabric = @Fabric " +
                                      " and Division = @Division " +
                                      " and FacLocation = @FacLocation " +
                                      " ORDER BY Price ASC, GradeNum DESC ";

                    SqlParameter parmSize = new SqlParameter("@Size", SqlDbType.NChar, 3);
                    parmSize.Value = CboSize.SelectedItem;

                    SqlParameter parmFabric = new SqlParameter("@Fabric", SqlDbType.NVarChar, 10);
                    parmFabric.Value = CboFabric.SelectedItem;

                    SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.NVarChar, 15);
                    parmDivision.Value = CboDivision.SelectedItem;

                    SqlParameter parmFacLocation = new SqlParameter("@FacLocation", SqlDbType.VarChar, 20);
                    parmFacLocation.Value = CboFacLocation.SelectedItem;

                    SqlParameter parmPrice = new SqlParameter("@Price", SqlDbType.Int);
                    parmPrice.Value = int.Parse(CboNumber.SelectedItem.ToString());

                    // 파라미터는 메서드의 인자

                    if ("50" == CboNumber.SelectedItem.ToString())
                    {
                        //int.Parse(CboNumber.SelectedItem.ToString()) = 1;
                        parmPrice.Value = 1;
                    }
                    else if ("100" == CboNumber.SelectedItem.ToString())
                    {
                        parmPrice.Value = 2;
                    }
                    else if ("150" == CboNumber.SelectedItem.ToString())
                    {
                        parmPrice.Value = 3;
                    }
                    else if ("200" == CboNumber.SelectedItem.ToString())
                    {
                        parmPrice.Value = 4;
                    }
                    else if ("250" == CboNumber.SelectedItem.ToString())
                    {
                        parmPrice.Value = 5;
                    }
                    else if ("300" == CboNumber.SelectedItem.ToString())
                    {
                        parmPrice.Value = 6;
                    }

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                    DataSet ds = new DataSet();

                    dataAdapter.SelectCommand.Parameters.Add(parmSize);
                    dataAdapter.SelectCommand.Parameters.Add(parmFabric);
                    dataAdapter.SelectCommand.Parameters.Add(parmDivision);
                    dataAdapter.SelectCommand.Parameters.Add(parmFacLocation);
                    dataAdapter.SelectCommand.Parameters.Add(parmPrice);

                    dataAdapter.Fill(ds, "Sample1");

                    GridView.DataSource = ds;
                    GridView.DataMember = "Sample1";

                    HopeDate();
                    ShowmetheMoney();
                    MatchingMessageBox();
                }

                else if (CboDivision.SelectedIndex == -1
                    && CboSize.SelectedIndex == -1
                    && CboFabric.SelectedIndex == -1
                    && CboFacLocation.SelectedIndex == -1
                    && CboNumber.SelectedIndex == -1
                    && CboLocation.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(MainForm.ActiveForm, "필수항목을 선택해주세요", "확인",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MetroMessageBox.Show(MainForm.ActiveForm, "필수항목을 선택해주세요", "확인",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //// 집주소가 빈칸일때
                //else if (CboDivision.SelectedIndex != -1
                //    && CboSize.SelectedIndex != -1
                //    && CboFabric.SelectedIndex != -1
                //    && CboFacLocation.SelectedIndex != -1
                //    && CboNumber.SelectedIndex != -1
                //    && CboLocation.SelectedIndex == -1)
                //{
                //    string strQuery = " SELECT FacName AS Name, FacLocation AS Location, Size, Fabric, Division, (Price * @Price) AS Price, Grade " +
                //                      " FROM dbo.Sample1 " +
                //                      " WHERE Size = @Size " +
                //                      " and Fabric = @Fabric " +
                //                      " and Division = @Division " +
                //                      " and FacLocation = @FacLocation " +
                //                      " ORDER BY Price ASC, GradeNum DESC ";

                //    SqlParameter parmSize = new SqlParameter("@Size", SqlDbType.NChar, 3);
                //    parmSize.Value = CboSize.SelectedItem;

                //    SqlParameter parmFabric = new SqlParameter("@Fabric", SqlDbType.NVarChar, 10);
                //    parmFabric.Value = CboFabric.SelectedItem;

                //    SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.NVarChar, 15);
                //    parmDivision.Value = CboDivision.SelectedItem;

                //    SqlParameter parmFacLocation = new SqlParameter("@FacLocation", SqlDbType.VarChar, 20);
                //    parmFacLocation.Value = CboFacLocation.SelectedItem;

                //    SqlParameter parmPrice = new SqlParameter("@Price", SqlDbType.Int);
                //    parmPrice.Value = int.Parse(CboNumber.SelectedItem.ToString());

                //    // 파라미터는 메서드의 인자

                //    if ("50" == CboNumber.SelectedItem.ToString())
                //    {
                //        //int.Parse(CboNumber.SelectedItem.ToString()) = 1;
                //        parmPrice.Value = 1;
                //    }
                //    else if ("100" == CboNumber.SelectedItem.ToString())
                //    {
                //        parmPrice.Value = 2;
                //    }
                //    else if ("150" == CboNumber.SelectedItem.ToString())
                //    {
                //        parmPrice.Value = 3;
                //    }
                //    else if ("200" == CboNumber.SelectedItem.ToString())
                //    {
                //        parmPrice.Value = 4;
                //    }
                //    else if ("250" == CboNumber.SelectedItem.ToString())
                //    {
                //        parmPrice.Value = 5;
                //    }
                //    else if ("300" == CboNumber.SelectedItem.ToString())
                //    {
                //        parmPrice.Value = 6;
                //    }

                //    SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                //    DataSet ds = new DataSet();

                //    dataAdapter.SelectCommand.Parameters.Add(parmSize);
                //    dataAdapter.SelectCommand.Parameters.Add(parmFabric);
                //    dataAdapter.SelectCommand.Parameters.Add(parmDivision);
                //    dataAdapter.SelectCommand.Parameters.Add(parmFacLocation);
                //    dataAdapter.SelectCommand.Parameters.Add(parmPrice);

                //    dataAdapter.Fill(ds, "Sample1");

                //    GridView.DataSource = ds;
                //    GridView.DataMember = "Sample1";

                //    ShowmetheMoney();
                //    MatchingMessageBox();
                //}


                ////재질, 사이즈, 구분, 공장주소만 선택
                //if (CboDivision.SelectedIndex != -1
                //    && CboSize.SelectedIndex != -1
                //    && CboFabric.SelectedIndex != -1
                //    && CboFacLocation.SelectedIndex != -1)
                //{
                //    string strQuery = " SELECT FacName AS Name, FacLocation AS Location, Size, Fabric, Division, Price, Grade " +
                //                      " FROM dbo.Sample1 " +
                //                      " WHERE Size = @Size " +
                //                      " and Fabric = @Fabric " +
                //                      " and Division = @Division " +
                //                      " and FacLocation = @FacLocation " +
                //                      " ORDER BY Price ASC, GradeNum DESC ";

                //    SqlParameter parmSize = new SqlParameter("@Size", SqlDbType.NChar, 3);
                //    parmSize.Value = CboSize.SelectedItem;

                //    SqlParameter parmFabric = new SqlParameter("@Fabric", SqlDbType.NVarChar, 10);
                //    parmFabric.Value = CboFabric.SelectedItem;

                //    SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.NVarChar, 15);
                //    parmDivision.Value = CboDivision.SelectedItem;

                //    SqlParameter parmFacLocation = new SqlParameter("@FacLocation", SqlDbType.VarChar, 20);
                //    parmFacLocation.Value = CboFacLocation.SelectedItem;



                //    // 파라미터는 메서드의 인자



                //    SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                //    DataSet ds = new DataSet();

                //    dataAdapter.SelectCommand.Parameters.Add(parmSize);
                //    dataAdapter.SelectCommand.Parameters.Add(parmFabric);
                //    dataAdapter.SelectCommand.Parameters.Add(parmDivision);
                //    dataAdapter.SelectCommand.Parameters.Add(parmFacLocation);

                //    dataAdapter.Fill(ds, "Sample1");

                //    GridView.DataSource = ds;
                //    GridView.DataMember = "Sample1";

                //    MatchingMessageBox();
                //}

                //// 재질, 사이즈, 구분, 개수만 선택
                //else if (CboDivision.SelectedIndex != -1
                //      && CboSize.SelectedIndex != -1
                //      && CboFabric.SelectedIndex != -1
                //      && CboNumber.SelectedIndex != -1)
                //{
                //    string strQuery = " SELECT FacName AS Name, FacLocation AS Location, Size, Fabric, Division, (Price * @Price) AS Price, Grade " +
                //                      " FROM dbo.Sample1 " +
                //                      " WHERE Size = @Size " +
                //                      " and Fabric = @Fabric " +
                //                      " and Division = @Division " +
                //                      " ORDER BY Price ASC, GradeNum DESC ";

                //    SqlParameter parmSize = new SqlParameter("@Size", SqlDbType.NChar, 3);
                //    parmSize.Value = CboSize.SelectedItem;

                //    SqlParameter parmFabric = new SqlParameter("@Fabric", SqlDbType.NVarChar, 10);
                //    parmFabric.Value = CboFabric.SelectedItem;

                //    SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.NVarChar, 15);
                //    parmDivision.Value = CboDivision.SelectedItem;

                //    SqlParameter parmPrice = new SqlParameter("@Price", SqlDbType.Int);
                //    parmPrice.Value = int.Parse(CboNumber.SelectedItem.ToString());

                //    // 파라미터는 메서드의 인자

                //    if ("50" == CboNumber.SelectedItem.ToString())
                //    {
                //        //int.Parse(CboNumber.SelectedItem.ToString()) = 1;
                //        parmPrice.Value = 1;
                //    }
                //    else if ("100" == CboNumber.SelectedItem.ToString())
                //    {
                //        parmPrice.Value = 2;
                //    }
                //    else if ("150" == CboNumber.SelectedItem.ToString())
                //    {
                //        parmPrice.Value = 3;
                //    }
                //    else if ("200" == CboNumber.SelectedItem.ToString())
                //    {
                //        parmPrice.Value = 4;
                //    }
                //    else if ("250" == CboNumber.SelectedItem.ToString())
                //    {
                //        parmPrice.Value = 5;
                //    }
                //    else if ("300" == CboNumber.SelectedItem.ToString())
                //    {
                //        parmPrice.Value = 6;
                //    }

                //    SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                //    DataSet ds = new DataSet();

                //    dataAdapter.SelectCommand.Parameters.Add(parmSize);
                //    dataAdapter.SelectCommand.Parameters.Add(parmFabric);
                //    dataAdapter.SelectCommand.Parameters.Add(parmDivision);
                //    dataAdapter.SelectCommand.Parameters.Add(parmPrice);

                //    dataAdapter.Fill(ds, "Sample1");

                //    GridView.DataSource = ds;
                //    GridView.DataMember = "Sample1";

                //    ShowmetheMoney();
                //    MatchingMessageBox();
                //}

                ////구분만 선택
                //else if (CboDivision.SelectedIndex != -1 && CboSize.SelectedIndex == -1 && CboFabric.SelectedIndex == -1)
                //{
                //    MetroMessageBox.Show(MainForm.ActiveForm, "필수항목을 선택해주세요", "확인",
                //                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}

                ////사이즈만 선택
                //else if (CboDivision.SelectedIndex == -1 && CboSize.SelectedIndex != -1 && CboFabric.SelectedIndex == -1)
                //{
                //    MetroMessageBox.Show(MainForm.ActiveForm, "필수항목을 선택해주세요", "확인",
                //                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}

                ////재질만선택
                //else if (CboDivision.SelectedIndex == -1 && CboSize.SelectedIndex == -1 && CboFabric.SelectedIndex != -1)
                //{
                //    MetroMessageBox.Show(MainForm.ActiveForm, "필수항목을 선택해주세요", "확인",
                //                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}

                ////구분, 사이즈만 선택
                //else if (CboDivision.SelectedIndex != -1 && CboSize.SelectedIndex != -1 && CboFabric.SelectedIndex == -1)
                //{
                //    MetroMessageBox.Show(MainForm.ActiveForm, "필수항목을 선택해주세요", "확인",
                //                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}

                ////사이즈, 재질만 선택
                //else if (CboDivision.SelectedIndex == -1 && CboSize.SelectedIndex != -1 && CboFabric.SelectedIndex != -1)
                //{
                //    MetroMessageBox.Show(MainForm.ActiveForm, "필수항목을 선택해주세요", "확인",
                //                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}

                ////구분, 재질만 선택
                //else if (CboDivision.SelectedIndex != -1 && CboSize.SelectedIndex == -1 && CboFabric.SelectedIndex != -1)
                //{
                //    MetroMessageBox.Show(MainForm.ActiveForm, "필수항목을 선택해주세요", "확인",
                //                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            }
        }
        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            생산의뢰서 form = new 생산의뢰서();
            DataGridViewRow data = GridView.Rows[e.RowIndex];
            form.GetFacName = data.Cells[0].Value.ToString();
            form.GetNumber = int.Parse(CboNumber.Text);
            form.Text = "생산의뢰서";
            form.Show();
            form.WindowState = FormWindowState.Normal;
        }
    }
}
