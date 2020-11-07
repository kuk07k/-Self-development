using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.WindowState = FormWindowState.Maximized;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MetroMessageBox.Show(this, "정말 종료하시겠습니까", "종료",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {//메세지 박스의 Yes No 버튼에 따른 조건문
                    foreach (var item in this.MdiChildren)
                    {
                        item.Close();
                    }
                    e.Cancel = false;

                }
                else
                { //이것만 있으면 아무리 x버튼 눌러도 종료가 안된다.
                    e.Cancel = true;
                }
            }
            catch
            { 
            }
            
        }

        private void MnuItemDivMng_Click(object sender, System.EventArgs e)
        {
            DivForm form = new DivForm();
            InitChildForm(form,"구분코드 관리");
        }

        private void InitChildForm(Form form, string strFormTitle)
        {
            form.Text = strFormTitle;
            form.Dock = DockStyle.Fill; //회색 화면을 꽉채운다.
            form.MdiParent = this; //메인폼에서 child로 띄우는 거니까 부모를 해줘야한다.
            //multi document interface 
            //this 는 자식의 위치에서 부모가 
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void 사용자관리UToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            UserForm form = new UserForm();
            InitChildForm(form, "사용자 관리");

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 회원관리MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberForm form = new MemberForm();
            InitChildForm(form, "회원 관리");
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            LblUserID.Text = Commons.LOGINUSERID;
        }

        private void 책관리BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksForm form = new BooksForm();
            InitChildForm(form, "책 관리");
        }

        private void 대여관리RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentalForm form = new RentalForm();
            InitChildForm(form, "대여 관리");
        }
    }
}
