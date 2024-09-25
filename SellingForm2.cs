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
    public partial class SellingForm2 : Form
    {
        public SellingForm2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Amresh Kumar\\source\\repos\\Super Market Management System\\Database1.mdf\";Integrated Security=True");
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CategoriesForm());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }
        private void populate()
        {
            con.Open();
            string query = "select ProdName,ProdPrice,ProdQty from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            con.Close();
        }


        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdPrice.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lblDate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (BillId.Text == "")
            {
                MessageBox.Show("Missing Bill Id");
            }
            else
            {


                con.Open();
                string query = "insert into BillTbl values(" + BillId.Text + ",'" + lblSellerName.Text + "','" + lblDate.Text + "'," + lblAmount.Text + ")";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully");
                con.Close();
                populatebills();


            }
        }
        int Grdtotal = 0, n = 0;
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            if (ProdName.Text == "" || ProdQty.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                int total = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrdersDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdName.Text;
                newRow.Cells[2].Value = ProdPrice.Text;
                newRow.Cells[3].Value = ProdQty.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                OrdersDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                lblAmount.Text = "" + Grdtotal;
            }
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Aaru SuperMarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230, 20));
            e.Graphics.DrawString("Bill ID: " + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
            e.Graphics.DrawString("Seller Name: " + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Bill Date: " + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: " + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("Ap Technology", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230, 230));

        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            if (PrintPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument.Print();
            }
        }

        private void Rebutton_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void cbSelectCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string query = "select ProdName,ProdQty  from ProductTbl where ProdCat='" + cbSelectCategory.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void populatebills()
        {
            con.Open();
            string query = "select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            BillsDGV.DataSource = ds.Tables[0];
            con.Close();
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
            //cbSearchCategory.ValueMember = "CatName";
            // cbSearchCategory.DataSource = dt;
            con.Close();
        }

        private void SellingForm2_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            fillCategory();
            lblSellerName.Text = LoginForm.SellerName;
        }
  
        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblSellerName_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CategoriesForm form = new CategoriesForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm pro = new ProductForm();
            pro.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SellerForm sell = new SellerForm();
            sell.Show();
            this.Hide();
        }
    }
}