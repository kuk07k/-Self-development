namespace BookRentalShop20
{
    partial class MemberForm
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
            this.GrdMemberTbl = new System.Windows.Forms.DataGridView();
            this.CboLevels = new System.Windows.Forms.ComboBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtNames = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtMobile = new System.Windows.Forms.TextBox();
            this.TxtIdx = new System.Windows.Forms.TextBox();
            this.TxtAddr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMemberTbl)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.GrdMemberTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CboLevels);
            this.splitContainer1.Panel2.Controls.Add(this.BtnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSave);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNew);
            this.splitContainer1.Panel2.Controls.Add(this.BtnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.TxtNames);
            this.splitContainer1.Panel2.Controls.Add(this.TxtEmail);
            this.splitContainer1.Panel2.Controls.Add(this.TxtMobile);
            this.splitContainer1.Panel2.Controls.Add(this.TxtIdx);
            this.splitContainer1.Panel2.Controls.Add(this.TxtAddr);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(776, 422);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 0;
            // 
            // GrdMemberTbl
            // 
            this.GrdMemberTbl.AllowUserToAddRows = false;
            this.GrdMemberTbl.AllowUserToDeleteRows = false;
            this.GrdMemberTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdMemberTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdMemberTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdMemberTbl.Name = "GrdMemberTbl";
            this.GrdMemberTbl.ReadOnly = true;
            this.GrdMemberTbl.RowHeadersWidth = 51;
            this.GrdMemberTbl.RowTemplate.Height = 27;
            this.GrdMemberTbl.Size = new System.Drawing.Size(369, 422);
            this.GrdMemberTbl.TabIndex = 0;
            this.GrdMemberTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDivTbl_CellClick);
            this.GrdMemberTbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdMemberTbl_CellContentClick);
            // 
            // CboLevels
            // 
            this.CboLevels.FormattingEnabled = true;
            this.CboLevels.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CboLevels.Location = new System.Drawing.Point(126, 147);
            this.CboLevels.Name = "CboLevels";
            this.CboLevels.Size = new System.Drawing.Size(195, 23);
            this.CboLevels.TabIndex = 2;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(288, 319);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 31);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(207, 319);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 31);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(126, 319);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 31);
            this.BtnNew.TabIndex = 7;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(45, 319);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 31);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtNames
            // 
            this.TxtNames.Location = new System.Drawing.Point(126, 116);
            this.TxtNames.MaxLength = 45;
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.Size = new System.Drawing.Size(195, 25);
            this.TxtNames.TabIndex = 1;
            this.TxtNames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNames_KeyPress);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(126, 238);
            this.TxtEmail.MaxLength = 50;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(195, 25);
            this.TxtEmail.TabIndex = 5;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNames_KeyPress);
            // 
            // TxtMobile
            // 
            this.TxtMobile.Location = new System.Drawing.Point(126, 207);
            this.TxtMobile.MaxLength = 13;
            this.TxtMobile.Name = "TxtMobile";
            this.TxtMobile.Size = new System.Drawing.Size(195, 25);
            this.TxtMobile.TabIndex = 4;
            this.TxtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNames_KeyPress);
            // 
            // TxtIdx
            // 
            this.TxtIdx.Location = new System.Drawing.Point(126, 85);
            this.TxtIdx.MaxLength = 1;
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.Size = new System.Drawing.Size(195, 25);
            this.TxtIdx.TabIndex = 0;
            // 
            // TxtAddr
            // 
            this.TxtAddr.Location = new System.Drawing.Point(126, 176);
            this.TxtAddr.MaxLength = 100;
            this.TxtAddr.Name = "TxtAddr";
            this.TxtAddr.Size = new System.Drawing.Size(195, 25);
            this.TxtAddr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "이름";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "이메일";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "핸드폰 번호";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "등급";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "순번";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "주소";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 502);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MemberForm";
            this.Text = "MemberForm";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.MemberForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdMemberTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView GrdMemberTbl;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtMobile;
        private System.Windows.Forms.TextBox TxtAddr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox CboLevels;
        private System.Windows.Forms.TextBox TxtNames;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtIdx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}