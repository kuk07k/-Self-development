using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace SF_MiniProject
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load_1(object sender, EventArgs e) // MainForm
        {
            LoginForm loginForm = new LoginForm(); // LoginForm 을 띄움
            loginForm.ShowDialog();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            UserIDtext.Text = Commons.LOGINUSERID;
        }

        private void InitChildForm(Form form, string strFormTitle)
        {
            form.Text = strFormTitle;
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;
            form.Show(); //form.ShowDialog(); : 부모폼에서 ShowDialog 쓰면 창 하나만 띄움
            form.WindowState = FormWindowState.Normal;
        }

        private void 시작_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // 자식폼 창을 전부 내리고 닫음
            {
                item.Close();
            }
        }

        private void 생산의뢰상담_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
            생산의뢰상담 form = new 생산의뢰상담();
            InitChildForm(form, "생산의뢰상담");
        }

        private void 생산의뢰서_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
            생산의뢰서 form = new 생산의뢰서();
            InitChildForm(form, "생산의뢰서");
        }

        private void 자주하는질문_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
            자주하는질문 form = new 자주하는질문();
            InitChildForm(form, "자주하는 질문");
        }

        private void 홈페이지_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
            홈페이지 form = new 홈페이지();
            InitChildForm(form, "홈페이지");
        }

        private void 제작자_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
            제작자 form = new 제작자();
            InitChildForm(form, "제작자");
        }

        private void 종료_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "정말 종료하시겠습니까?", "종료",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (Form item in this.MdiChildren) // 닫을때 에러 없애기
                {
                    item.Close(); // metro item 창을 전부 내리고 닫음
                }
                this.Close();
            }
            else
            {

            }
        }
    }
}
