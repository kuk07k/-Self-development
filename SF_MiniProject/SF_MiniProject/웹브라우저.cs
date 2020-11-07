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
    public partial class 웹브라우저 : MetroForm
    {
        private string strUrl;

        public 웹브라우저()
        {
            InitializeComponent();
        }

        public string PassUrl
        {
            get { return this.strUrl; }
            set { this.strUrl = value; }
        }

        private void 웹브라우저_Load(object sender, EventArgs e)
        {
            string Url = PassUrl;
            webBrowser1.Navigate(Url);
        }
    }
}
