namespace Super_Market_Management_System
{
    partial class SellerForm
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
            panel1 = new Panel();
            SellerDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            SellPass = new TextBox();
            label6 = new Label();
            Deletebutton = new Button();
            Editbutton = new Button();
            Addbutton = new Button();
            SellPhone = new TextBox();
            label5 = new Label();
            SellAge = new TextBox();
            label4 = new Label();
            SellName = new TextBox();
            label3 = new Label();
            SellId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button9 = new Button();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SellerDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(SellerDGV);
            panel1.Controls.Add(SellPass);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Deletebutton);
            panel1.Controls.Add(Editbutton);
            panel1.Controls.Add(Addbutton);
            panel1.Controls.Add(SellPhone);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(SellAge);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(SellName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(SellId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(166, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(1325, 728);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // SellerDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            SellerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SellerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SellerDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            SellerDGV.DefaultCellStyle = dataGridViewCellStyle3;
            SellerDGV.GridColor = Color.FromArgb(231, 229, 255);
            SellerDGV.Location = new Point(398, 106);
            SellerDGV.Name = "SellerDGV";
            SellerDGV.RowHeadersVisible = false;
            SellerDGV.RowHeadersWidth = 51;
            SellerDGV.RowTemplate.Height = 28;
            SellerDGV.Size = new Size(889, 592);
            SellerDGV.TabIndex = 32;
            SellerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            SellerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            SellerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            SellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            SellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            SellerDGV.ThemeStyle.BackColor = Color.White;
            SellerDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            SellerDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(255, 128, 0);
            SellerDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            SellerDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellerDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            SellerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            SellerDGV.ThemeStyle.HeaderStyle.Height = 30;
            SellerDGV.ThemeStyle.ReadOnly = false;
            SellerDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            SellerDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SellerDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellerDGV.ThemeStyle.RowsStyle.ForeColor = SystemColors.ControlText;
            SellerDGV.ThemeStyle.RowsStyle.Height = 28;
            SellerDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            SellerDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            SellerDGV.CellContentClick += SellerDGV_CellContentClick;
            // 
            // SellPass
            // 
            SellPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SellPass.Location = new Point(144, 321);
            SellPass.Name = "SellPass";
            SellPass.PasswordChar = '*';
            SellPass.Size = new Size(212, 34);
            SellPass.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 317);
            label6.Name = "label6";
            label6.Size = new Size(122, 28);
            label6.TabIndex = 30;
            label6.Text = "PASSWORD";
            // 
            // Deletebutton
            // 
            Deletebutton.BackColor = Color.White;
            Deletebutton.FlatAppearance.BorderSize = 0;
            Deletebutton.FlatStyle = FlatStyle.Flat;
            Deletebutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deletebutton.ForeColor = Color.FromArgb(255, 128, 0);
            Deletebutton.Location = new Point(247, 390);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(107, 42);
            Deletebutton.TabIndex = 26;
            Deletebutton.Text = "DELETE";
            Deletebutton.UseVisualStyleBackColor = false;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // Editbutton
            // 
            Editbutton.BackColor = Color.White;
            Editbutton.FlatAppearance.BorderSize = 0;
            Editbutton.FlatStyle = FlatStyle.Flat;
            Editbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Editbutton.ForeColor = Color.FromArgb(255, 128, 0);
            Editbutton.Location = new Point(144, 390);
            Editbutton.Name = "Editbutton";
            Editbutton.Size = new Size(97, 42);
            Editbutton.TabIndex = 25;
            Editbutton.Text = "EDIT";
            Editbutton.UseVisualStyleBackColor = false;
            Editbutton.Click += Editbutton_Click;
            // 
            // Addbutton
            // 
            Addbutton.BackColor = Color.White;
            Addbutton.FlatAppearance.BorderSize = 0;
            Addbutton.FlatStyle = FlatStyle.Flat;
            Addbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Addbutton.ForeColor = Color.FromArgb(255, 128, 0);
            Addbutton.Location = new Point(39, 390);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(99, 42);
            Addbutton.TabIndex = 5;
            Addbutton.Text = "ADD";
            Addbutton.UseVisualStyleBackColor = false;
            Addbutton.Click += button5_Click;
            // 
            // SellPhone
            // 
            SellPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SellPhone.Location = new Point(144, 262);
            SellPhone.Name = "SellPhone";
            SellPhone.Size = new Size(212, 34);
            SellPhone.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 258);
            label5.Name = "label5";
            label5.Size = new Size(81, 28);
            label5.TabIndex = 21;
            label5.Text = "PHONE";
            // 
            // SellAge
            // 
            SellAge.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SellAge.Location = new Point(144, 206);
            SellAge.Name = "SellAge";
            SellAge.Size = new Size(212, 34);
            SellAge.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 206);
            label4.Name = "label4";
            label4.Size = new Size(51, 28);
            label4.TabIndex = 19;
            label4.Text = "AGE";
            // 
            // SellName
            // 
            SellName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SellName.Location = new Point(144, 157);
            SellName.Name = "SellName";
            SellName.Size = new Size(212, 34);
            SellName.TabIndex = 18;
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
            // SellId
            // 
            SellId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SellId.Location = new Point(144, 106);
            SellId.Name = "SellId";
            SellId.Size = new Size(212, 34);
            SellId.TabIndex = 16;
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
            label1.Size = new Size(257, 38);
            label1.TabIndex = 13;
            label1.Text = "MANAGE SELLERS";
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(255, 128, 0);
            button4.Location = new Point(1437, 2);
            button4.Name = "button4";
            button4.Size = new Size(60, 40);
            button4.TabIndex = 5;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(255, 128, 0);
            button3.Location = new Point(10, 232);
            button3.Name = "button3";
            button3.Size = new Size(146, 40);
            button3.TabIndex = 32;
            button3.Text = "Selling";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(10, 170);
            button2.Name = "button2";
            button2.Size = new Size(146, 40);
            button2.TabIndex = 31;
            button2.Text = "Categories";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(10, 114);
            button1.Name = "button1";
            button1.Size = new Size(146, 40);
            button1.TabIndex = 30;
            button1.Text = "Products";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button9.ForeColor = Color.FromArgb(255, 128, 0);
            button9.Location = new Point(27, 723);
            button9.Name = "button9";
            button9.Size = new Size(106, 40);
            button9.TabIndex = 39;
            button9.Text = "Logout";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(622, 9);
            label7.Name = "label7";
            label7.Size = new Size(298, 27);
            label7.TabIndex = 33;
            label7.Text = "SuperMarket Management System";
            // 
            // SellerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 785);
            Controls.Add(label7);
            Controls.Add(button9);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SellerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SellerForm";
            Load += SellerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SellerDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button Deletebutton;
        private Button Editbutton;
        private Button Addbutton;
        private TextBox SellPhone;
        private Label label5;
        private TextBox SellAge;
        private Label label4;
        private TextBox SellName;
        private Label label3;
        private TextBox SellId;
        private Label label2;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox SellPass;
        private Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView SellerDGV;
        private Button button9;
        private Label label7;
    }
}