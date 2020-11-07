namespace SF_MiniProject
{
    partial class LoginForm
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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.TxtUserID = new System.Windows.Forms.TextBox();
            this.TxtPassWordID = new System.Windows.Forms.TextBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.PassWordlabel = new System.Windows.Forms.Label();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.Loginlable2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.LoginBtn.CausesValidation = false;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(55, 389);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(304, 45);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(55, 440);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(304, 45);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // TxtUserID
            // 
            this.TxtUserID.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtUserID.Location = new System.Drawing.Point(55, 245);
            this.TxtUserID.MaxLength = 15;
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.Size = new System.Drawing.Size(304, 27);
            this.TxtUserID.TabIndex = 2;
            // 
            // TxtPassWordID
            // 
            this.TxtPassWordID.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtPassWordID.Location = new System.Drawing.Point(55, 313);
            this.TxtPassWordID.MaxLength = 15;
            this.TxtPassWordID.Name = "TxtPassWordID";
            this.TxtPassWordID.PasswordChar = '*';
            this.TxtPassWordID.Size = new System.Drawing.Size(304, 27);
            this.TxtPassWordID.TabIndex = 4;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IDlabel.Location = new System.Drawing.Point(51, 221);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(31, 28);
            this.IDlabel.TabIndex = 1;
            this.IDlabel.Text = "ID";
            // 
            // PassWordlabel
            // 
            this.PassWordlabel.AutoSize = true;
            this.PassWordlabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PassWordlabel.Location = new System.Drawing.Point(51, 289);
            this.PassWordlabel.Name = "PassWordlabel";
            this.PassWordlabel.Size = new System.Drawing.Size(97, 28);
            this.PassWordlabel.TabIndex = 3;
            this.PassWordlabel.Text = "Password";
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.Font = new System.Drawing.Font("Liberation Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginlabel.Location = new System.Drawing.Point(49, 118);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(133, 33);
            this.Loginlabel.TabIndex = 0;
            this.Loginlabel.Text = "안녕하세요!";
            // 
            // Loginlable2
            // 
            this.Loginlable2.AutoSize = true;
            this.Loginlable2.Font = new System.Drawing.Font("Liberation Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginlable2.Location = new System.Drawing.Point(49, 153);
            this.Loginlable2.Name = "Loginlable2";
            this.Loginlable2.Size = new System.Drawing.Size(207, 33);
            this.Loginlable2.TabIndex = 7;
            this.Loginlable2.Text = "로그인을 해주세요.";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(411, 529);
            this.ControlBox = false;
            this.Controls.Add(this.Loginlable2);
            this.Controls.Add(this.Loginlabel);
            this.Controls.Add(this.PassWordlabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.TxtPassWordID);
            this.Controls.Add(this.TxtUserID);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.LoginBtn);
            this.MaximumSize = new System.Drawing.Size(411, 529);
            this.MinimumSize = new System.Drawing.Size(411, 529);
            this.Name = "LoginForm";
            this.Text = "Smart Matching System";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox TxtUserID;
        private System.Windows.Forms.TextBox TxtPassWordID;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label PassWordlabel;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.Label Loginlable2;
    }
}

