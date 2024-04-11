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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QLBH
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private SqlConnection connectDB()

        {
            SqlConnection con = null;
            string strCon = "server = MSI\\SQLEXPRESS; Initial Catalog=QLBH;Integrated Security=True";
            try
            {
                con = new SqlConnection(strCon);
                con.Open();

            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi kết nối đến database" + err.Message);
            }
            return con;

        }
        private void loadDataToGrid()
        {
            SqlConnection con = connectDB();
            SqlDataAdapter da = new SqlDataAdapter("SELECT p.id,product_name,quantity,price,p.category_id,c.cate_name FROM product p,category c where p.category_id=c.id", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProduct.DataSource = dt;


        }

        void selectRow(String id)
        {
            MessageBox.Show("123123123123");
            int i = 0;
            dgvProduct.CurrentCell = dgvProduct.Rows[i].Cells[0];

            while (dgvProduct.Rows[i].Cells[0].Value.ToString() == id)
            {
                i++;
                dgvProduct.CurrentCell = dgvProduct.Rows[i].Cells[0];
                MessageBox.Show("123123");

            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            loadDataToGrid();
            Cate_load();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Cate_load()
        {
            DataTable dt = new DataTable();
            SqlConnection con = connectDB();
            String sql = "select * from category";

           
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            
            da.Fill(dt);
            con.Close();
            cmbCate.DataSource = dt;
            cmbCate.ValueMember = "id";
            cmbCate.DisplayMember = "cate_name";
          
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SqlConnection con = connectDB();

            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "insert into product Values(@id,@product_name,@quantity,@price,@category_id)";
                comm.Parameters.AddWithValue("@id", txtId.Text);
                comm.Parameters.AddWithValue("@product_name", txtName.Text);
                comm.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                comm.Parameters.AddWithValue("@price", txtPrice.Text);
                comm.Parameters.AddWithValue("@category_id", cmbCate.SelectedValue);


                comm.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = comm;
                comm.ExecuteNonQuery();
                loadDataToGrid();
                MessageBox.Show("Ban da them moi thanh cong");
                String id = txtId.Text;
                selectRow(id);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi", ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dgvProduct_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = e.RowIndex;
            if (i < dgvProduct.RowCount - 1)
            {
                txtId.Text = dgvProduct.Rows[i].Cells[0].Value.ToString();
                txtName.Text = dgvProduct.Rows[i].Cells[1].Value.ToString();

                txtQuantity.Text = dgvProduct.Rows[i].Cells[2].Value.ToString();
                txtPrice.Text = dgvProduct.Rows[i].Cells[3].Value.ToString();
              
                string cateValue = dgvProduct.Rows[i].Cells[4].Value.ToString();
                string cateDisplay = dgvProduct.Rows[i].Cells[5].Value.ToString();
                foreach (var item in cmbCate.Items)
                {
                    if (item.ToString() == cateDisplay)
                    {
                        cmbCate.SelectedItem = item;
                        break;
                    }
                }

                // Gán giá trị cho ComboBox
                cmbCate.SelectedValue = cateValue;
            }
            else
            {
                txtId.Text = "";
                txtName.Text = "";
                txtQuantity.Text = "";
                txtPrice.Text = "";
            }
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            frm_category cat = new frm_category();
            this.Hide();
            cat.Show();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            SqlConnection con = connectDB();

            try
            {
                string sql = "update product set product_name=@name,quantity=@quantity,price=@price,category_id=@category_id where id = @id";
                SqlCommand comm = new SqlCommand(sql, con);
                comm.Parameters.AddWithValue("@name", txtName.Text);
                comm.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                comm.Parameters.AddWithValue("@price", txtPrice.Text);
                comm.Parameters.AddWithValue("@category_id", cmbCate.SelectedValue);
                comm.Parameters.AddWithValue("@id",txtId.Text);
                comm.ExecuteNonQuery();
                MessageBox.Show("Update thành công: " + txtName.Text);
                loadDataToGrid();
                String id = txtId.Text;
                selectRow(id);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = connectDB();

            try
            {
                txtId.ReadOnly = true;
                string sql = "delete from product where id='" + txtId.Text + "'";
                SqlCommand comm = new SqlCommand(sql, con);
                comm.ExecuteNonQuery();
                loadDataToGrid();
                MessageBox.Show("Ban da xóa thanh cong" + txtName.Text);
                dgvProduct.Refresh();
                dgvProduct.Show();
                String id = txtId.Text;
                selectRow(id);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi", ex.Message);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn Thoát chương trình không?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}
