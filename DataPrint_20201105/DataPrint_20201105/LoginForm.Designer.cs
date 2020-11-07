namespace DataPrint_20201105
{
    partial class LoginForm
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
            this.ID_LB = new System.Windows.Forms.Label();
            this.PW_LB = new System.Windows.Forms.Label();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.PW_txt = new System.Windows.Forms.TextBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_CANCEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_LB
            // 
            this.ID_LB.AutoSize = true;
            this.ID_LB.Location = new System.Drawing.Point(149, 99);
            this.ID_LB.Name = "ID_LB";
            this.ID_LB.Size = new System.Drawing.Size(20, 15);
            this.ID_LB.TabIndex = 0;
            this.ID_LB.Text = "ID";
            this.ID_LB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PW_LB
            // 
            this.PW_LB.AutoSize = true;
            this.PW_LB.Location = new System.Drawing.Point(97, 149);
            this.PW_LB.Name = "PW_LB";
            this.PW_LB.Size = new System.Drawing.Size(72, 15);
            this.PW_LB.TabIndex = 2;
            this.PW_LB.Text = "Password";
            this.PW_LB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(186, 96);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(178, 25);
            this.ID_txt.TabIndex = 1;
            this.ID_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_txt_KeyPress);
            // 
            // PW_txt
            // 
            this.PW_txt.Location = new System.Drawing.Point(186, 146);
            this.PW_txt.Name = "PW_txt";
            this.PW_txt.PasswordChar = '*';
            this.PW_txt.Size = new System.Drawing.Size(178, 25);
            this.PW_txt.TabIndex = 3;
            this.PW_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PW_txt_KeyPress);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(126, 196);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(104, 36);
            this.Btn_OK.TabIndex = 4;
            this.Btn_OK.Text = "OK";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_CANCEL
            // 
            this.Btn_CANCEL.Location = new System.Drawing.Point(260, 196);
            this.Btn_CANCEL.Name = "Btn_CANCEL";
            this.Btn_CANCEL.Size = new System.Drawing.Size(104, 36);
            this.Btn_CANCEL.TabIndex = 5;
            this.Btn_CANCEL.Text = "Cancel";
            this.Btn_CANCEL.UseVisualStyleBackColor = true;
            this.Btn_CANCEL.Click += new System.EventHandler(this.Btn_CANCEL_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 267);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_CANCEL);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.PW_txt);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.PW_LB);
            this.Controls.Add(this.ID_LB);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_LB;
        private System.Windows.Forms.Label PW_LB;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.TextBox PW_txt;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_CANCEL;
    }
}