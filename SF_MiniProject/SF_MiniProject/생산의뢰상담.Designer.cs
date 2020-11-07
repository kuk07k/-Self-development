namespace SF_MiniProject
{
    partial class 생산의뢰상담
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.주문날짜 = new System.Windows.Forms.Label();
            this.OrderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.생산의뢰 = new System.Windows.Forms.Button();
            this.희망납기일 = new System.Windows.Forms.Label();
            this.DeadLineTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CboNumber = new System.Windows.Forms.ComboBox();
            this.CboLocation = new System.Windows.Forms.ComboBox();
            this.배송지 = new System.Windows.Forms.Label();
            this.UnitPrice = new System.Windows.Forms.TextBox();
            this.공장매칭 = new System.Windows.Forms.Button();
            this.CboFacLocation = new System.Windows.Forms.ComboBox();
            this.생산지 = new System.Windows.Forms.Label();
            this.CboSize = new System.Windows.Forms.ComboBox();
            this.예상단가 = new System.Windows.Forms.Label();
            this.생산수량 = new System.Windows.Forms.Label();
            this.CboFabric = new System.Windows.Forms.ComboBox();
            this.CboDivision = new System.Windows.Forms.ComboBox();
            this.사이즈 = new System.Windows.Forms.Label();
            this.재질 = new System.Windows.Forms.Label();
            this.구분 = new System.Windows.Forms.Label();
            this.GridView = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.주문날짜);
            this.splitContainer1.Panel1.Controls.Add(this.OrderDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.생산의뢰);
            this.splitContainer1.Panel1.Controls.Add(this.희망납기일);
            this.splitContainer1.Panel1.Controls.Add(this.DeadLineTimePicker);
            this.splitContainer1.Panel1.Controls.Add(this.CboNumber);
            this.splitContainer1.Panel1.Controls.Add(this.CboLocation);
            this.splitContainer1.Panel1.Controls.Add(this.배송지);
            this.splitContainer1.Panel1.Controls.Add(this.UnitPrice);
            this.splitContainer1.Panel1.Controls.Add(this.공장매칭);
            this.splitContainer1.Panel1.Controls.Add(this.CboFacLocation);
            this.splitContainer1.Panel1.Controls.Add(this.생산지);
            this.splitContainer1.Panel1.Controls.Add(this.CboSize);
            this.splitContainer1.Panel1.Controls.Add(this.예상단가);
            this.splitContainer1.Panel1.Controls.Add(this.생산수량);
            this.splitContainer1.Panel1.Controls.Add(this.CboFabric);
            this.splitContainer1.Panel1.Controls.Add(this.CboDivision);
            this.splitContainer1.Panel1.Controls.Add(this.사이즈);
            this.splitContainer1.Panel1.Controls.Add(this.재질);
            this.splitContainer1.Panel1.Controls.Add(this.구분);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridView);
            this.splitContainer1.Size = new System.Drawing.Size(1194, 598);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;
            // 
            // 주문날짜
            // 
            this.주문날짜.AutoSize = true;
            this.주문날짜.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.주문날짜.Location = new System.Drawing.Point(11, 339);
            this.주문날짜.Name = "주문날짜";
            this.주문날짜.Size = new System.Drawing.Size(65, 19);
            this.주문날짜.TabIndex = 6;
            this.주문날짜.Text = "주문날짜";
            // 
            // OrderDateTimePicker
            // 
            this.OrderDateTimePicker.Location = new System.Drawing.Point(14, 357);
            this.OrderDateTimePicker.Name = "OrderDateTimePicker";
            this.OrderDateTimePicker.Size = new System.Drawing.Size(206, 25);
            this.OrderDateTimePicker.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(160, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "* 필수항목";
            // 
            // 생산의뢰
            // 
            this.생산의뢰.BackColor = System.Drawing.Color.RoyalBlue;
            this.생산의뢰.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.생산의뢰.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.생산의뢰.ForeColor = System.Drawing.Color.White;
            this.생산의뢰.Location = new System.Drawing.Point(14, 546);
            this.생산의뢰.Name = "생산의뢰";
            this.생산의뢰.Size = new System.Drawing.Size(206, 44);
            this.생산의뢰.TabIndex = 10;
            this.생산의뢰.Text = "생산 의뢰";
            this.생산의뢰.UseVisualStyleBackColor = false;
            this.생산의뢰.Click += new System.EventHandler(this.생산의뢰_Click);
            // 
            // 희망납기일
            // 
            this.희망납기일.AutoSize = true;
            this.희망납기일.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.희망납기일.Location = new System.Drawing.Point(11, 385);
            this.희망납기일.Name = "희망납기일";
            this.희망납기일.Size = new System.Drawing.Size(79, 19);
            this.희망납기일.TabIndex = 7;
            this.희망납기일.Text = "예상납기일";
            // 
            // DeadLineTimePicker
            // 
            this.DeadLineTimePicker.Location = new System.Drawing.Point(14, 403);
            this.DeadLineTimePicker.Name = "DeadLineTimePicker";
            this.DeadLineTimePicker.Size = new System.Drawing.Size(206, 25);
            this.DeadLineTimePicker.TabIndex = 7;
            // 
            // CboNumber
            // 
            this.CboNumber.FormattingEnabled = true;
            this.CboNumber.Items.AddRange(new object[] {
            "50",
            "100",
            "150",
            "200",
            "250",
            "300"});
            this.CboNumber.Location = new System.Drawing.Point(14, 207);
            this.CboNumber.Name = "CboNumber";
            this.CboNumber.Size = new System.Drawing.Size(206, 23);
            this.CboNumber.TabIndex = 3;
            // 
            // CboLocation
            // 
            this.CboLocation.FormattingEnabled = true;
            this.CboLocation.Items.AddRange(new object[] {
            "서울",
            "부산",
            "대구"});
            this.CboLocation.Location = new System.Drawing.Point(14, 304);
            this.CboLocation.Name = "CboLocation";
            this.CboLocation.Size = new System.Drawing.Size(206, 23);
            this.CboLocation.TabIndex = 5;
            // 
            // 배송지
            // 
            this.배송지.AutoSize = true;
            this.배송지.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.배송지.Location = new System.Drawing.Point(11, 286);
            this.배송지.Name = "배송지";
            this.배송지.Size = new System.Drawing.Size(65, 19);
            this.배송지.TabIndex = 5;
            this.배송지.Text = "집주소(*)";
            // 
            // UnitPrice
            // 
            this.UnitPrice.Location = new System.Drawing.Point(14, 457);
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(206, 25);
            this.UnitPrice.TabIndex = 8;
            // 
            // 공장매칭
            // 
            this.공장매칭.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.공장매칭.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.공장매칭.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.공장매칭.ForeColor = System.Drawing.Color.White;
            this.공장매칭.Location = new System.Drawing.Point(14, 496);
            this.공장매칭.Name = "공장매칭";
            this.공장매칭.Size = new System.Drawing.Size(206, 44);
            this.공장매칭.TabIndex = 9;
            this.공장매칭.Text = "공장 매칭";
            this.공장매칭.UseVisualStyleBackColor = false;
            this.공장매칭.Click += new System.EventHandler(this.공장매칭_Click);
            // 
            // CboFacLocation
            // 
            this.CboFacLocation.FormattingEnabled = true;
            this.CboFacLocation.Items.AddRange(new object[] {
            "서울",
            "부산",
            "대구"});
            this.CboFacLocation.Location = new System.Drawing.Point(14, 255);
            this.CboFacLocation.Name = "CboFacLocation";
            this.CboFacLocation.Size = new System.Drawing.Size(206, 23);
            this.CboFacLocation.TabIndex = 4;
            // 
            // 생산지
            // 
            this.생산지.AutoSize = true;
            this.생산지.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.생산지.Location = new System.Drawing.Point(11, 237);
            this.생산지.Name = "생산지";
            this.생산지.Size = new System.Drawing.Size(79, 19);
            this.생산지.TabIndex = 4;
            this.생산지.Text = "공장주소(*)";
            // 
            // CboSize
            // 
            this.CboSize.FormattingEnabled = true;
            this.CboSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.CboSize.Location = new System.Drawing.Point(14, 59);
            this.CboSize.Name = "CboSize";
            this.CboSize.Size = new System.Drawing.Size(206, 23);
            this.CboSize.TabIndex = 0;
            // 
            // 예상단가
            // 
            this.예상단가.AutoSize = true;
            this.예상단가.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.예상단가.Location = new System.Drawing.Point(11, 439);
            this.예상단가.Name = "예상단가";
            this.예상단가.Size = new System.Drawing.Size(65, 19);
            this.예상단가.TabIndex = 8;
            this.예상단가.Text = "예상단가";
            // 
            // 생산수량
            // 
            this.생산수량.AutoSize = true;
            this.생산수량.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.생산수량.Location = new System.Drawing.Point(11, 189);
            this.생산수량.Name = "생산수량";
            this.생산수량.Size = new System.Drawing.Size(79, 19);
            this.생산수량.TabIndex = 3;
            this.생산수량.Text = "생산수량(*)";
            // 
            // CboFabric
            // 
            this.CboFabric.FormattingEnabled = true;
            this.CboFabric.Items.AddRange(new object[] {
            "면",
            "린넨",
            "데님"});
            this.CboFabric.Location = new System.Drawing.Point(14, 110);
            this.CboFabric.Name = "CboFabric";
            this.CboFabric.Size = new System.Drawing.Size(206, 23);
            this.CboFabric.TabIndex = 1;
            // 
            // CboDivision
            // 
            this.CboDivision.FormattingEnabled = true;
            this.CboDivision.Items.AddRange(new object[] {
            "상의",
            "하의",
            "자켓"});
            this.CboDivision.Location = new System.Drawing.Point(14, 160);
            this.CboDivision.Name = "CboDivision";
            this.CboDivision.Size = new System.Drawing.Size(206, 23);
            this.CboDivision.TabIndex = 2;
            // 
            // 사이즈
            // 
            this.사이즈.AutoSize = true;
            this.사이즈.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.사이즈.Location = new System.Drawing.Point(11, 41);
            this.사이즈.Name = "사이즈";
            this.사이즈.Size = new System.Drawing.Size(65, 19);
            this.사이즈.TabIndex = 0;
            this.사이즈.Text = "사이즈(*)";
            // 
            // 재질
            // 
            this.재질.AutoSize = true;
            this.재질.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.재질.Location = new System.Drawing.Point(11, 92);
            this.재질.Name = "재질";
            this.재질.Size = new System.Drawing.Size(51, 19);
            this.재질.TabIndex = 1;
            this.재질.Text = "재질(*)";
            // 
            // 구분
            // 
            this.구분.AutoSize = true;
            this.구분.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.구분.Location = new System.Drawing.Point(11, 142);
            this.구분.Name = "구분";
            this.구분.Size = new System.Drawing.Size(51, 19);
            this.구분.TabIndex = 2;
            this.구분.Text = "구분(*)";
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridView.Location = new System.Drawing.Point(0, 0);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridView.RowHeadersWidth = 51;
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridView.RowTemplate.Height = 27;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(940, 598);
            this.GridView.TabIndex = 1;
            this.GridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellDoubleClick);
            // 
            // 생산의뢰상담
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1234, 678);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(1234, 678);
            this.MinimumSize = new System.Drawing.Size(1234, 678);
            this.Name = "생산의뢰상담";
            this.Text = "생산의뢰상담";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label 희망납기일;
        private System.Windows.Forms.DateTimePicker DeadLineTimePicker;
        private System.Windows.Forms.ComboBox CboNumber;
        private System.Windows.Forms.ComboBox CboLocation;
        private System.Windows.Forms.Label 배송지;
        private System.Windows.Forms.TextBox UnitPrice;
        private System.Windows.Forms.Button 공장매칭;
        private System.Windows.Forms.ComboBox CboFacLocation;
        private System.Windows.Forms.Label 생산지;
        private System.Windows.Forms.ComboBox CboSize;
        private System.Windows.Forms.Label 예상단가;
        private System.Windows.Forms.Label 생산수량;
        private System.Windows.Forms.ComboBox CboFabric;
        private System.Windows.Forms.ComboBox CboDivision;
        private System.Windows.Forms.Label 사이즈;
        private System.Windows.Forms.Label 재질;
        private System.Windows.Forms.Label 구분;
        private MetroFramework.Controls.MetroGrid GridView;
        private System.Windows.Forms.Button 생산의뢰;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label 주문날짜;
        private System.Windows.Forms.DateTimePicker OrderDateTimePicker;
    }
}