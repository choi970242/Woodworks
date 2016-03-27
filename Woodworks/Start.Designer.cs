namespace Woodworks
{
    partial class Start
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
            this.usrTextbx = new System.Windows.Forms.TextBox();
            this.pswdTextbx = new System.Windows.Forms.TextBox();
            this.usrLbl = new System.Windows.Forms.Label();
            this.pswdLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usrTextbx
            // 
            this.usrTextbx.Location = new System.Drawing.Point(124, 96);
            this.usrTextbx.Name = "usrTextbx";
            this.usrTextbx.Size = new System.Drawing.Size(213, 20);
            this.usrTextbx.TabIndex = 0;
            // 
            // pswdTextbx
            // 
            this.pswdTextbx.Location = new System.Drawing.Point(124, 135);
            this.pswdTextbx.Name = "pswdTextbx";
            this.pswdTextbx.PasswordChar = '*';
            this.pswdTextbx.Size = new System.Drawing.Size(213, 20);
            this.pswdTextbx.TabIndex = 1;
            // 
            // usrLbl
            // 
            this.usrLbl.AutoSize = true;
            this.usrLbl.Location = new System.Drawing.Point(57, 99);
            this.usrLbl.Name = "usrLbl";
            this.usrLbl.Size = new System.Drawing.Size(61, 13);
            this.usrLbl.TabIndex = 2;
            this.usrLbl.Text = "Username :";
            // 
            // pswdLbl
            // 
            this.pswdLbl.AutoSize = true;
            this.pswdLbl.Location = new System.Drawing.Point(59, 142);
            this.pswdLbl.Name = "pswdLbl";
            this.pswdLbl.Size = new System.Drawing.Size(59, 13);
            this.pswdLbl.TabIndex = 3;
            this.pswdLbl.Text = "Password :";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(146, 216);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Woodworks";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pswdLbl);
            this.Controls.Add(this.usrLbl);
            this.Controls.Add(this.pswdTextbx);
            this.Controls.Add(this.usrTextbx);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Woodworks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usrTextbx;
        private System.Windows.Forms.TextBox pswdTextbx;
        private System.Windows.Forms.Label usrLbl;
        private System.Windows.Forms.Label pswdLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label1;
    }
}

