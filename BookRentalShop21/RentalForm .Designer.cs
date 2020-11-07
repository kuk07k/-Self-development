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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdBooksTbl = new System.Windows.Forms.DataGridView();
            this.DtpRentalDate = new System.Windows.Forms.DateTimePicker();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtIdx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.CboName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CboBook = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdBooksTbl)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.GrdBooksTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CboBook);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.DtpReturnDate);
            this.splitContainer1.Panel2.Controls.Add(this.DtpRentalDate);
            this.splitContainer1.Panel2.Controls.Add(this.CboName);
            this.splitContainer1.Panel2.Controls.Add(this.BtnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSave);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNew);
            this.splitContainer1.Panel2.Controls.Add(this.BtnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.TxtIdx);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(776, 422);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 0;
            // 
            // GrdBooksTbl
            // 
            this.GrdBooksTbl.AllowUserToAddRows = false;
            this.GrdBooksTbl.AllowUserToDeleteRows = false;
            this.GrdBooksTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdBooksTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdBooksTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdBooksTbl.Name = "GrdBooksTbl";
            this.GrdBooksTbl.ReadOnly = true;
            this.GrdBooksTbl.RowHeadersWidth = 51;
            this.GrdBooksTbl.RowTemplate.Height = 27;
            this.GrdBooksTbl.Size = new System.Drawing.Size(369, 422);
            this.GrdBooksTbl.TabIndex = 0;
            this.GrdBooksTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDivTbl_CellClick);
            this.GrdBooksTbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdMemberTbl_CellContentClick);
            // 
            // DtpRentalDate
            // 
            this.DtpRentalDate.Location = new System.Drawing.Point(126, 212);
            this.DtpRentalDate.Name = "DtpRentalDate";
            this.DtpRentalDate.Size = new System.Drawing.Size(195, 25);
            this.DtpRentalDate.TabIndex = 4;
            this.DtpRentalDate.ValueChanged += new System.EventHandler(this.DtpRentalDate_ValueChanged);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(288, 319);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 31);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(207, 319);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 31);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(126, 319);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 31);
            this.BtnNew.TabIndex = 8;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(45, 319);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 31);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtIdx
            // 
            this.TxtIdx.Location = new System.Drawing.Point(126, 85);
            this.TxtIdx.MaxLength = 1;
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.Size = new System.Drawing.Size(195, 25);
            this.TxtIdx.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "대여회원";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "대여일";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "대여번호";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DtpReturnDate
            // 
            this.DtpReturnDate.Location = new System.Drawing.Point(126, 243);
            this.DtpReturnDate.Name = "DtpReturnDate";
            this.DtpReturnDate.Size = new System.Drawing.Size(195, 25);
            this.DtpReturnDate.TabIndex = 4;
            this.DtpReturnDate.ValueChanged += new System.EventHandler(this.DtpReturnDate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "반환일";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // CboName
            // 
            this.CboName.FormattingEnabled = true;
            this.CboName.Location = new System.Drawing.Point(126, 116);
            this.CboName.Name = "CboName";
            this.CboName.Size = new System.Drawing.Size(195, 23);
            this.CboName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "대여 책 제목";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CboBook
            // 
            this.CboBook.FormattingEnabled = true;
            this.CboBook.Location = new System.Drawing.Point(126, 152);
            this.CboBook.Name = "CboBook";
            this.CboBook.Size = new System.Drawing.Size(195, 23);
            this.CboBook.TabIndex = 13;
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 502);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RentalForm";
            this.Text = "BooksForm";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.MemberForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdBooksTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView GrdBooksTbl;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtIdx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpRentalDate;
        private System.Windows.Forms.DateTimePicker DtpReturnDate;
        private System.Windows.Forms.ComboBox CboName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboBook;
    }
}