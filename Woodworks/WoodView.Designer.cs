namespace Woodworks
{
    partial class WoodView
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
            this.wdTypeTxtBx = new System.Windows.Forms.TextBox();
            this.wdLngthTxtBx = new System.Windows.Forms.TextBox();
            this.wdWidthTxtBx = new System.Windows.Forms.TextBox();
            this.wdThcknssTxtBx = new System.Windows.Forms.TextBox();
            this.wdPrceTxtBx = new System.Windows.Forms.TextBox();
            this.wdTypeLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cnfrmBtn = new System.Windows.Forms.Button();
            this.cnclBtn = new System.Windows.Forms.Button();
            this.dscLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wdTypeTxtBx
            // 
            this.wdTypeTxtBx.Location = new System.Drawing.Point(107, 41);
            this.wdTypeTxtBx.Name = "wdTypeTxtBx";
            this.wdTypeTxtBx.Size = new System.Drawing.Size(138, 20);
            this.wdTypeTxtBx.TabIndex = 0;
            // 
            // wdLngthTxtBx
            // 
            this.wdLngthTxtBx.Location = new System.Drawing.Point(107, 119);
            this.wdLngthTxtBx.Name = "wdLngthTxtBx";
            this.wdLngthTxtBx.Size = new System.Drawing.Size(138, 20);
            this.wdLngthTxtBx.TabIndex = 3;
            // 
            // wdWidthTxtBx
            // 
            this.wdWidthTxtBx.Location = new System.Drawing.Point(107, 93);
            this.wdWidthTxtBx.Name = "wdWidthTxtBx";
            this.wdWidthTxtBx.Size = new System.Drawing.Size(138, 20);
            this.wdWidthTxtBx.TabIndex = 2;
            // 
            // wdThcknssTxtBx
            // 
            this.wdThcknssTxtBx.Location = new System.Drawing.Point(107, 67);
            this.wdThcknssTxtBx.Name = "wdThcknssTxtBx";
            this.wdThcknssTxtBx.Size = new System.Drawing.Size(138, 20);
            this.wdThcknssTxtBx.TabIndex = 1;
            // 
            // wdPrceTxtBx
            // 
            this.wdPrceTxtBx.Location = new System.Drawing.Point(107, 145);
            this.wdPrceTxtBx.Name = "wdPrceTxtBx";
            this.wdPrceTxtBx.Size = new System.Drawing.Size(138, 20);
            this.wdPrceTxtBx.TabIndex = 5;
            // 
            // wdTypeLbl
            // 
            this.wdTypeLbl.AutoSize = true;
            this.wdTypeLbl.Location = new System.Drawing.Point(50, 44);
            this.wdTypeLbl.Name = "wdTypeLbl";
            this.wdTypeLbl.Size = new System.Drawing.Size(37, 13);
            this.wdTypeLbl.TabIndex = 6;
            this.wdTypeLbl.Text = "Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Length :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Width :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thickness :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price :";
            // 
            // cnfrmBtn
            // 
            this.cnfrmBtn.Location = new System.Drawing.Point(44, 186);
            this.cnfrmBtn.Name = "cnfrmBtn";
            this.cnfrmBtn.Size = new System.Drawing.Size(75, 23);
            this.cnfrmBtn.TabIndex = 12;
            this.cnfrmBtn.UseVisualStyleBackColor = true;
            this.cnfrmBtn.Click += new System.EventHandler(this.cnfrmBtn_Click);
            // 
            // cnclBtn
            // 
            this.cnclBtn.Location = new System.Drawing.Point(152, 186);
            this.cnclBtn.Name = "cnclBtn";
            this.cnclBtn.Size = new System.Drawing.Size(75, 23);
            this.cnclBtn.TabIndex = 13;
            this.cnclBtn.Text = "Cancel";
            this.cnclBtn.UseVisualStyleBackColor = true;
            this.cnclBtn.Click += new System.EventHandler(this.cnclBtn_Click);
            // 
            // dscLbl
            // 
            this.dscLbl.AutoSize = true;
            this.dscLbl.Location = new System.Drawing.Point(12, 9);
            this.dscLbl.Name = "dscLbl";
            this.dscLbl.Size = new System.Drawing.Size(97, 13);
            this.dscLbl.TabIndex = 12;
            this.dscLbl.Text = "Wood Information :";
            // 
            // WoodView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 240);
            this.Controls.Add(this.dscLbl);
            this.Controls.Add(this.cnclBtn);
            this.Controls.Add(this.cnfrmBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wdTypeLbl);
            this.Controls.Add(this.wdPrceTxtBx);
            this.Controls.Add(this.wdThcknssTxtBx);
            this.Controls.Add(this.wdWidthTxtBx);
            this.Controls.Add(this.wdLngthTxtBx);
            this.Controls.Add(this.wdTypeTxtBx);
            this.Name = "WoodView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wdTypeTxtBx;
        private System.Windows.Forms.TextBox wdLngthTxtBx;
        private System.Windows.Forms.TextBox wdWidthTxtBx;
        private System.Windows.Forms.TextBox wdThcknssTxtBx;
        private System.Windows.Forms.TextBox wdPrceTxtBx;
        private System.Windows.Forms.Label wdTypeLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cnfrmBtn;
        private System.Windows.Forms.Button cnclBtn;
        private System.Windows.Forms.Label dscLbl;
    }
}