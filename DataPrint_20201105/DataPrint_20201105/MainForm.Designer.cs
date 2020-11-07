namespace DataPrint_20201105
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserNameLB = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메인관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.사원관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.거래내역 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameLB
            // 
            this.UserNameLB.AutoSize = true;
            this.UserNameLB.Location = new System.Drawing.Point(1011, 33);
            this.UserNameLB.Name = "UserNameLB";
            this.UserNameLB.Size = new System.Drawing.Size(67, 15);
            this.UserNameLB.TabIndex = 0;
            this.UserNameLB.Text = "사용자 : ";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(1078, 33);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(0, 15);
            this.UserLabel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메인관리});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메인관리
            // 
            this.메인관리.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사용자관리,
            this.사원관리,
            this.거래내역});
            this.메인관리.Name = "메인관리";
            this.메인관리.Size = new System.Drawing.Size(122, 24);
            this.메인관리.Text = "시스템관리(M)";
            // 
            // 사용자관리
            // 
            this.사용자관리.Name = "사용자관리";
            this.사용자관리.Size = new System.Drawing.Size(224, 26);
            this.사용자관리.Text = "사용자관리(U)";
            this.사용자관리.Click += new System.EventHandler(this.사용자관리_Click);
            // 
            // 사원관리
            // 
            this.사원관리.Name = "사원관리";
            this.사원관리.Size = new System.Drawing.Size(224, 26);
            this.사원관리.Text = "사원관리(M)";
            this.사원관리.Click += new System.EventHandler(this.사원관리_Click);
            // 
            // 거래내역
            // 
            this.거래내역.Name = "거래내역";
            this.거래내역.Size = new System.Drawing.Size(224, 26);
            this.거래내역.Text = "거래내역(D)";
            this.거래내역.Click += new System.EventHandler(this.거래내역_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 577);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.UserNameLB);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "(주)포스텍 v1.0";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLB;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메인관리;
        private System.Windows.Forms.ToolStripMenuItem 사용자관리;
        private System.Windows.Forms.ToolStripMenuItem 사원관리;
        private System.Windows.Forms.ToolStripMenuItem 거래내역;
    }
}

