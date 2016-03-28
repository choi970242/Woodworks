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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addCustBtn = new System.Windows.Forms.Button();
            this.editCustBtn = new System.Windows.Forms.Button();
            this.delCustButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // addCustBtn
            // 
            this.addCustBtn.Location = new System.Drawing.Point(200, 3);
            this.addCustBtn.Name = "addCustBtn";
            this.addCustBtn.Size = new System.Drawing.Size(132, 23);
            this.addCustBtn.TabIndex = 1;
            this.addCustBtn.Text = "Add New Customer";
            this.addCustBtn.UseVisualStyleBackColor = true;
            // 
            // editCustBtn
            // 
            this.editCustBtn.Location = new System.Drawing.Point(338, 3);
            this.editCustBtn.Name = "editCustBtn";
            this.editCustBtn.Size = new System.Drawing.Size(132, 23);
            this.editCustBtn.TabIndex = 2;
            this.editCustBtn.Text = "Edit Existing Customer";
            this.editCustBtn.UseVisualStyleBackColor = true;
            // 
            // delCustButton
            // 
            this.delCustButton.Location = new System.Drawing.Point(476, 3);
            this.delCustButton.Name = "delCustButton";
            this.delCustButton.Size = new System.Drawing.Size(132, 23);
            this.delCustButton.TabIndex = 3;
            this.delCustButton.Text = "Delete Existing Customer";
            this.delCustButton.UseVisualStyleBackColor = true;
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delCustButton);
            this.Controls.Add(this.editCustBtn);
            this.Controls.Add(this.addCustBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerManagement";
            this.Size = new System.Drawing.Size(611, 406);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addCustBtn;
        private System.Windows.Forms.Button editCustBtn;
        private System.Windows.Forms.Button delCustButton;
    }
}
