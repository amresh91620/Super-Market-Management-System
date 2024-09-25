namespace Super_Market_Management_System
{
    partial class ProductForm
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
            button9 = new Button();
            Rebutton = new Button();
            cbSearchCategory = new ComboBox();
            cbSelectCategory = new ComboBox();
            label6 = new Label();
            ProdPrice = new TextBox();
            label5 = new Label();
            ProductDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ProdQty = new TextBox();
            label4 = new Label();
            ProdName = new TextBox();
            ProdId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            label3 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductDGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button9
            // 
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button9.ForeColor = Color.FromArgb(255, 128, 0);
            button9.Location = new Point(12, 733);
            button9.Name = "button9";
            button9.Size = new Size(106, 40);
            button9.TabIndex = 43;
            button9.Text = "Logout";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Rebutton
            // 
            Rebutton.BackColor = Color.White;
            Rebutton.FlatAppearance.BorderSize = 0;
            Rebutton.FlatStyle = FlatStyle.Flat;
            Rebutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rebutton.ForeColor = Color.FromArgb(255, 128, 0);
            Rebutton.Location = new Point(895, 95);
            Rebutton.Name = "Rebutton";
            Rebutton.Size = new Size(99, 30);
            Rebutton.TabIndex = 36;
            Rebutton.Text = "Refresh";
            Rebutton.UseVisualStyleBackColor = false;
            Rebutton.Click += Rebutton_Click;
            // 
            // cbSearchCategory
            // 
            cbSearchCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSearchCategory.FormattingEnabled = true;
            cbSearchCategory.Location = new Point(661, 95);
            cbSearchCategory.Name = "cbSearchCategory";
            cbSearchCategory.Size = new Size(207, 28);
            cbSearchCategory.TabIndex = 35;
            cbSearchCategory.Text = "Select Category";
            cbSearchCategory.SelectionChangeCommitted += cbSearchCategory_SelectionChangeCommitted;
            // 
            // cbSelectCategory
            // 
            cbSelectCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSelectCategory.FormattingEnabled = true;
            cbSelectCategory.Location = new Point(167, 302);
            cbSelectCategory.Name = "cbSelectCategory";
            cbSelectCategory.Size = new Size(189, 28);
            cbSelectCategory.TabIndex = 34;
            cbSelectCategory.Text = "Select Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 298);
            label6.Name = "label6";
            label6.Size = new Size(114, 28);
            label6.TabIndex = 33;
            label6.Text = "CATEGORY";
            // 
            // ProdPrice
            // 
            ProdPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ProdPrice.Location = new Point(167, 252);
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
            // ProductDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ProductDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ProductDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ProductDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ProductDGV.DefaultCellStyle = dataGridViewCellStyle3;
            ProductDGV.GridColor = Color.FromArgb(231, 229, 255);
            ProductDGV.Location = new Point(374, 131);
            ProductDGV.Name = "ProductDGV";
            ProductDGV.RowHeadersVisible = false;
            ProductDGV.RowHeadersWidth = 51;
            ProductDGV.RowTemplate.Height = 28;
            ProductDGV.Size = new Size(935, 574);
            ProductDGV.TabIndex = 30;
            ProductDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ProductDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            ProductDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ProductDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ProductDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ProductDGV.ThemeStyle.BackColor = Color.White;
            ProductDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ProductDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(255, 128, 0);
            ProductDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ProductDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ProductDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ProductDGV.ThemeStyle.HeaderStyle.Height = 30;
            ProductDGV.ThemeStyle.ReadOnly = false;
            ProductDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            ProductDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ProductDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductDGV.ThemeStyle.RowsStyle.ForeColor = SystemColors.ControlText;
            ProductDGV.ThemeStyle.RowsStyle.Height = 28;
            ProductDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ProductDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ProductDGV.CellContentClick += ProductDGV_CellContentClick;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.FromArgb(255, 128, 0);
            button7.Location = new Point(247, 376);
            button7.Name = "button7";
            button7.Size = new Size(107, 42);
            button7.TabIndex = 26;
            button7.Text = "DELETE";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(255, 128, 0);
            button6.Location = new Point(144, 376);
            button6.Name = "button6";
            button6.Size = new Size(97, 42);
            button6.TabIndex = 25;
            button6.Text = "EDIT";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(255, 128, 0);
            button5.Location = new Point(39, 376);
            button5.Name = "button5";
            button5.Size = new Size(99, 42);
            button5.TabIndex = 5;
            button5.Text = "ADD";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(255, 128, 0);
            button3.Location = new Point(7, 221);
            button3.Name = "button3";
            button3.Size = new Size(146, 40);
            button3.TabIndex = 42;
            button3.Text = "Selling";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(7, 159);
            button2.Name = "button2";
            button2.Size = new Size(146, 40);
            button2.TabIndex = 41;
            button2.Text = "Categorie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(7, 103);
            button1.Name = "button1";
            button1.Size = new Size(146, 40);
            button1.TabIndex = 40;
            button1.Text = "Sellers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProdQty
            // 
            ProdQty.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ProdQty.Location = new Point(167, 206);
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
            ProdName.Location = new Point(167, 157);
            ProdName.Name = "ProdName";
            ProdName.Size = new Size(189, 30);
            ProdName.TabIndex = 18;
            // 
            // ProdId
            // 
            ProdId.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ProdId.Location = new Point(167, 106);
            ProdId.Name = "ProdId";
            ProdId.Size = new Size(189, 30);
            ProdId.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 102);
            label2.Name = "label2";
            label2.Size = new Size(33, 28);
            label2.TabIndex = 14;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(523, 25);
            label1.Name = "label1";
            label1.Size = new Size(279, 38);
            label1.TabIndex = 13;
            label1.Text = "MANAGE PRODUCT";
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
            button4.TabIndex = 39;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 153);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 17;
            label3.Text = "NAME";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(Rebutton);
            panel1.Controls.Add(cbSearchCategory);
            panel1.Controls.Add(cbSelectCategory);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(ProdPrice);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ProductDGV);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(ProdQty);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ProdName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ProdId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(164, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(1325, 728);
            panel1.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(646, 9);
            label7.Name = "label7";
            label7.Size = new Size(298, 27);
            label7.TabIndex = 37;
            label7.Text = "SuperMarket Management System";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 785);
            Controls.Add(label7);
            Controls.Add(button9);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button9;
        private Button Rebutton;
        private ComboBox cbSearchCategory;
        private ComboBox cbSelectCategory;
        private Label label6;
        private TextBox ProdPrice;
        private Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView ProductDGV;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox ProdQty;
        private Label label4;
        private TextBox ProdName;
        private TextBox ProdId;
        private Label label2;
        private Label label1;
        private Button button4;
        private Label label3;
        private Panel panel1;
        private Label label7;
    }
}