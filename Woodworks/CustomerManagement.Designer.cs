namespace Woodworks
{
    partial class CustomerManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerDGV = new System.Windows.Forms.DataGridView();
            this.addCustBtn = new System.Windows.Forms.Button();
            this.editCustBtn = new System.Windows.Forms.Button();
            this.delCustButton = new System.Windows.Forms.Button();
            this.transactionsDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerDGV
            // 
            this.customerDGV.AllowUserToAddRows = false;
            this.customerDGV.AllowUserToDeleteRows = false;
            this.customerDGV.AllowUserToResizeRows = false;
            this.customerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDGV.Location = new System.Drawing.Point(4, 32);
            this.customerDGV.MultiSelect = false;
            this.customerDGV.Name = "customerDGV";
            this.customerDGV.ReadOnly = true;
            this.customerDGV.RowHeadersVisible = false;
            this.customerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDGV.Size = new System.Drawing.Size(604, 371);
            this.customerDGV.TabIndex = 0;
            this.customerDGV.SelectionChanged += new System.EventHandler(this.customerDGV_SelectionChanged);
            // 
            // addCustBtn
            // 
            this.addCustBtn.Location = new System.Drawing.Point(200, 3);
            this.addCustBtn.Name = "addCustBtn";
            this.addCustBtn.Size = new System.Drawing.Size(132, 23);
            this.addCustBtn.TabIndex = 1;
            this.addCustBtn.Text = "Add New Customer";
            this.addCustBtn.UseVisualStyleBackColor = true;
            this.addCustBtn.Click += new System.EventHandler(this.addCustBtn_Click);
            // 
            // editCustBtn
            // 
            this.editCustBtn.Location = new System.Drawing.Point(338, 3);
            this.editCustBtn.Name = "editCustBtn";
            this.editCustBtn.Size = new System.Drawing.Size(132, 23);
            this.editCustBtn.TabIndex = 2;
            this.editCustBtn.Text = "Edit Existing Customer";
            this.editCustBtn.UseVisualStyleBackColor = true;
            this.editCustBtn.Click += new System.EventHandler(this.editCustBtn_Click);
            // 
            // delCustButton
            // 
            this.delCustButton.Location = new System.Drawing.Point(476, 3);
            this.delCustButton.Name = "delCustButton";
            this.delCustButton.Size = new System.Drawing.Size(132, 23);
            this.delCustButton.TabIndex = 3;
            this.delCustButton.Text = "Delete Existing Customer";
            this.delCustButton.UseVisualStyleBackColor = true;
            this.delCustButton.Click += new System.EventHandler(this.delCustButton_Click);
            // 
            // transactionsDGV
            // 
            this.transactionsDGV.AllowUserToAddRows = false;
            this.transactionsDGV.AllowUserToDeleteRows = false;
            this.transactionsDGV.AllowUserToResizeRows = false;
            this.transactionsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsDGV.Location = new System.Drawing.Point(6, 29);
            this.transactionsDGV.MultiSelect = false;
            this.transactionsDGV.Name = "transactionsDGV";
            this.transactionsDGV.ReadOnly = true;
            this.transactionsDGV.RowHeadersVisible = false;
            this.transactionsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionsDGV.Size = new System.Drawing.Size(363, 548);
            this.transactionsDGV.TabIndex = 4;
            this.transactionsDGV.SelectionChanged += new System.EventHandler(this.transactionsDGV_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.transactionsDGV);
            this.groupBox1.Location = new System.Drawing.Point(614, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 618);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recent Transactions :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.delCustButton);
            this.Controls.Add(this.editCustBtn);
            this.Controls.Add(this.addCustBtn);
            this.Controls.Add(this.customerDGV);
            this.Name = "CustomerManagement";
            this.Size = new System.Drawing.Size(992, 624);
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDGV;
        private System.Windows.Forms.Button addCustBtn;
        private System.Windows.Forms.Button editCustBtn;
        private System.Windows.Forms.Button delCustButton;
        private System.Windows.Forms.DataGridView transactionsDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}
