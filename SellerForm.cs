using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market_Management_System
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Amresh Kumar\\source\\repos\\Super Market Management System\\Database1.mdf\";Integrated Security=True");

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SellerForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm pro = new ProductForm();
            pro.Show();
            this.Hide();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(SellId.Text) ||
                string.IsNullOrWhiteSpace(SellName.Text) ||
                string.IsNullOrWhiteSpace(SellAge.Text) ||
                string.IsNullOrWhiteSpace(SellPhone.Text) ||
                string.IsNullOrWhiteSpace(SellPass.Text))
            {
                MessageBox.Show("Please fill all the data.");
                return;
            }

            try
            {
                con.Open();
                string query = "INSERT INTO SellerTbl (SellerId, SellerName, SellerAge,SellerPhone,SellerPass) VALUES (@SellerId, @SellerName, @SellerAge,@SellerPhone,@SellerPass)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@SellerId", SellId.Text);
                cmd.Parameters.AddWithValue("@SellerName", SellName.Text);
                cmd.Parameters.AddWithValue("@SellerAge", SellAge.Text);
                cmd.Parameters.AddWithValue("@SellerPhone", SellPhone.Text);
                cmd.Parameters.AddWithValue("@SellerPass", SellPass.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SellId.Text = "";
            SellName.Text = "";
            SellAge.Text = "";
            SellPhone.Text = "";
            SellPass.Text = "";


        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE SellerTbl SET SellerName = @SellerName, SellerAge = @SellerAge, SellerPhone = @SellerPhone, SellerPass = @SellerPass WHERE SellerId = @SellerId";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@SellerId", SellId.Text);
                cmd.Parameters.AddWithValue("@SellerName", SellName.Text);
                cmd.Parameters.AddWithValue("@SellerAge", SellAge.Text);
                cmd.Parameters.AddWithValue("@SellerPhone", SellPhone.Text);
                cmd.Parameters.AddWithValue("@SellerPass", SellPass.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Updated Successfully");

                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SellId.Text = "";
            SellName.Text = "";
            SellAge.Text = "";
            SellPhone.Text = "";
            SellPass.Text = "";

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {

                if (SellId.Text == "")
                {
                    MessageBox.Show("Select The Seller to Delete");
                }
                else
                {
                    con.Open();
                    string query = "DELETE FROM SellerTbl WHERE SellerId = @SellerId";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@SellerId", SellId.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");

                    con.Close();
                    populate();  // Refreshes the data view after deletion.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SellId.Text = "";
            SellName.Text = "";
            SellAge.Text = "";
            SellPhone.Text = "";
            SellPass.Text = "";

        }

        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SellId.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            SellName.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            SellAge.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            SellPhone.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            SellPass.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            // dataGridView1.DataSource = ds.Tables[0];
            SellerDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
