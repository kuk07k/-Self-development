using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace DataPrint_20201105
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            UserLabel.Text = commons.LOGINUSERID;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroMessageBox.Show(this, "정말 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form item in this.MdiChildren)
                {
                    item.Close();
                }
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void InitChildForm(Form form, string strFormTitle)
        {
            form.Text = strFormTitle;
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void 사용자관리_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            InitChildForm(form, "사용자 관리");
        }

        private void 사원관리_Click(object sender, EventArgs e)
        {
            MemberForm form = new MemberForm();
            InitChildForm(form, "사원관리");
        }

        private void 거래내역_Click(object sender, EventArgs e)
        {
            DealForm form = new DealForm();
            InitChildForm(form, "거래내역");
        }
    }
}
