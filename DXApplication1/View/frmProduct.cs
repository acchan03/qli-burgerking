using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DXApplication1.View
{
    public partial class frmProduct : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Ketnoi kn = new Ketnoi();
        public frmProduct()
        {
            InitializeComponent();
            cn = new SqlConnection(kn.myConnection());
        }
          
        public void getdata()
        {
            string query = "select * from product";
            DataSet ds = kn.laydulieu(query);
            dgvProduct.DataSource = ds.Tables[0];
        }
        public void gettypeproduct()
        {
            string query = "select * from maloaisp";
            DataSet ds = kn.laydulieu(query);
            cmbType.DataSource = ds.Tables[0];
            cmbType.DisplayMember = "nametype";
            cmbType.ValueMember = "type";
        }
        public void cleardata()
        {
            txtIDPr.Enabled = true;
            btnAddPr.Enabled = true;
            btnEditPr.Enabled = false;
            btnDelPr.Enabled = false;
            txtIDPr.Text = string.Empty;
            txtNamePr.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            gettypeproduct();
            getdata();
        }

        private void btnRefreshPr_Click(object sender, EventArgs e)
        {
            cleardata();
            getdata();
        }

        private void btnAddPr_Click(object sender, EventArgs e)
        {
            string query = "insert into product values (@idpr, @namepr, @type, @price, @quantity)";

            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@idpr", txtIDPr.Text);
            cmd.Parameters.AddWithValue("@namepr", txtNamePr.Text);
            cmd.Parameters.AddWithValue("@type", cmbType.SelectedValue);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);

            try
            {
                cn.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Added Successfully");
                btnRefreshPr.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("New add failed: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnEditPr_Click(object sender, EventArgs e)
        {
            string query = "update product set namepr=@namepr, type =@type, price =@price, quantity =@quantity where idpr = @idpr";
            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@idpr", txtIDPr.Text);
            cmd.Parameters.AddWithValue("@namepr", txtNamePr.Text);
            cmd.Parameters.AddWithValue("@type", cmbType.SelectedValue);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);

            try
            {
                cn.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Repaired");
                btnRefreshPr.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Repair Failed: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnDelPr_Click(object sender, EventArgs e)
        {
            string query = "delete from product where idpr= @idpr";
                SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@idpr", txtIDPr.Text);
            

            try
            {
                cn.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted Successfully");
                btnRefreshPr.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion Failed: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnSearchPr_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from product where name like N'%{0}%' ",
                txtSearchPr
                );
            DataSet ds = kn.laydulieu(query);
            dgvProduct.DataSource = ds.Tables[0];
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtIDPr.Enabled = false;
                btnAddPr.Enabled = false;
                btnEditPr.Enabled = true;
                btnDelPr.Enabled = true;
                txtIDPr.Text = dgvProduct.Rows[r].Cells["idpr"].Value.ToString();
                txtNamePr.Text = dgvProduct.Rows[r].Cells["namepr"].Value.ToString();
                txtPrice.Text = dgvProduct.Rows[r].Cells["price"].Value.ToString();
                txtQuantity.Text = dgvProduct.Rows[r].Cells["quantity"].Value.ToString();
                cmbType.SelectedValue = dgvProduct.Rows[r].Cells["type"].Value.ToString();
            }
        }

        private void txtIDPr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}