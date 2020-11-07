namespace BookRentalShop20
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdUserTbl = new System.Windows.Forms.DataGridView();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUserTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GrdUserTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSave);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNew);
            this.splitContainer1.Panel2.Controls.Add(this.BtnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.TxtPassword);
            this.splitContainer1.Panel2.Controls.Add(this.TxtId);
            this.splitContainer1.Panel2.Controls.Add(this.TxtUserID);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(776, 422);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 0;
            // 
            // GrdUserTbl
            // 
            this.GrdUserTbl.AllowUserToAddRows = false;
            this.GrdUserTbl.AllowUserToDeleteRows = false;
            this.GrdUserTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdUserTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdUserTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdUserTbl.Name = "GrdUserTbl";
            this.GrdUserTbl.ReadOnly = true;
            this.GrdUserTbl.RowHeadersWidth = 51;
            this.GrdUserTbl.RowTemplate.Height = 27;
            this.GrdUserTbl.Size = new System.Drawing.Size(369, 422);
            this.GrdUserTbl.TabIndex = 0;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(287, 166);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 31);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(206, 166);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 31);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(125, 166);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 31);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(44, 166);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 31);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(126, 118);
            this.TxtPassword.MaxLength = 45;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(195, 25);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNames_KeyPress);
            // 
            // TxtUserID
            // 
            this.TxtUserID.Location = new System.Drawing.Point(126, 87);
            this.TxtUserID.MaxLength = 4;
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.Size = new System.Drawing.Size(195, 25);
            this.TxtUserID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "패스워드";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "아이디";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(125, 56);
            this.TxtId.MaxLength = 4;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(195, 25);
            this.TxtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "순번";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 502);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.DivForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdUserTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView GrdUserTbl;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
    }
}