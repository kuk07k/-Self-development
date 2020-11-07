namespace SF_MiniProject
{
    partial class 생산의뢰서
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.내용확인 = new System.Windows.Forms.Label();
            this.매칭취소 = new System.Windows.Forms.Button();
            this.매칭확정 = new System.Windows.Forms.Button();
            this.DeadLine = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.CboFacLocation = new System.Windows.Forms.TextBox();
            this.OrderDate = new System.Windows.Forms.TextBox();
            this.CboName = new System.Windows.Forms.TextBox();
            this.CboSize = new System.Windows.Forms.TextBox();
            this.CboFabric = new System.Windows.Forms.TextBox();
            this.CboDivision = new System.Windows.Forms.TextBox();
            this.예상납기일 = new System.Windows.Forms.Label();
            this.단가 = new System.Windows.Forms.Label();
            this.생산지 = new System.Windows.Forms.Label();
            this.주문날짜 = new System.Windows.Forms.Label();
            this.공장이름 = new System.Windows.Forms.Label();
            this.재질 = new System.Windows.Forms.Label();
            this.구분 = new System.Windows.Forms.Label();
            this.사이즈 = new System.Windows.Forms.Label();
            this.GridView2 = new MetroFramework.Controls.MetroGrid();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.파일첨부 = new System.Windows.Forms.Label();
            this.첨부 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(23, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.첨부);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.파일첨부);
            this.splitContainer1.Panel1.Controls.Add(this.내용확인);
            this.splitContainer1.Panel1.Controls.Add(this.매칭취소);
            this.splitContainer1.Panel1.Controls.Add(this.매칭확정);
            this.splitContainer1.Panel1.Controls.Add(this.DeadLine);
            this.splitContainer1.Panel1.Controls.Add(this.Price);
            this.splitContainer1.Panel1.Controls.Add(this.CboFacLocation);
            this.splitContainer1.Panel1.Controls.Add(this.OrderDate);
            this.splitContainer1.Panel1.Controls.Add(this.CboName);
            this.splitContainer1.Panel1.Controls.Add(this.CboSize);
            this.splitContainer1.Panel1.Controls.Add(this.CboFabric);
            this.splitContainer1.Panel1.Controls.Add(this.CboDivision);
            this.splitContainer1.Panel1.Controls.Add(this.예상납기일);
            this.splitContainer1.Panel1.Controls.Add(this.단가);
            this.splitContainer1.Panel1.Controls.Add(this.생산지);
            this.splitContainer1.Panel1.Controls.Add(this.주문날짜);
            this.splitContainer1.Panel1.Controls.Add(this.공장이름);
            this.splitContainer1.Panel1.Controls.Add(this.재질);
            this.splitContainer1.Panel1.Controls.Add(this.구분);
            this.splitContainer1.Panel1.Controls.Add(this.사이즈);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridView2);
            this.splitContainer1.Size = new System.Drawing.Size(929, 538);
            this.splitContainer1.SplitterDistance = 269;
            this.splitContainer1.TabIndex = 0;
            // 
            // 내용확인
            // 
            this.내용확인.AutoSize = true;
            this.내용확인.Font = new System.Drawing.Font("맑은 고딕 Semilight", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.내용확인.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.내용확인.Location = new System.Drawing.Point(18, 9);
            this.내용확인.Name = "내용확인";
            this.내용확인.Size = new System.Drawing.Size(251, 19);
            this.내용확인.TabIndex = 10;
            this.내용확인.Text = "* 의뢰내용을 확인하시고 선택해주세요\r\n";
            // 
            // 매칭취소
            // 
            this.매칭취소.BackColor = System.Drawing.Color.RoyalBlue;
            this.매칭취소.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.매칭취소.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.매칭취소.ForeColor = System.Drawing.Color.White;
            this.매칭취소.Location = new System.Drawing.Point(22, 500);
            this.매칭취소.Name = "매칭취소";
            this.매칭취소.Size = new System.Drawing.Size(192, 38);
            this.매칭취소.TabIndex = 9;
            this.매칭취소.Text = "매칭 취소";
            this.매칭취소.UseVisualStyleBackColor = false;
            this.매칭취소.Click += new System.EventHandler(this.매칭제거_Click);
            // 
            // 매칭확정
            // 
            this.매칭확정.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.매칭확정.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.매칭확정.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.매칭확정.ForeColor = System.Drawing.Color.White;
            this.매칭확정.Location = new System.Drawing.Point(22, 456);
            this.매칭확정.Name = "매칭확정";
            this.매칭확정.Size = new System.Drawing.Size(192, 38);
            this.매칭확정.TabIndex = 8;
            this.매칭확정.Text = "매칭 확정";
            this.매칭확정.UseVisualStyleBackColor = false;
            this.매칭확정.Click += new System.EventHandler(this.매칭확정_Click);
            // 
            // DeadLine
            // 
            this.DeadLine.Location = new System.Drawing.Point(22, 376);
            this.DeadLine.Name = "DeadLine";
            this.DeadLine.ReadOnly = true;
            this.DeadLine.Size = new System.Drawing.Size(192, 25);
            this.DeadLine.TabIndex = 7;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(22, 284);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(192, 25);
            this.Price.TabIndex = 5;
            // 
            // CboFacLocation
            // 
            this.CboFacLocation.Location = new System.Drawing.Point(22, 100);
            this.CboFacLocation.Name = "CboFacLocation";
            this.CboFacLocation.ReadOnly = true;
            this.CboFacLocation.Size = new System.Drawing.Size(192, 25);
            this.CboFacLocation.TabIndex = 1;
            // 
            // OrderDate
            // 
            this.OrderDate.Location = new System.Drawing.Point(22, 330);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Size = new System.Drawing.Size(192, 25);
            this.OrderDate.TabIndex = 6;
            // 
            // CboName
            // 
            this.CboName.Location = new System.Drawing.Point(22, 54);
            this.CboName.Name = "CboName";
            this.CboName.ReadOnly = true;
            this.CboName.Size = new System.Drawing.Size(192, 25);
            this.CboName.TabIndex = 0;
            // 
            // CboSize
            // 
            this.CboSize.Location = new System.Drawing.Point(22, 146);
            this.CboSize.Name = "CboSize";
            this.CboSize.ReadOnly = true;
            this.CboSize.Size = new System.Drawing.Size(192, 25);
            this.CboSize.TabIndex = 2;
            // 
            // CboFabric
            // 
            this.CboFabric.Location = new System.Drawing.Point(22, 192);
            this.CboFabric.Name = "CboFabric";
            this.CboFabric.ReadOnly = true;
            this.CboFabric.Size = new System.Drawing.Size(192, 25);
            this.CboFabric.TabIndex = 3;
            // 
            // CboDivision
            // 
            this.CboDivision.Location = new System.Drawing.Point(22, 238);
            this.CboDivision.Name = "CboDivision";
            this.CboDivision.ReadOnly = true;
            this.CboDivision.Size = new System.Drawing.Size(192, 25);
            this.CboDivision.TabIndex = 4;
            // 
            // 예상납기일
            // 
            this.예상납기일.AutoSize = true;
            this.예상납기일.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.예상납기일.Location = new System.Drawing.Point(18, 358);
            this.예상납기일.Name = "예상납기일";
            this.예상납기일.Size = new System.Drawing.Size(79, 19);
            this.예상납기일.TabIndex = 6;
            this.예상납기일.Text = "예상납기일";
            this.예상납기일.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // 단가
            // 
            this.단가.AutoSize = true;
            this.단가.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.단가.Location = new System.Drawing.Point(18, 266);
            this.단가.Name = "단가";
            this.단가.Size = new System.Drawing.Size(37, 19);
            this.단가.TabIndex = 7;
            this.단가.Text = "단가";
            this.단가.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // 생산지
            // 
            this.생산지.AutoSize = true;
            this.생산지.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.생산지.Location = new System.Drawing.Point(18, 82);
            this.생산지.Name = "생산지";
            this.생산지.Size = new System.Drawing.Size(51, 19);
            this.생산지.TabIndex = 4;
            this.생산지.Text = "생산지";
            this.생산지.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // 주문날짜
            // 
            this.주문날짜.AutoSize = true;
            this.주문날짜.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.주문날짜.Location = new System.Drawing.Point(18, 312);
            this.주문날짜.Name = "주문날짜";
            this.주문날짜.Size = new System.Drawing.Size(65, 19);
            this.주문날짜.TabIndex = 5;
            this.주문날짜.Text = "주문날짜";
            this.주문날짜.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 공장이름
            // 
            this.공장이름.AutoSize = true;
            this.공장이름.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.공장이름.Location = new System.Drawing.Point(18, 36);
            this.공장이름.Name = "공장이름";
            this.공장이름.Size = new System.Drawing.Size(65, 19);
            this.공장이름.TabIndex = 3;
            this.공장이름.Text = "공장이름";
            this.공장이름.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 재질
            // 
            this.재질.AutoSize = true;
            this.재질.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.재질.Location = new System.Drawing.Point(18, 174);
            this.재질.Name = "재질";
            this.재질.Size = new System.Drawing.Size(37, 19);
            this.재질.TabIndex = 2;
            this.재질.Text = "재질";
            this.재질.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 구분
            // 
            this.구분.AutoSize = true;
            this.구분.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.구분.Location = new System.Drawing.Point(18, 220);
            this.구분.Name = "구분";
            this.구분.Size = new System.Drawing.Size(37, 19);
            this.구분.TabIndex = 1;
            this.구분.Text = "구분";
            this.구분.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 사이즈
            // 
            this.사이즈.AutoSize = true;
            this.사이즈.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.사이즈.Location = new System.Drawing.Point(18, 128);
            this.사이즈.Name = "사이즈";
            this.사이즈.Size = new System.Drawing.Size(51, 19);
            this.사이즈.TabIndex = 0;
            this.사이즈.Text = "사이즈";
            this.사이즈.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GridView2
            // 
            this.GridView2.AllowUserToAddRows = false;
            this.GridView2.AllowUserToDeleteRows = false;
            this.GridView2.AllowUserToResizeRows = false;
            this.GridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView2.EnableHeadersVisualStyles = false;
            this.GridView2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridView2.Location = new System.Drawing.Point(0, 0);
            this.GridView2.Name = "GridView2";
            this.GridView2.ReadOnly = true;
            this.GridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GridView2.RowHeadersWidth = 51;
            this.GridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridView2.RowTemplate.Height = 27;
            this.GridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView2.Size = new System.Drawing.Size(656, 538);
            this.GridView2.TabIndex = 0;
            this.GridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView2_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(144, 25);
            this.textBox1.TabIndex = 11;
            // 
            // 파일첨부
            // 
            this.파일첨부.AutoSize = true;
            this.파일첨부.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.파일첨부.Location = new System.Drawing.Point(18, 404);
            this.파일첨부.Name = "파일첨부";
            this.파일첨부.Size = new System.Drawing.Size(65, 19);
            this.파일첨부.TabIndex = 12;
            this.파일첨부.Text = "파일첨부";
            this.파일첨부.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // 첨부
            // 
            this.첨부.Location = new System.Drawing.Point(172, 422);
            this.첨부.Name = "첨부";
            this.첨부.Size = new System.Drawing.Size(42, 25);
            this.첨부.TabIndex = 13;
            this.첨부.Text = "...";
            this.첨부.UseSelectable = true;
            this.첨부.Click += new System.EventHandler(this.첨부_Click);
            // 
            // 생산의뢰서
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1089, 638);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(1089, 638);
            this.MinimumSize = new System.Drawing.Size(1089, 638);
            this.Name = "생산의뢰서";
            this.Text = "생산의뢰서";
            this.Load += new System.EventHandler(this.생산의뢰서_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label 단가;
        private System.Windows.Forms.Label 생산지;
        private System.Windows.Forms.Label 주문날짜;
        private System.Windows.Forms.Label 공장이름;
        private System.Windows.Forms.Label 재질;
        private System.Windows.Forms.Label 구분;
        private System.Windows.Forms.Label 사이즈;
        private System.Windows.Forms.Label 예상납기일;
        private System.Windows.Forms.TextBox DeadLine;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox CboFacLocation;
        private System.Windows.Forms.TextBox OrderDate;
        private System.Windows.Forms.TextBox CboName;
        private System.Windows.Forms.TextBox CboSize;
        private System.Windows.Forms.TextBox CboFabric;
        private System.Windows.Forms.TextBox CboDivision;
        private MetroFramework.Controls.MetroGrid GridView2;
        private System.Windows.Forms.Button 매칭취소;
        private System.Windows.Forms.Button 매칭확정;
        private System.Windows.Forms.Label 내용확인;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label 파일첨부;
        private MetroFramework.Controls.MetroButton 첨부;
    }
}