namespace Woodworks
{
    partial class TransactionManagement
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
            this.ordersDGV = new System.Windows.Forms.DataGridView();
            this.customerCmboBx = new System.Windows.Forms.ComboBox();
            this.cstmrNmLbl = new System.Windows.Forms.Label();
            this.cstmrAddrssTxtBx = new System.Windows.Forms.TextBox();
            this.cstmrAddrssLbl = new System.Windows.Forms.Label();
            this.cntctPrsnLbl = new System.Windows.Forms.Label();
            this.cntctNmbrLbl = new System.Windows.Forms.Label();
            this.cntctPrsnTxtBx = new System.Windows.Forms.TextBox();
            this.cntctNmbrTxtBx = new System.Windows.Forms.TextBox();
            this.transactionItemsGrpBx = new System.Windows.Forms.GroupBox();
            this.customerInfoGrpBx = new System.Windows.Forms.GroupBox();
            this.transactionIdLbl = new System.Windows.Forms.Label();
            this.transactionDtLbl = new System.Windows.Forms.Label();
            this.transactionIDTxtBx = new System.Windows.Forms.TextBox();
            this.transactionDateTxtBx = new System.Windows.Forms.TextBox();
            this.woodTypeLbl = new System.Windows.Forms.Label();
            this.woodLengthLbl = new System.Windows.Forms.Label();
            this.woodWidthLbl = new System.Windows.Forms.Label();
            this.woodThcknssLbl = new System.Windows.Forms.Label();
            this.woodGrpBx = new System.Windows.Forms.GroupBox();
            this.searchWoodLbl = new System.Windows.Forms.Label();
            this.searchWoodCmboBx = new System.Windows.Forms.ComboBox();
            this.woodTypeTxtBx = new System.Windows.Forms.TextBox();
            this.woodThcknssTxtBx = new System.Windows.Forms.TextBox();
            this.woodWidthTxtBx = new System.Windows.Forms.TextBox();
            this.woodLengthTxtBx = new System.Windows.Forms.TextBox();
            this.remWoodBtn = new System.Windows.Forms.Button();
            this.addWoodBtn = new System.Windows.Forms.Button();
            this.qtyTxtBx = new System.Windows.Forms.TextBox();
            this.qtyLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.totalTxtBx = new System.Windows.Forms.TextBox();
            this.addTransactionBtn = new System.Windows.Forms.Button();
            this.transactionSttsTxtBx = new System.Windows.Forms.TextBox();
            this.transactionStatusLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDGV)).BeginInit();
            this.transactionItemsGrpBx.SuspendLayout();
            this.customerInfoGrpBx.SuspendLayout();
            this.woodGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersDGV
            // 
            this.ordersDGV.AllowUserToAddRows = false;
            this.ordersDGV.AllowUserToDeleteRows = false;
            this.ordersDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDGV.Location = new System.Drawing.Point(6, 19);
            this.ordersDGV.Name = "ordersDGV";
            this.ordersDGV.ReadOnly = true;
            this.ordersDGV.RowHeadersVisible = false;
            this.ordersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDGV.Size = new System.Drawing.Size(568, 376);
            this.ordersDGV.TabIndex = 0;
            this.ordersDGV.SelectionChanged += new System.EventHandler(this.ordersDGV_SelectionChanged);
            // 
            // customerCmboBx
            // 
            this.customerCmboBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerCmboBx.AutoCompleteCustomSource.AddRange(new string[] {
            "aldrich",
            "ali",
            "corn",
            "bo"});
            this.customerCmboBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customerCmboBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.customerCmboBx.FormattingEnabled = true;
            this.customerCmboBx.Location = new System.Drawing.Point(84, 22);
            this.customerCmboBx.Name = "customerCmboBx";
            this.customerCmboBx.Size = new System.Drawing.Size(216, 21);
            this.customerCmboBx.TabIndex = 1;
            this.customerCmboBx.SelectedIndexChanged += new System.EventHandler(this.customerCmboBx_SelectedIndexChanged);
            // 
            // cstmrNmLbl
            // 
            this.cstmrNmLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cstmrNmLbl.AutoSize = true;
            this.cstmrNmLbl.Location = new System.Drawing.Point(21, 25);
            this.cstmrNmLbl.Name = "cstmrNmLbl";
            this.cstmrNmLbl.Size = new System.Drawing.Size(57, 13);
            this.cstmrNmLbl.TabIndex = 2;
            this.cstmrNmLbl.Text = "Customer :";
            // 
            // cstmrAddrssTxtBx
            // 
            this.cstmrAddrssTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cstmrAddrssTxtBx.Enabled = false;
            this.cstmrAddrssTxtBx.Location = new System.Drawing.Point(84, 56);
            this.cstmrAddrssTxtBx.Multiline = true;
            this.cstmrAddrssTxtBx.Name = "cstmrAddrssTxtBx";
            this.cstmrAddrssTxtBx.Size = new System.Drawing.Size(216, 36);
            this.cstmrAddrssTxtBx.TabIndex = 3;
            // 
            // cstmrAddrssLbl
            // 
            this.cstmrAddrssLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cstmrAddrssLbl.AutoSize = true;
            this.cstmrAddrssLbl.Location = new System.Drawing.Point(27, 59);
            this.cstmrAddrssLbl.Name = "cstmrAddrssLbl";
            this.cstmrAddrssLbl.Size = new System.Drawing.Size(51, 13);
            this.cstmrAddrssLbl.TabIndex = 4;
            this.cstmrAddrssLbl.Text = "Address :";
            // 
            // cntctPrsnLbl
            // 
            this.cntctPrsnLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cntctPrsnLbl.AutoSize = true;
            this.cntctPrsnLbl.Location = new System.Drawing.Point(310, 71);
            this.cntctPrsnLbl.Name = "cntctPrsnLbl";
            this.cntctPrsnLbl.Size = new System.Drawing.Size(86, 13);
            this.cntctPrsnLbl.TabIndex = 5;
            this.cntctPrsnLbl.Text = "Contact Person :";
            // 
            // cntctNmbrLbl
            // 
            this.cntctNmbrLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cntctNmbrLbl.AutoSize = true;
            this.cntctNmbrLbl.Location = new System.Drawing.Point(306, 25);
            this.cntctNmbrLbl.Name = "cntctNmbrLbl";
            this.cntctNmbrLbl.Size = new System.Drawing.Size(90, 13);
            this.cntctNmbrLbl.TabIndex = 6;
            this.cntctNmbrLbl.Text = "Contact Number :";
            // 
            // cntctPrsnTxtBx
            // 
            this.cntctPrsnTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cntctPrsnTxtBx.Enabled = false;
            this.cntctPrsnTxtBx.Location = new System.Drawing.Point(402, 68);
            this.cntctPrsnTxtBx.Name = "cntctPrsnTxtBx";
            this.cntctPrsnTxtBx.Size = new System.Drawing.Size(225, 20);
            this.cntctPrsnTxtBx.TabIndex = 7;
            // 
            // cntctNmbrTxtBx
            // 
            this.cntctNmbrTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cntctNmbrTxtBx.Enabled = false;
            this.cntctNmbrTxtBx.Location = new System.Drawing.Point(402, 22);
            this.cntctNmbrTxtBx.Name = "cntctNmbrTxtBx";
            this.cntctNmbrTxtBx.Size = new System.Drawing.Size(225, 20);
            this.cntctNmbrTxtBx.TabIndex = 8;
            // 
            // transactionItemsGrpBx
            // 
            this.transactionItemsGrpBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionItemsGrpBx.Controls.Add(this.ordersDGV);
            this.transactionItemsGrpBx.Location = new System.Drawing.Point(231, 127);
            this.transactionItemsGrpBx.Name = "transactionItemsGrpBx";
            this.transactionItemsGrpBx.Size = new System.Drawing.Size(580, 401);
            this.transactionItemsGrpBx.TabIndex = 9;
            this.transactionItemsGrpBx.TabStop = false;
            this.transactionItemsGrpBx.Text = "Items";
            // 
            // customerInfoGrpBx
            // 
            this.customerInfoGrpBx.Controls.Add(this.customerCmboBx);
            this.customerInfoGrpBx.Controls.Add(this.cstmrNmLbl);
            this.customerInfoGrpBx.Controls.Add(this.cntctPrsnLbl);
            this.customerInfoGrpBx.Controls.Add(this.cntctNmbrLbl);
            this.customerInfoGrpBx.Controls.Add(this.cntctPrsnTxtBx);
            this.customerInfoGrpBx.Controls.Add(this.cntctNmbrTxtBx);
            this.customerInfoGrpBx.Controls.Add(this.cstmrAddrssTxtBx);
            this.customerInfoGrpBx.Controls.Add(this.cstmrAddrssLbl);
            this.customerInfoGrpBx.Location = new System.Drawing.Point(9, 9);
            this.customerInfoGrpBx.Name = "customerInfoGrpBx";
            this.customerInfoGrpBx.Size = new System.Drawing.Size(633, 104);
            this.customerInfoGrpBx.TabIndex = 10;
            this.customerInfoGrpBx.TabStop = false;
            this.customerInfoGrpBx.Text = "Customer Information";
            // 
            // transactionIdLbl
            // 
            this.transactionIdLbl.AutoSize = true;
            this.transactionIdLbl.Location = new System.Drawing.Point(648, 16);
            this.transactionIdLbl.Name = "transactionIdLbl";
            this.transactionIdLbl.Size = new System.Drawing.Size(83, 13);
            this.transactionIdLbl.TabIndex = 11;
            this.transactionIdLbl.Text = "Transaction ID :";
            // 
            // transactionDtLbl
            // 
            this.transactionDtLbl.AutoSize = true;
            this.transactionDtLbl.Location = new System.Drawing.Point(648, 61);
            this.transactionDtLbl.Name = "transactionDtLbl";
            this.transactionDtLbl.Size = new System.Drawing.Size(36, 13);
            this.transactionDtLbl.TabIndex = 12;
            this.transactionDtLbl.Text = "Date :";
            // 
            // transactionIDTxtBx
            // 
            this.transactionIDTxtBx.Enabled = false;
            this.transactionIDTxtBx.Location = new System.Drawing.Point(651, 32);
            this.transactionIDTxtBx.Name = "transactionIDTxtBx";
            this.transactionIDTxtBx.Size = new System.Drawing.Size(147, 20);
            this.transactionIDTxtBx.TabIndex = 13;
            // 
            // transactionDateTxtBx
            // 
            this.transactionDateTxtBx.Enabled = false;
            this.transactionDateTxtBx.Location = new System.Drawing.Point(651, 77);
            this.transactionDateTxtBx.Name = "transactionDateTxtBx";
            this.transactionDateTxtBx.Size = new System.Drawing.Size(70, 20);
            this.transactionDateTxtBx.TabIndex = 14;
            // 
            // woodTypeLbl
            // 
            this.woodTypeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.woodTypeLbl.AutoSize = true;
            this.woodTypeLbl.Location = new System.Drawing.Point(3, 71);
            this.woodTypeLbl.Name = "woodTypeLbl";
            this.woodTypeLbl.Size = new System.Drawing.Size(37, 13);
            this.woodTypeLbl.TabIndex = 19;
            this.woodTypeLbl.Text = "Type :";
            // 
            // woodLengthLbl
            // 
            this.woodLengthLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.woodLengthLbl.AutoSize = true;
            this.woodLengthLbl.Location = new System.Drawing.Point(143, 110);
            this.woodLengthLbl.Name = "woodLengthLbl";
            this.woodLengthLbl.Size = new System.Drawing.Size(46, 13);
            this.woodLengthLbl.TabIndex = 20;
            this.woodLengthLbl.Text = "Length :";
            // 
            // woodWidthLbl
            // 
            this.woodWidthLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.woodWidthLbl.AutoSize = true;
            this.woodWidthLbl.Location = new System.Drawing.Point(73, 110);
            this.woodWidthLbl.Name = "woodWidthLbl";
            this.woodWidthLbl.Size = new System.Drawing.Size(41, 13);
            this.woodWidthLbl.TabIndex = 21;
            this.woodWidthLbl.Text = "Width :";
            // 
            // woodThcknssLbl
            // 
            this.woodThcknssLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.woodThcknssLbl.AutoSize = true;
            this.woodThcknssLbl.Location = new System.Drawing.Point(3, 110);
            this.woodThcknssLbl.Name = "woodThcknssLbl";
            this.woodThcknssLbl.Size = new System.Drawing.Size(62, 13);
            this.woodThcknssLbl.TabIndex = 22;
            this.woodThcknssLbl.Text = "Thickness :";
            // 
            // woodGrpBx
            // 
            this.woodGrpBx.Controls.Add(this.searchWoodLbl);
            this.woodGrpBx.Controls.Add(this.searchWoodCmboBx);
            this.woodGrpBx.Controls.Add(this.woodTypeTxtBx);
            this.woodGrpBx.Controls.Add(this.woodThcknssTxtBx);
            this.woodGrpBx.Controls.Add(this.woodWidthTxtBx);
            this.woodGrpBx.Controls.Add(this.woodLengthTxtBx);
            this.woodGrpBx.Controls.Add(this.remWoodBtn);
            this.woodGrpBx.Controls.Add(this.addWoodBtn);
            this.woodGrpBx.Controls.Add(this.qtyTxtBx);
            this.woodGrpBx.Controls.Add(this.qtyLbl);
            this.woodGrpBx.Controls.Add(this.woodThcknssLbl);
            this.woodGrpBx.Controls.Add(this.woodTypeLbl);
            this.woodGrpBx.Controls.Add(this.woodWidthLbl);
            this.woodGrpBx.Controls.Add(this.woodLengthLbl);
            this.woodGrpBx.Location = new System.Drawing.Point(9, 127);
            this.woodGrpBx.Name = "woodGrpBx";
            this.woodGrpBx.Size = new System.Drawing.Size(216, 250);
            this.woodGrpBx.TabIndex = 23;
            this.woodGrpBx.TabStop = false;
            this.woodGrpBx.Text = "Wood";
            // 
            // searchWoodLbl
            // 
            this.searchWoodLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchWoodLbl.AutoSize = true;
            this.searchWoodLbl.Location = new System.Drawing.Point(3, 19);
            this.searchWoodLbl.Name = "searchWoodLbl";
            this.searchWoodLbl.Size = new System.Drawing.Size(47, 13);
            this.searchWoodLbl.TabIndex = 32;
            this.searchWoodLbl.Text = "Search :";
            // 
            // searchWoodCmboBx
            // 
            this.searchWoodCmboBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchWoodCmboBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchWoodCmboBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchWoodCmboBx.FormattingEnabled = true;
            this.searchWoodCmboBx.Location = new System.Drawing.Point(6, 35);
            this.searchWoodCmboBx.Name = "searchWoodCmboBx";
            this.searchWoodCmboBx.Size = new System.Drawing.Size(204, 21);
            this.searchWoodCmboBx.TabIndex = 31;
            this.searchWoodCmboBx.SelectedIndexChanged += new System.EventHandler(this.searchWoodCmboBx_SelectedIndexChanged);
            // 
            // woodTypeTxtBx
            // 
            this.woodTypeTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.woodTypeTxtBx.Enabled = false;
            this.woodTypeTxtBx.Location = new System.Drawing.Point(6, 87);
            this.woodTypeTxtBx.Name = "woodTypeTxtBx";
            this.woodTypeTxtBx.Size = new System.Drawing.Size(204, 20);
            this.woodTypeTxtBx.TabIndex = 30;
            // 
            // woodThcknssTxtBx
            // 
            this.woodThcknssTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.woodThcknssTxtBx.Enabled = false;
            this.woodThcknssTxtBx.Location = new System.Drawing.Point(6, 126);
            this.woodThcknssTxtBx.Name = "woodThcknssTxtBx";
            this.woodThcknssTxtBx.Size = new System.Drawing.Size(64, 20);
            this.woodThcknssTxtBx.TabIndex = 29;
            // 
            // woodWidthTxtBx
            // 
            this.woodWidthTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.woodWidthTxtBx.Enabled = false;
            this.woodWidthTxtBx.Location = new System.Drawing.Point(76, 126);
            this.woodWidthTxtBx.Name = "woodWidthTxtBx";
            this.woodWidthTxtBx.Size = new System.Drawing.Size(64, 20);
            this.woodWidthTxtBx.TabIndex = 28;
            // 
            // woodLengthTxtBx
            // 
            this.woodLengthTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.woodLengthTxtBx.Enabled = false;
            this.woodLengthTxtBx.Location = new System.Drawing.Point(146, 126);
            this.woodLengthTxtBx.Name = "woodLengthTxtBx";
            this.woodLengthTxtBx.Size = new System.Drawing.Size(64, 20);
            this.woodLengthTxtBx.TabIndex = 27;
            // 
            // remWoodBtn
            // 
            this.remWoodBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remWoodBtn.Location = new System.Drawing.Point(112, 191);
            this.remWoodBtn.Name = "remWoodBtn";
            this.remWoodBtn.Size = new System.Drawing.Size(98, 53);
            this.remWoodBtn.TabIndex = 26;
            this.remWoodBtn.Text = "Remove";
            this.remWoodBtn.UseVisualStyleBackColor = true;
            this.remWoodBtn.Click += new System.EventHandler(this.remWoodBtn_Click);
            // 
            // addWoodBtn
            // 
            this.addWoodBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addWoodBtn.Location = new System.Drawing.Point(6, 191);
            this.addWoodBtn.Name = "addWoodBtn";
            this.addWoodBtn.Size = new System.Drawing.Size(100, 53);
            this.addWoodBtn.TabIndex = 25;
            this.addWoodBtn.Text = "Add";
            this.addWoodBtn.UseVisualStyleBackColor = true;
            this.addWoodBtn.Click += new System.EventHandler(this.addWoodBtn_Click);
            // 
            // qtyTxtBx
            // 
            this.qtyTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qtyTxtBx.Location = new System.Drawing.Point(6, 165);
            this.qtyTxtBx.Name = "qtyTxtBx";
            this.qtyTxtBx.Size = new System.Drawing.Size(64, 20);
            this.qtyTxtBx.TabIndex = 24;
            // 
            // qtyLbl
            // 
            this.qtyLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qtyLbl.AutoSize = true;
            this.qtyLbl.Location = new System.Drawing.Point(3, 149);
            this.qtyLbl.Name = "qtyLbl";
            this.qtyLbl.Size = new System.Drawing.Size(52, 13);
            this.qtyLbl.TabIndex = 23;
            this.qtyLbl.Text = "Quantity :";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(12, 380);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(37, 13);
            this.totalLbl.TabIndex = 24;
            this.totalLbl.Text = "Total :";
            // 
            // totalTxtBx
            // 
            this.totalTxtBx.Enabled = false;
            this.totalTxtBx.Location = new System.Drawing.Point(15, 396);
            this.totalTxtBx.Name = "totalTxtBx";
            this.totalTxtBx.Size = new System.Drawing.Size(204, 20);
            this.totalTxtBx.TabIndex = 26;
            this.totalTxtBx.Text = "0";
            // 
            // addTransactionBtn
            // 
            this.addTransactionBtn.Location = new System.Drawing.Point(15, 422);
            this.addTransactionBtn.Name = "addTransactionBtn";
            this.addTransactionBtn.Size = new System.Drawing.Size(100, 44);
            this.addTransactionBtn.TabIndex = 27;
            this.addTransactionBtn.Text = "Order!";
            this.addTransactionBtn.UseVisualStyleBackColor = true;
            this.addTransactionBtn.Click += new System.EventHandler(this.addTransactionBtn_Click);
            // 
            // transactionSttsTxtBx
            // 
            this.transactionSttsTxtBx.Enabled = false;
            this.transactionSttsTxtBx.Location = new System.Drawing.Point(727, 77);
            this.transactionSttsTxtBx.Name = "transactionSttsTxtBx";
            this.transactionSttsTxtBx.Size = new System.Drawing.Size(71, 20);
            this.transactionSttsTxtBx.TabIndex = 28;
            this.transactionSttsTxtBx.Text = "NEW";
            // 
            // transactionStatusLbl
            // 
            this.transactionStatusLbl.AutoSize = true;
            this.transactionStatusLbl.Location = new System.Drawing.Point(724, 61);
            this.transactionStatusLbl.Name = "transactionStatusLbl";
            this.transactionStatusLbl.Size = new System.Drawing.Size(43, 13);
            this.transactionStatusLbl.TabIndex = 29;
            this.transactionStatusLbl.Text = "Status :";
            // 
            // TransactionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.transactionStatusLbl);
            this.Controls.Add(this.transactionSttsTxtBx);
            this.Controls.Add(this.addTransactionBtn);
            this.Controls.Add(this.totalTxtBx);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.woodGrpBx);
            this.Controls.Add(this.transactionDateTxtBx);
            this.Controls.Add(this.transactionIDTxtBx);
            this.Controls.Add(this.transactionDtLbl);
            this.Controls.Add(this.transactionIdLbl);
            this.Controls.Add(this.customerInfoGrpBx);
            this.Controls.Add(this.transactionItemsGrpBx);
            this.Name = "TransactionManagement";
            this.Size = new System.Drawing.Size(814, 531);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDGV)).EndInit();
            this.transactionItemsGrpBx.ResumeLayout(false);
            this.customerInfoGrpBx.ResumeLayout(false);
            this.customerInfoGrpBx.PerformLayout();
            this.woodGrpBx.ResumeLayout(false);
            this.woodGrpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersDGV;
        private System.Windows.Forms.ComboBox customerCmboBx;
        private System.Windows.Forms.Label cstmrNmLbl;
        private System.Windows.Forms.TextBox cstmrAddrssTxtBx;
        private System.Windows.Forms.Label cstmrAddrssLbl;
        private System.Windows.Forms.Label cntctPrsnLbl;
        private System.Windows.Forms.Label cntctNmbrLbl;
        private System.Windows.Forms.TextBox cntctPrsnTxtBx;
        private System.Windows.Forms.TextBox cntctNmbrTxtBx;
        private System.Windows.Forms.GroupBox transactionItemsGrpBx;
        private System.Windows.Forms.GroupBox customerInfoGrpBx;
        private System.Windows.Forms.Label transactionIdLbl;
        private System.Windows.Forms.Label transactionDtLbl;
        private System.Windows.Forms.TextBox transactionIDTxtBx;
        private System.Windows.Forms.TextBox transactionDateTxtBx;
        private System.Windows.Forms.Label woodTypeLbl;
        private System.Windows.Forms.Label woodLengthLbl;
        private System.Windows.Forms.Label woodWidthLbl;
        private System.Windows.Forms.Label woodThcknssLbl;
        private System.Windows.Forms.GroupBox woodGrpBx;
        private System.Windows.Forms.Label qtyLbl;
        private System.Windows.Forms.Button remWoodBtn;
        private System.Windows.Forms.Button addWoodBtn;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.TextBox totalTxtBx;
        private System.Windows.Forms.Button addTransactionBtn;
        private System.Windows.Forms.TextBox transactionSttsTxtBx;
        private System.Windows.Forms.Label transactionStatusLbl;
        private System.Windows.Forms.Label searchWoodLbl;
        private System.Windows.Forms.ComboBox searchWoodCmboBx;
        private System.Windows.Forms.TextBox woodTypeTxtBx;
        private System.Windows.Forms.TextBox woodThcknssTxtBx;
        private System.Windows.Forms.TextBox woodWidthTxtBx;
        private System.Windows.Forms.TextBox woodLengthTxtBx;
        private System.Windows.Forms.TextBox qtyTxtBx;
    }
}
