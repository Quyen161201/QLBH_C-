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

namespace QLBH
{
    public partial class frm_category : Form
    {
        public frm_category()
        {
            InitializeComponent();
        }

        
        private  SqlConnection connectDB()

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
                MessageBox.Show("Lỗi kết nối đến database"+err.Message);
            }
            return con;
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
            loadDataToGrid();


        }

        private void loadDataToGrid()
        {
            SqlConnection con = connectDB();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM category",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_category.DataSource = dt;


        }

        void selectRow(String id)
        {
            int i = 0;
            dgv_category.CurrentCell = dgv_category.Rows[i].Cells[0];
            
            while (dgv_category.Rows[i].Cells[0].Value.ToString() == id)
            {
                i++; 
                dgv_category.CurrentCell = dgv_category.Rows[i].Cells[0];
                
            }
        }
        
        private void dgv_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = e.RowIndex;
            if(i < dgv_category.RowCount - 1)
            {
                txt_id.Text = dgv_category.Rows[i].Cells[0].Value.ToString();
                txt_cate_name.Text = dgv_category.Rows[i].Cells[1].Value.ToString();
            }
            else
            {
                txt_id.Text = "";
                txt_cate_name.Text = "";
            }
           
        }

        private void lbl_cate_name_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            SqlConnection con = connectDB();
            
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "insert into category Values(@id,@cate_name)";
                comm.Parameters.AddWithValue("@id", txt_id.Text);
                comm.Parameters.AddWithValue("@cate_name", txt_cate_name.Text);
                comm.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = comm;
                comm.ExecuteNonQuery();
                loadDataToGrid();
                MessageBox.Show("Ban da them moi thanh cong");
                String id = txt_id.Text;
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = connectDB();
            
            try
            {
                string sql = "update category set cate_name=@cate_name where id = @id";
                SqlCommand comm = new SqlCommand(sql, con);
                comm.Parameters.AddWithValue("@cate_name", txt_cate_name.Text);
                comm.Parameters.AddWithValue("@id", txt_id.Text);
                MessageBox.Show("Update thành công: " + txt_cate_name.Text);
                comm.ExecuteNonQuery();
                loadDataToGrid();
                String id = txt_id.Text;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = connectDB();
            
            try
            {
                txt_id.ReadOnly = true;
                string sql = "delete from category where id='" + txt_id.Text + "'";
                SqlCommand comm = new SqlCommand(sql, con);
                comm.ExecuteNonQuery();
                loadDataToGrid();
                MessageBox.Show("Ban da xóa thanh cong"+ txt_cate_name.Text);
                dgv_category.Refresh();
                dgv_category.Show();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi", ex.Message);
            }
           
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa tên loại hàng này", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txt_cate_name.Clear();
                txt_id.Clear();
            }
            else
            {

            }
            
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

       
        private void sảnPhẩmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Product product = new Product();
            frm_category cat = new frm_category();
            this.Hide();
            product.Show();
           

        }
    }
}
