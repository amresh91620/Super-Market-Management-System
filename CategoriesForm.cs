using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Super_Market_Management_System
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Amresh Kumar\\source\\repos\\Super Market Management System\\Database1.mdf\";Integrated Security=True");
        private void button5_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(CatIdTb.Text) ||
                string.IsNullOrWhiteSpace(CatNameTb.Text) ||
                string.IsNullOrWhiteSpace(CatDescTb.Text))
            {
                MessageBox.Show("Please fill all the data.");
                return;
            }

            try
            {
                con.Open();
                string query = "INSERT INTO CategoryTbl (CatId, CatName, CatDesc) VALUES (@CatId, @CatName, @CatDesc)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CatId", CatIdTb.Text);
                cmd.Parameters.AddWithValue("@CatName", CatNameTb.Text);
                cmd.Parameters.AddWithValue("@CatDesc", CatDescTb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            CatIdTb.Text = string.Empty;
            CatNameTb.Text = string.Empty;
            CatDescTb.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CategoriesForm());
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIdTb.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTb.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdTb.Text == "")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    con.Open();
                    String query = "delete from CategoryTbl where catId=" + CatIdTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    con.Close();
                    populate();
                    CatIdTb.Text = string.Empty;
                    CatNameTb.Text = string.Empty;
                    CatDescTb.Text = string.Empty;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    String query = "update CategoryTbl set CatName=@CatName,CatDesc=@CatDesc where CatId=@CatId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CatId", CatIdTb.Text);
                    cmd.Parameters.AddWithValue("@CatName", CatNameTb.Text);
                    cmd.Parameters.AddWithValue("@CatDesc", CatDescTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Updated Successfully");
                    con.Close();
                    populate();
                    CatIdTb.Text = string.Empty;
                    CatNameTb.Text = string.Empty;
                    CatDescTb.Text = string.Empty;

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm pro = new ProductForm();
            pro.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellerForm sell = new SellerForm();
            sell.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellingForm2 form = new SellingForm2();
            form.Show();
        }
    }

}
