namespace BookRentalShop20
{
    partial class RentalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdRentalTbl = new MetroFramework.Controls.MetroGrid();
            this.DtpRentalDate = new System.Windows.Forms.DateTimePicker();
            this.CboMemberIdx = new System.Windows.Forms.ComboBox();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.CboBookIdx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRentalTbl)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.GrdRentalTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CboBookIdx);
            this.splitContainer1.Panel2.Controls.Add(this.DtpReturnDate);
            this.splitContainer1.Panel2.Controls.Add(this.DtpRentalDate);
            this.splitContainer1.Panel2.Controls.Add(this.CboMemberIdx);
            this.splitContainer1.Panel2.Controls.Add(this.BtnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSave);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNew);
            this.splitContainer1.Panel2.Controls.Add(this.BtnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel4);
            this.splitContainer1.Panel2.Controls.Add(this.TxtIdx);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel3);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel6);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(960, 538);
            this.splitContainer1.SplitterDistance = 479;
            this.splitContainer1.TabIndex = 0;
            // 
            // GrdRentalTbl
            // 
            this.GrdRentalTbl.AllowUserToResizeRows = false;
            this.GrdRentalTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdRentalTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdRentalTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdRentalTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdRentalTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GrdRentalTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdRentalTbl.DefaultCellStyle = dataGridViewCellStyle5;
            this.GrdRentalTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdRentalTbl.EnableHeadersVisualStyles = false;
            this.GrdRentalTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdRentalTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdRentalTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdRentalTbl.Name = "GrdRentalTbl";
            this.GrdRentalTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdRentalTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GrdRentalTbl.RowHeadersWidth = 51;
            this.GrdRentalTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdRentalTbl.RowTemplate.Height = 27;
            this.GrdRentalTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdRentalTbl.Size = new System.Drawing.Size(479, 538);
            this.GrdRentalTbl.TabIndex = 0;
            this.GrdRentalTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDivTbl_CellClick);
            // 
            // DtpRentalDate
            // 
            this.DtpRentalDate.Location = new System.Drawing.Point(117, 231);
            this.DtpRentalDate.Name = "DtpRentalDate";
            this.DtpRentalDate.Size = new System.Drawing.Size(314, 25);
            this.DtpRentalDate.TabIndex = 3;
            this.DtpRentalDate.ValueChanged += new System.EventHandler(this.DtpReleaseDate_ValueChanged);
            // 
            // CboMemberIdx
            // 
            this.CboMemberIdx.FormattingEnabled = true;
            this.CboMemberIdx.Location = new System.Drawing.Point(112, 131);
            this.CboMemberIdx.Name = "CboMemberIdx";
            this.CboMemberIdx.Size = new System.Drawing.Size(317, 23);
            this.CboMemberIdx.TabIndex = 1;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(349, 431);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 38);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseSelectable = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(243, 431);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 38);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(137, 431);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(100, 38);
            this.BtnNew.TabIndex = 8;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(31, 431);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 38);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(7, 276);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 28);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "반환날짜";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtIdx
            // 
            // 
            // 
            // 
            this.TxtIdx.CustomButton.Image = null;
            this.TxtIdx.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.TxtIdx.CustomButton.Name = "";
            this.TxtIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdx.CustomButton.TabIndex = 1;
            this.TxtIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdx.CustomButton.UseSelectable = true;
            this.TxtIdx.CustomButton.Visible = false;
            this.TxtIdx.Lines = new string[0];
            this.TxtIdx.Location = new System.Drawing.Point(113, 80);
            this.TxtIdx.MaxLength = 100;
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.PasswordChar = '\0';
            this.TxtIdx.ReadOnly = true;
            this.TxtIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdx.SelectedText = "";
            this.TxtIdx.SelectionLength = 0;
            this.TxtIdx.SelectionStart = 0;
            this.TxtIdx.ShortcutsEnabled = true;
            this.TxtIdx.Size = new System.Drawing.Size(316, 23);
            this.TxtIdx.TabIndex = 0;
            this.TxtIdx.UseSelectable = true;
            this.TxtIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtIdx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDivision_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(6, 231);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 25);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "빌린날짜";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(7, 179);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(100, 28);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "책이름";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(6, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 28);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "멤버이름";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(7, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "대여번호";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DtpReturnDate
            // 
            this.DtpReturnDate.Location = new System.Drawing.Point(117, 279);
            this.DtpReturnDate.Name = "DtpReturnDate";
            this.DtpReturnDate.Size = new System.Drawing.Size(314, 25);
            this.DtpReturnDate.TabIndex = 4;
            this.DtpReturnDate.ValueChanged += new System.EventHandler(this.DtpReturnDate_ValueChanged);
            // 
            // CboBookIdx
            // 
            this.CboBookIdx.FormattingEnabled = true;
            this.CboBookIdx.Location = new System.Drawing.Point(113, 184);
            this.CboBookIdx.Name = "CboBookIdx";
            this.CboBookIdx.Size = new System.Drawing.Size(317, 23);
            this.CboBookIdx.TabIndex = 2;
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 618);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RentalForm";
            this.Text = "RentalForm";
            this.Load += new System.EventHandler(this.DivForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdRentalTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid GrdRentalTbl;
        private MetroFramework.Controls.MetroButton BtnCancel;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroTextBox TxtIdx;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ComboBox CboMemberIdx;
        private System.Windows.Forms.DateTimePicker DtpRentalDate;
        private System.Windows.Forms.DateTimePicker DtpReturnDate;
        private System.Windows.Forms.ComboBox CboBookIdx;
    }
}