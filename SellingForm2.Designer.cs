namespace Super_Market_Management_System
{
    partial class SellingForm2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm2));
            button9 = new Button();
            ProdQty = new TextBox();
            label4 = new Label();
            ProdName = new TextBox();
            label3 = new Label();
            BillId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            BillsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            Rebutton = new Button();
            cbSelectCategory = new ComboBox();
            ProdPrice = new TextBox();
            label5 = new Label();
            button4 = new Button();
            panel1 = new Panel();
            lblDate = new Label();
            lblSellerName = new Label();
            label8 = new Label();
            lblAmount = new Label();
            label6 = new Label();
            AddProductBtn = new Button();
            ProdDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            OrdersDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            id = new DataGridViewTextBoxColumn();
            PName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Printbtn = new Button();
            Add = new Button();
            PrintPreviewDialog = new PrintPreviewDialog();
            PrintDocument = new System.Drawing.Printing.PrintDocument();
            label7 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)BillsDGV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProdDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrdersDGV).BeginInit();
            SuspendLayout();
            // 
            // button9
            // 
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button9.ForeColor = Color.FromArgb(255, 128, 0);
            button9.Location = new Point(27, 719);
            button9.Name = "button9";
            button9.Size = new Size(106, 40);
            button9.TabIndex = 49;
            button9.Text = "Logout";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // ProdQty
            // 
            ProdQty.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ProdQty.Location = new Point(208, 207);
            ProdQty.Name = "ProdQty";
            ProdQty.Size = new Size(189, 30);
            ProdQty.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 205);
            label4.Name = "label4";
            label4.Size = new Size(113, 28);
            label4.TabIndex = 19;
            label4.Text = "QUANTITY";
            // 
            // ProdName
            // 
            ProdName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ProdName.Location = new Point(208, 155);
            ProdName.Name = "ProdName";
            ProdName.Size = new Size(189, 30);
            ProdName.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 153);
            label3.Name = "label3";
            label3.Size = new Size(171, 28);
            label3.TabIndex = 17;
            label3.Text = "PRODUCT NAME";
            // 
            // BillId
            // 
            BillId.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BillId.Location = new Point(208, 110);
            BillId.Name = "BillId";
            BillId.Size = new Size(189, 30);
            BillId.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 102);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 14;
            label2.Text = "BILL ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(594, 16);
            label1.Name = "label1";
            label1.Size = new Size(235, 38);
            label1.TabIndex = 13;
            label1.Text = "SELLING STATUS";
            // 
            // BillsDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            BillsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BillsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BillsDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            BillsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            BillsDGV.GridColor = Color.FromArgb(231, 229, 255);
            BillsDGV.Location = new Point(423, 435);
            BillsDGV.Name = "BillsDGV";
            BillsDGV.RowHeadersVisible = false;
            BillsDGV.RowHeadersWidth = 51;
            BillsDGV.RowTemplate.Height = 28;
            BillsDGV.Size = new Size(888, 227);
            BillsDGV.TabIndex = 30;
            BillsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            BillsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            BillsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            BillsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            BillsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            BillsDGV.ThemeStyle.BackColor = Color.White;
            BillsDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            BillsDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(255, 128, 0);
            BillsDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            BillsDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BillsDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            BillsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            BillsDGV.ThemeStyle.HeaderStyle.Height = 30;
            BillsDGV.ThemeStyle.ReadOnly = false;
            BillsDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            BillsDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BillsDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BillsDGV.ThemeStyle.RowsStyle.ForeColor = SystemColors.ControlText;
            BillsDGV.ThemeStyle.RowsStyle.Height = 28;
            BillsDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            BillsDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Rebutton
            // 
            Rebutton.BackColor = Color.White;
            Rebutton.FlatAppearance.BorderSize = 0;
            Rebutton.FlatStyle = FlatStyle.Flat;
            Rebutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rebutton.ForeColor = Color.FromArgb(255, 128, 0);
            Rebutton.Location = new Point(247, 352);
            Rebutton.Name = "Rebutton";
            Rebutton.Size = new Size(109, 30);
            Rebutton.TabIndex = 36;
            Rebutton.Text = "Refresh";
            Rebutton.UseVisualStyleBackColor = false;
            Rebutton.Click += Rebutton_Click;
            // 
            // cbSelectCategory
            // 
            cbSelectCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSelectCategory.FormattingEnabled = true;
            cbSelectCategory.Location = new Point(25, 355);
            cbSelectCategory.Name = "cbSelectCategory";
            cbSelectCategory.Size = new Size(189, 28);
            cbSelectCategory.TabIndex = 34;
            cbSelectCategory.Text = "Select Category";
            cbSelectCategory.SelectionChangeCommitted += cbSelectCategory_SelectionChangeCommitted;
            // 
            // ProdPrice
            // 
            ProdPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ProdPrice.Location = new Point(208, 252);
            ProdPrice.Name = "ProdPrice";
            ProdPrice.Size = new Size(189, 30);
            ProdPrice.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 250);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 31;
            label5.Text = "PRICE";
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(255, 128, 0);
            button4.Location = new Point(1436, 7);
            button4.Name = "button4";
            button4.Size = new Size(60, 40);
            button4.TabIndex = 45;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblSellerName);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblAmount);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(AddProductBtn);
            panel1.Controls.Add(ProdDGV);
            panel1.Controls.Add(BillsDGV);
            panel1.Controls.Add(OrdersDGV);
            panel1.Controls.Add(Rebutton);
            panel1.Controls.Add(Printbtn);
            panel1.Controls.Add(Add);
            panel1.Controls.Add(cbSelectCategory);
            panel1.Controls.Add(ProdPrice);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ProdQty);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ProdName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(BillId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(164, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(1325, 728);
            panel1.TabIndex = 44;
            panel1.Paint += panel1_Paint;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(1182, 2);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(57, 28);
            lblDate.TabIndex = 60;
            lblDate.Text = "Date";
            // 
            // lblSellerName
            // 
            lblSellerName.AutoSize = true;
            lblSellerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSellerName.ForeColor = Color.White;
            lblSellerName.Location = new Point(3, 2);
            lblSellerName.Name = "lblSellerName";
            lblSellerName.Size = new Size(127, 28);
            lblSellerName.TabIndex = 59;
            lblSellerName.Text = "Seller Name";
            lblSellerName.Click += lblSellerName_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(815, 396);
            label8.Name = "label8";
            label8.Size = new Size(94, 28);
            label8.TabIndex = 58;
            label8.Text = "Sells List";
            label8.Click += label8_Click;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmount.ForeColor = Color.White;
            lblAmount.Location = new Point(897, 323);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(34, 28);
            lblAmount.TabIndex = 57;
            lblAmount.Text = "Rs";
            lblAmount.Click += lblAmount_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(713, 323);
            label6.Name = "label6";
            label6.Size = new Size(116, 28);
            label6.TabIndex = 56;
            label6.Text = "Amount Rs";
            // 
            // AddProductBtn
            // 
            AddProductBtn.BackColor = Color.White;
            AddProductBtn.FlatAppearance.BorderSize = 0;
            AddProductBtn.FlatStyle = FlatStyle.Flat;
            AddProductBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddProductBtn.ForeColor = Color.FromArgb(255, 128, 0);
            AddProductBtn.Location = new Point(101, 309);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(189, 32);
            AddProductBtn.TabIndex = 55;
            AddProductBtn.Text = "ADD PRODUCT";
            AddProductBtn.UseVisualStyleBackColor = false;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // ProdDGV
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            ProdDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ProdDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ProdDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            ProdDGV.DefaultCellStyle = dataGridViewCellStyle6;
            ProdDGV.GridColor = Color.FromArgb(231, 229, 255);
            ProdDGV.Location = new Point(25, 391);
            ProdDGV.Name = "ProdDGV";
            ProdDGV.RowHeadersVisible = false;
            ProdDGV.RowHeadersWidth = 51;
            ProdDGV.RowTemplate.Height = 28;
            ProdDGV.Size = new Size(372, 271);
            ProdDGV.TabIndex = 54;
            ProdDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ProdDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            ProdDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ProdDGV.ThemeStyle.BackColor = Color.White;
            ProdDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ProdDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(255, 128, 0);
            ProdDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ProdDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProdDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ProdDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ProdDGV.ThemeStyle.HeaderStyle.Height = 30;
            ProdDGV.ThemeStyle.ReadOnly = false;
            ProdDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            ProdDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ProdDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProdDGV.ThemeStyle.RowsStyle.ForeColor = SystemColors.ControlText;
            ProdDGV.ThemeStyle.RowsStyle.Height = 28;
            ProdDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ProdDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ProdDGV.CellContentClick += ProdDGV_CellContentClick;
            // 
            // OrdersDGV
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            OrdersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            OrdersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            OrdersDGV.ColumnHeadersHeight = 30;
            OrdersDGV.Columns.AddRange(new DataGridViewColumn[] { id, PName, Price, Quantity, Total });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            OrdersDGV.DefaultCellStyle = dataGridViewCellStyle9;
            OrdersDGV.GridColor = Color.FromArgb(231, 229, 255);
            OrdersDGV.Location = new Point(423, 90);
            OrdersDGV.Name = "OrdersDGV";
            OrdersDGV.RowHeadersVisible = false;
            OrdersDGV.RowHeadersWidth = 51;
            OrdersDGV.RowTemplate.Height = 28;
            OrdersDGV.Size = new Size(888, 209);
            OrdersDGV.TabIndex = 53;
            OrdersDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            OrdersDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            OrdersDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            OrdersDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            OrdersDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            OrdersDGV.ThemeStyle.BackColor = Color.White;
            OrdersDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            OrdersDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(255, 128, 0);
            OrdersDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            OrdersDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdersDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            OrdersDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            OrdersDGV.ThemeStyle.HeaderStyle.Height = 30;
            OrdersDGV.ThemeStyle.ReadOnly = false;
            OrdersDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            OrdersDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            OrdersDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdersDGV.ThemeStyle.RowsStyle.ForeColor = SystemColors.ControlText;
            OrdersDGV.ThemeStyle.RowsStyle.Height = 28;
            OrdersDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            OrdersDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // id
            // 
            id.HeaderText = "ProdId";
            id.MinimumWidth = 6;
            id.Name = "id";
            // 
            // PName
            // 
            PName.HeaderText = "ProdName";
            PName.MinimumWidth = 6;
            PName.Name = "PName";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            // 
            // Printbtn
            // 
            Printbtn.BackColor = Color.White;
            Printbtn.FlatAppearance.BorderSize = 0;
            Printbtn.FlatStyle = FlatStyle.Flat;
            Printbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Printbtn.ForeColor = Color.FromArgb(255, 128, 0);
            Printbtn.Location = new Point(897, 668);
            Printbtn.Name = "Printbtn";
            Printbtn.Size = new Size(97, 42);
            Printbtn.TabIndex = 51;
            Printbtn.Text = "Print";
            Printbtn.UseVisualStyleBackColor = false;
            Printbtn.Click += Printbtn_Click;
            // 
            // Add
            // 
            Add.BackColor = Color.White;
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.ForeColor = Color.FromArgb(255, 128, 0);
            Add.Location = new Point(730, 668);
            Add.Name = "Add";
            Add.Size = new Size(99, 42);
            Add.TabIndex = 50;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // PrintPreviewDialog
            // 
            PrintPreviewDialog.AutoScrollMargin = new Size(0, 0);
            PrintPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            PrintPreviewDialog.ClientSize = new Size(400, 300);
            PrintPreviewDialog.Document = PrintDocument;
            PrintPreviewDialog.Enabled = true;
            PrintPreviewDialog.Icon = (Icon)resources.GetObject("PrintPreviewDialog.Icon");
            PrintPreviewDialog.Name = "PrintPreviewDialog";
            PrintPreviewDialog.Visible = false;
            // 
            // PrintDocument
            // 
            PrintDocument.PrintPage += PrintDocument_PrintPage;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(648, 9);
            label7.Name = "label7";
            label7.Size = new Size(298, 27);
            label7.TabIndex = 50;
            label7.Text = "SuperMarket Management System";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(255, 128, 0);
            button3.Location = new Point(12, 213);
            button3.Name = "button3";
            button3.Size = new Size(146, 40);
            button3.TabIndex = 53;
            button3.Text = "Category";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(12, 151);
            button2.Name = "button2";
            button2.Size = new Size(146, 40);
            button2.TabIndex = 52;
            button2.Text = "Products";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(12, 95);
            button1.Name = "button1";
            button1.Size = new Size(146, 40);
            button1.TabIndex = 51;
            button1.Text = "Sellers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // SellingForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 785);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SellingForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SellingForm2";
            Load += SellingForm2_Load;
            ((System.ComponentModel.ISupportInitialize)BillsDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProdDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrdersDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button9;
        private TextBox ProdQty;
        private Label label4;
        private TextBox ProdName;
        private Label label3;
        private TextBox BillId;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView BillsDGV;
        private Button Rebutton;
        private ComboBox cbSearchCategory;
        private ComboBox cbSelectCategory;
        private TextBox ProdPrice;
        private Label label5;
        private Button button4;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView ProdDGV;
        private Guna.UI2.WinForms.Guna2DataGridView OrdersDGV;
        private Button Printbtn;
        private Button Add;
        private Button AddProductBtn;
        private Label label8;
        private Label lblAmount;
        private Label label6;
        private Label lblDate;
        private Label lblSellerName;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn PName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private PrintPreviewDialog PrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private Label label7;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}