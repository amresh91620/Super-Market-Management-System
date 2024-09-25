using System.Data;
using System.Data.SqlClient;
namespace Super_Market_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string SellerName = "";
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Amresh Kumar\\source\\repos\\Super Market Management System\\Database1.mdf\";Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if Username or Password fields are empty
            if (UserName.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password");
            }
            else
            {
                // Check if a role is selected
                if (cbSelectRole.SelectedIndex > -1)
                {
                    // Check if the selected role is Admin
                    if (cbSelectRole.SelectedItem.ToString() == "Admin")
                    {
                        // Verify Admin credentials
                        if (UserName.Text == "Admin" && Password.Text == "Admin")
                        {
                            ProductForm product = new ProductForm();
                            product.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are Admin, enter the correct Username and Password");
                        }
                    }
                    else // Seller login
                    {
                        try
                        {
                            con.Open();
                            string query = "SELECT COUNT(*) FROM SellerTbl WHERE SellerName = @SellerName AND SellerPass = @SellerPass";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@SellerName", UserName.Text);
                            cmd.Parameters.AddWithValue("@SellerPass", Password.Text);

                            int result = (int)cmd.ExecuteScalar();

                            // If valid seller credentials
                            if (result == 1)
                            {
                                SellerName = UserName.Text;
                                SellingForm2 form = new SellingForm2();
                                form.Show();
                                this.Hide(); // Hide current form
                            }
                            else
                            {
                                MessageBox.Show("Wrong Username or Password");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            con.Close(); // Ensure the connection is closed
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select the Role to Login");
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            Password.Text = "";
        }
    }
}
