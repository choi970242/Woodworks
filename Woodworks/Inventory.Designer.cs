
namespace Woodworks
{
    partial class Inventory
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
            this.woodDGV = new System.Windows.Forms.DataGridView();
            this.addWoodBtn = new System.Windows.Forms.Button();
            this.editWoodBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.woodDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // woodDGV
            // 
            this.woodDGV.AllowUserToAddRows = false;
            this.woodDGV.AllowUserToDeleteRows = false;
            this.woodDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.woodDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.woodDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.woodDGV.Location = new System.Drawing.Point(4, 4);
            this.woodDGV.MultiSelect = false;
            this.woodDGV.Name = "woodDGV";
            this.woodDGV.ReadOnly = true;
            this.woodDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.woodDGV.Size = new System.Drawing.Size(438, 408);
            this.woodDGV.TabIndex = 0;
            // 
            // addWoodBtn
            // 
            this.addWoodBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addWoodBtn.Location = new System.Drawing.Point(449, 4);
            this.addWoodBtn.Name = "addWoodBtn";
            this.addWoodBtn.Size = new System.Drawing.Size(198, 23);
            this.addWoodBtn.TabIndex = 1;
            this.addWoodBtn.Text = "Add New Wood";
            this.addWoodBtn.UseVisualStyleBackColor = true;
            this.addWoodBtn.Click += new System.EventHandler(this.addWoodBtn_Click);
            // 
            // editWoodBtn
            // 
            this.editWoodBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editWoodBtn.Location = new System.Drawing.Point(449, 34);
            this.editWoodBtn.Name = "editWoodBtn";
            this.editWoodBtn.Size = new System.Drawing.Size(198, 23);
            this.editWoodBtn.TabIndex = 2;
            this.editWoodBtn.Text = "Edit Existing Wood";
            this.editWoodBtn.UseVisualStyleBackColor = true;
            this.editWoodBtn.Click += new System.EventHandler(this.editWoodBtn_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.editWoodBtn);
            this.Controls.Add(this.addWoodBtn);
            this.Controls.Add(this.woodDGV);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(650, 415);
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.woodDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView woodDGV;
        public System.Windows.Forms.Button addWoodBtn;
        public System.Windows.Forms.Button editWoodBtn;
    }
}
