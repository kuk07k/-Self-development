using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SF_MiniProject
{
    public partial class 홈페이지 : MetroForm
    {
        public 홈페이지()
        {
            InitializeComponent();
        }

        private void zara_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            웹브라우저 form = new 웹브라우저();
            form.PassUrl = zara.Text;
            form.Show();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(190, 70);
        }

        private void blackyak_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            웹브라우저 form = new 웹브라우저();
            form.PassUrl = blackyak.Text;
            form.Show();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(190, 70);
        }

        private void crocodile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            웹브라우저 form = new 웹브라우저();
            form.PassUrl = crocodile.Text;
            form.Show();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(190, 70);
        }

        private void konny_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            웹브라우저 form = new 웹브라우저();
            form.PassUrl = konny.Text;
            form.Show();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(190, 70);
        }

        private void kfq_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            웹브라우저 form = new 웹브라우저();
            form.PassUrl = kfq.Text;
            form.Show();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(190, 70);
        }

        private void madeby_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            웹브라우저 form = new 웹브라우저();
            form.PassUrl = madeby.Text;
            form.Show();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(190, 70);
        }

        private void osle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            웹브라우저 form = new 웹브라우저();
            form.PassUrl = osle.Text;
            form.Show();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(190, 70);
        }

        private void hm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            웹브라우저 form = new 웹브라우저();
            form.PassUrl = hm.Text;
            form.Show();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(190, 70);
        }

        private void pro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            웹브라우저 form = new 웹브라우저();
            form.PassUrl = pro.Text;
            form.Show();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(190, 70);
        }
    }
}
