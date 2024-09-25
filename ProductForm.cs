using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Guna.UI2.WinForms;


namespace Super_Market_Management_System
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Amresh Kumar\\source\\repos\\Super Market Management System\\Database1.mdf\";Integrated Security=True");

        private void button5_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(ProdId.Text) ||
                string.IsNullOrWhiteSpace(ProdName.Text) ||
                string.IsNullOrWhiteSpace(ProdQty.Text) ||
                string.IsNullOrWhiteSpace(ProdPrice.Text))
            {
                MessageBox.Show("Please fill all the data.");
                return;
            }

            try
            {
                con.Open();
                string query = "INSERT INTO ProductTbl (ProdId, ProdName, ProdQty,ProdPrice,ProdCat) VALUES (@ProdId,@ProdName,@ProdQty,@ProdPrice,@ProdCat)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ProdId", ProdId.Text);
                cmd.Parameters.AddWithValue("@ProdName", ProdName.Text);
                cmd.Parameters.AddWithValue("@ProdQty", ProdQty.Text);
                cmd.Parameters.AddWithValue("@ProdPrice", ProdPrice.Text);
                cmd.Parameters.AddWithValue("@ProdCat", cbSelectCategory.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Product Added Successfully");
                populate();
                ProdId.Text = "";
                ProdName.Text = "";
                ProdQty.Text = "";
                ProdPrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
          
          
                if (ProdId.Text == "" || ProdName.Text == "" || ProdQty.Text == "" || ProdPrice.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    String query = "update ProductTbl set ProdId=@ProdId,ProdName=@ProdName,ProdQty=@ProdQty,ProdPrice=@ProdPrice where ProdId=@ProdId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ProdId", ProdId.Text);
                    cmd.Parameters.AddWithValue("@ProdName", ProdName.Text);
                    cmd.Parameters.AddWithValue("@ProdQty", ProdQty.Text);
                    cmd.Parameters.AddWithValue("@ProdPrice", ProdPrice.Text);
                    cmd.Parameters.AddWithValue("@ProdCat", cbSelectCategory.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully");
                    con.Close();
                    populate();
                    ProdId.Text = "";
                    ProdName.Text = "";
                    ProdQty.Text = "";
                    ProdPrice.Text = "";
                }
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
        
                if (ProdId.Text == "")
                {
                    MessageBox.Show("Select The Product to Delete");
                }
                else
                {
                    con.Open();
                    String query = "delete from ProductTbl where ProdId=" + ProdId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    con.Close();
                    populate();
                    ProdId.Text = "";
                    ProdName.Text = "";
                    ProdQty.Text = "";
                    ProdPrice.Text = "";
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProductForm());
        }

        private void fillCategory()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            cbSelectCategory.ValueMember = "CatName";
            cbSelectCategory.DataSource = dt;
            cbSearchCategory.ValueMember = "CatName";
            cbSearchCategory.DataSource = dt;
            con.Close();
        }


        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId.Text = ProductDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = ProductDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = ProductDGV.SelectedRows[0].Cells[3].Value.ToString();
            cbSelectCategory.SelectedValue = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
           // dataGridView1.DataSource = ds.Tables[0];
            ProductDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillCategory();
            populate();
        }
        private void cbSearchCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from ProductTbl where ProdCat='" + cbSelectCategory.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Rebutton_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm form = new SellerForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoriesForm form = new CategoriesForm();
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
