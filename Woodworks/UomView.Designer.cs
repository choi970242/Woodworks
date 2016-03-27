namespace Woodworks
{
    partial class UomView
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
            this.uomCdTxtBx = new System.Windows.Forms.TextBox();
            this.uomDscTxtBx = new System.Windows.Forms.TextBox();
            this.uomLstBx = new System.Windows.Forms.ListBox();
            this.uomCdLbl = new System.Windows.Forms.Label();
            this.uomDscLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dltBtn = new System.Windows.Forms.Button();
            this.edtBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uomDscLbl1 = new System.Windows.Forms.Label();
            this.uomCdLbl1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.uomDscTxtBx1 = new System.Windows.Forms.TextBox();
            this.uomCdTxtBx1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uomCdTxtBx
            // 
            this.uomCdTxtBx.Location = new System.Drawing.Point(137, 45);
            this.uomCdTxtBx.Name = "uomCdTxtBx";
            this.uomCdTxtBx.Size = new System.Drawing.Size(137, 20);
            this.uomCdTxtBx.TabIndex = 1;
            // 
            // uomDscTxtBx
            // 
            this.uomDscTxtBx.Location = new System.Drawing.Point(137, 83);
            this.uomDscTxtBx.Name = "uomDscTxtBx";
            this.uomDscTxtBx.Size = new System.Drawing.Size(137, 20);
            this.uomDscTxtBx.TabIndex = 2;
            // 
            // uomLstBx
            // 
            this.uomLstBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uomLstBx.FormattingEnabled = true;
            this.uomLstBx.Location = new System.Drawing.Point(12, 12);
            this.uomLstBx.Name = "uomLstBx";
            this.uomLstBx.Size = new System.Drawing.Size(120, 433);
            this.uomLstBx.TabIndex = 3;
            this.uomLstBx.SelectedIndexChanged += new System.EventHandler(this.uomLstBx_SelectedIndexChanged);
            // 
            // uomCdLbl
            // 
            this.uomCdLbl.AutoSize = true;
            this.uomCdLbl.Location = new System.Drawing.Point(43, 48);
            this.uomCdLbl.Name = "uomCdLbl";
            this.uomCdLbl.Size = new System.Drawing.Size(66, 13);
            this.uomCdLbl.TabIndex = 4;
            this.uomCdLbl.Text = "UOM Code :";
            // 
            // uomDscLbl
            // 
            this.uomDscLbl.AutoSize = true;
            this.uomDscLbl.Location = new System.Drawing.Point(15, 86);
            this.uomDscLbl.Name = "uomDscLbl";
            this.uomDscLbl.Size = new System.Drawing.Size(94, 13);
            this.uomDscLbl.TabIndex = 5;
            this.uomDscLbl.Text = "UOM Description :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dltBtn);
            this.groupBox1.Controls.Add(this.edtBtn);
            this.groupBox1.Controls.Add(this.uomCdLbl);
            this.groupBox1.Controls.Add(this.uomDscLbl);
            this.groupBox1.Controls.Add(this.uomDscTxtBx);
            this.groupBox1.Controls.Add(this.uomCdTxtBx);
            this.groupBox1.Location = new System.Drawing.Point(138, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 212);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage UOM";
            // 
            // dltBtn
            // 
            this.dltBtn.Location = new System.Drawing.Point(173, 138);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(75, 23);
            this.dltBtn.TabIndex = 7;
            this.dltBtn.Text = "Delete";
            this.dltBtn.UseVisualStyleBackColor = true;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // edtBtn
            // 
            this.edtBtn.Location = new System.Drawing.Point(34, 139);
            this.edtBtn.Name = "edtBtn";
            this.edtBtn.Size = new System.Drawing.Size(75, 23);
            this.edtBtn.TabIndex = 6;
            this.edtBtn.Text = "Edit";
            this.edtBtn.UseVisualStyleBackColor = true;
            this.edtBtn.Click += new System.EventHandler(this.cnfrmBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uomDscLbl1);
            this.groupBox2.Controls.Add(this.uomCdLbl1);
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Controls.Add(this.uomDscTxtBx1);
            this.groupBox2.Controls.Add(this.uomCdTxtBx1);
            this.groupBox2.Location = new System.Drawing.Point(138, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 209);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New UOM";
            // 
            // uomDscLbl1
            // 
            this.uomDscLbl1.AutoSize = true;
            this.uomDscLbl1.Location = new System.Drawing.Point(15, 83);
            this.uomDscLbl1.Name = "uomDscLbl1";
            this.uomDscLbl1.Size = new System.Drawing.Size(94, 13);
            this.uomDscLbl1.TabIndex = 4;
            this.uomDscLbl1.Text = "UOM Description :";
            // 
            // uomCdLbl1
            // 
            this.uomCdLbl1.AutoSize = true;
            this.uomCdLbl1.Location = new System.Drawing.Point(43, 45);
            this.uomCdLbl1.Name = "uomCdLbl1";
            this.uomCdLbl1.Size = new System.Drawing.Size(66, 13);
            this.uomCdLbl1.TabIndex = 3;
            this.uomCdLbl1.Text = "UOM Code :";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(104, 136);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // uomDscTxtBx1
            // 
            this.uomDscTxtBx1.Location = new System.Drawing.Point(131, 80);
            this.uomDscTxtBx1.Name = "uomDscTxtBx1";
            this.uomDscTxtBx1.Size = new System.Drawing.Size(137, 20);
            this.uomDscTxtBx1.TabIndex = 1;
            // 
            // uomCdTxtBx1
            // 
            this.uomCdTxtBx1.Location = new System.Drawing.Point(132, 42);
            this.uomCdTxtBx1.Name = "uomCdTxtBx1";
            this.uomCdTxtBx1.Size = new System.Drawing.Size(136, 20);
            this.uomCdTxtBx1.TabIndex = 0;
            // 
            // UomView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uomLstBx);
            this.Name = "UomView";
            this.Text = "Unit Of Measure Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox uomCdTxtBx;
        private System.Windows.Forms.TextBox uomDscTxtBx;
        private System.Windows.Forms.ListBox uomLstBx;
        private System.Windows.Forms.Label uomCdLbl;
        private System.Windows.Forms.Label uomDscLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button edtBtn;
        private System.Windows.Forms.Button dltBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label uomDscLbl1;
        private System.Windows.Forms.Label uomCdLbl1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox uomDscTxtBx1;
        private System.Windows.Forms.TextBox uomCdTxtBx1;
    }
}