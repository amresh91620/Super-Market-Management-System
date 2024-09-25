﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market_Management_System
{
    public partial class ProductForm2 : Form
    {
        public ProductForm2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            CatDescTb = new TextBox();
            label4 = new Label();
            CatNameTb = new TextBox();
            label3 = new Label();
            CatIdTb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button8 = new Button();
            button9 = new Button();
            panel1.SuspendLayout();
            ((ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(guna2DataGridView1);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(CatDescTb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CatNameTb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(CatIdTb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(164, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(1325, 728);
            panel1.TabIndex = 32;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            guna2DataGridView1.ColumnHeadersHeight = 30;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(394, 131);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 28;
            guna2DataGridView1.Size = new Size(895, 582);
            guna2DataGridView1.TabIndex = 30;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(255, 128, 0);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = SystemColors.ControlText;
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 28;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
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
            // 
            // CatDescTb
            // 
            CatDescTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            CatDescTb.Location = new Point(167, 206);
            CatDescTb.Name = "CatDescTb";
            CatDescTb.Size = new Size(189, 30);
            CatDescTb.TabIndex = 20;
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
            // CatNameTb
            // 
            CatNameTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            CatNameTb.Location = new Point(167, 157);
            CatNameTb.Name = "CatNameTb";
            CatNameTb.Size = new Size(189, 30);
            CatNameTb.TabIndex = 18;
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
            // CatIdTb
            // 
            CatIdTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            CatIdTb.Location = new Point(167, 106);
            CatIdTb.Name = "CatIdTb";
            CatIdTb.Size = new Size(189, 30);
            CatIdTb.TabIndex = 16;
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
            label1.Size = new Size(298, 38);
            label1.TabIndex = 13;
            label1.Text = "MANAGE CATEGORIE";
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
            button3.TabIndex = 36;
            button3.Text = "Selling";
            button3.UseVisualStyleBackColor = true;
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
            button2.TabIndex = 35;
            button2.Text = "Products";
            button2.UseVisualStyleBackColor = true;
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
            button1.TabIndex = 34;
            button1.Text = "Sellers";
            button1.UseVisualStyleBackColor = true;
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
            button4.TabIndex = 33;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox1.Location = new Point(167, 252);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 30);
            textBox1.TabIndex = 32;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(167, 302);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(189, 28);
            comboBox1.TabIndex = 34;
            comboBox1.Text = "Select Role";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(661, 95);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(207, 28);
            comboBox2.TabIndex = 35;
            comboBox2.Text = "Select Role";
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.FromArgb(255, 128, 0);
            button8.Location = new Point(895, 95);
            button8.Name = "button8";
            button8.Size = new Size(99, 30);
            button8.TabIndex = 36;
            button8.Text = "Refresh";
            button8.UseVisualStyleBackColor = false;
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
            button9.TabIndex = 37;
            button9.Text = "Logout";
            button9.UseVisualStyleBackColor = true;
            // 
            // ProductForm2
            // 
            ClientSize = new Size(1503, 785);
            Controls.Add(button9);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductForm2";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Button button7;
        private Button button6;
        private Button button5;
        private TextBox CatDescTb;
        private Label label4;
        private TextBox CatNameTb;
        private Label label3;
        private TextBox CatIdTb;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private Button button8;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button9;
        private Button button4;
    }
}