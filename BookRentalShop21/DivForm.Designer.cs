namespace BookRentalShop20
{
    partial class DivForm
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
            this.GrdDivTbl = new System.Windows.Forms.DataGridView();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDivTbl)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.GrdDivTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSave);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNew);
            this.splitContainer1.Panel2.Controls.Add(this.BtnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.txtNames);
            this.splitContainer1.Panel2.Controls.Add(this.txtDivision);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(776, 422);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 0;
            // 
            // GrdDivTbl
            // 
            this.GrdDivTbl.AllowUserToAddRows = false;
            this.GrdDivTbl.AllowUserToDeleteRows = false;
            this.GrdDivTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdDivTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdDivTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdDivTbl.Name = "GrdDivTbl";
            this.GrdDivTbl.ReadOnly = true;
            this.GrdDivTbl.RowHeadersWidth = 51;
            this.GrdDivTbl.RowTemplate.Height = 27;
            this.GrdDivTbl.Size = new System.Drawing.Size(369, 422);
            this.GrdDivTbl.TabIndex = 0;
            this.GrdDivTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDivTbl_CellClick);
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(126, 87);
            this.txtDivision.MaxLength = 4;
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(195, 25);
            this.txtDivision.TabIndex = 0;
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(126, 118);
            this.txtNames.MaxLength = 45;
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(195, 25);
            this.txtNames.TabIndex = 1;
            this.txtNames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNames_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "구분 코드";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "이름";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(44, 166);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 31);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(125, 166);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 31);
            this.BtnNew.TabIndex = 3;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(206, 166);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 31);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(287, 166);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 31);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // DivForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 502);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DivForm";
            this.Text = "DivForm";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.DivForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDivTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView GrdDivTbl;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancel;
    }
}