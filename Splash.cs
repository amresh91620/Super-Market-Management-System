using System;
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
    public partial class Splash : Form
    {
        private System.Windows.Forms.Timer timer;

        public Splash()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            // Configure and start the timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000; // 5 seconds (5000 milliseconds)
            timer.Tick += timer1_Tick;
            timer.Start();

            // Start the progress indicator rotation
            guna2WinProgressIndicator1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stop the timer and progress indicator
            timer.Stop();
            guna2WinProgressIndicator1.Stop();

            // Open the login form
            LoginForm loginForm = new LoginForm(); // Replace LoginForm with your actual login form class name
            loginForm.Show();

            // Hide the splash screen
            this.Hide();
        }

        private void guna2WinProgressIndicator1_Click(object sender, EventArgs e)
        {

        }
    }
}
