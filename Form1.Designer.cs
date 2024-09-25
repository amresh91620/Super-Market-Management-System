namespace Super_Market_Management_System
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label4 = new Label();
            cbSelectRole = new ComboBox();
            button1 = new Button();
            Password = new TextBox();
            UserName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            button4 = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(444, 205);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 19;
            label4.Text = "SELECT ROLE";
            // 
            // cbSelectRole
            // 
            cbSelectRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cbSelectRole.FormattingEnabled = true;
            cbSelectRole.Items.AddRange(new object[] { "Admin", "Seller" });
            cbSelectRole.Location = new Point(560, 205);
            cbSelectRole.Name = "cbSelectRole";
            cbSelectRole.Size = new Size(207, 28);
            cbSelectRole.TabIndex = 18;
            cbSelectRole.Text = "Select Role";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(469, 367);
            button1.Name = "button1";
            button1.Size = new Size(102, 45);
            button1.TabIndex = 17;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Password.Location = new Point(560, 303);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.PlaceholderText = "Password";
            Password.Size = new Size(207, 27);
            Password.TabIndex = 16;
            // 
            // UserName
            // 
            UserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            UserName.Location = new Point(560, 255);
            UserName.Name = "UserName";
            UserName.PlaceholderText = "Username";
            UserName.Size = new Size(207, 27);
            UserName.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(444, 303);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 14;
            label3.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(444, 258);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 13;
            label2.Text = "USERNAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(414, 49);
            label1.Name = "label1";
            label1.Size = new Size(139, 31);
            label1.TabIndex = 12;
            label1.Text = "Login Panel";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(632, 367);
            button2.Name = "button2";
            button2.Size = new Size(102, 45);
            button2.TabIndex = 20;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.FromArgb(255, 128, 0);
            guna2CircleButton1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(-233, -35);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(586, 559);
            guna2CircleButton1.TabIndex = 21;
            guna2CircleButton1.Text = resources.GetString("guna2CircleButton1.Text");
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 192);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(255, 128, 0);
            button4.Location = new Point(799, 0);
            button4.Name = "button4";
            button4.Size = new Size(47, 37);
            button4.TabIndex = 22;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(329, 10);
            label5.Name = "label5";
            label5.Size = new Size(298, 27);
            label5.TabIndex = 23;
            label5.Text = "SuperMarket Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_removebg_preview;
            pictureBox1.Location = new Point(515, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(846, 497);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(guna2CircleButton1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(cbSelectRole);
            Controls.Add(button1);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private ComboBox cbSelectRole;
        private Button button1;
        private TextBox Password;
        private TextBox UserName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Button button4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
