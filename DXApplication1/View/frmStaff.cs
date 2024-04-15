using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
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
using static DevExpress.Data.Helpers.SyncHelper.ZombieContextsDetector;

namespace DXApplication1.View
{
    public partial class frmStaff : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Ketnoi kn = new Ketnoi();
        

        public frmStaff()
        {
            InitializeComponent();
            cn = new SqlConnection(kn.myConnection());
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "insert into nhanvien values (@ID, @name, @dateofbirth, @address, @salary, @userID, @gender)";

            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@dateofbirth", dtpBirth.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
            cmd.Parameters.AddWithValue("@userID", txtUserID.Text);
            cmd.Parameters.AddWithValue("@gender", txtGender.Text);

            try
            {
                cn.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Added Successfully");
                btnRefresh.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("New Add Failed: " + ex.Message);
            }
            finally
            {
               cn.Close();
            }


        }

        public void getdata()
        {
            string query = "select * from nhanvien";
            DataSet ds = kn.laydulieu(query);
            dgvStaff.DataSource = ds.Tables[0];
        }
        public void cleardata()
        {
            txtID.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            txtID.Text = string.Empty;  
            txtName.Text = string.Empty;
            txtUserID.Text = string.Empty;  
            txtSalary.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtGender.Text = string.Empty;
            dtpBirth.Text = string.Empty;
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cleardata();
            getdata();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        { 
            string query = "update nhanvien set name=@Name, dateofbirth=@DateOfBirth, address=@Address, salary=@Salary, userID=@UserID, gender=@Gender where id=@ID";

            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@DateOfBirth", dtpBirth.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);
            cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);
            cmd.Parameters.AddWithValue("@Gender", txtGender.Text);

            try
            {
                cn.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Repaired");
                btnRefresh.PerformClick();
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            string query = "delete from nhanvien where id=@ID";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@ID", txtID.Text);

            try
            {
                cn.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted Successfully");
                btnRefresh.PerformClick();
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

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtID.Enabled = false;
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnDel.Enabled = true;
                txtID.Text = dgvStaff.Rows[r].Cells["id"].Value.ToString();
                txtAddress.Text = dgvStaff.Rows[r].Cells["address"].Value.ToString();
                txtName.Text = dgvStaff.Rows[r].Cells["name"].Value.ToString();
                txtSalary.Text = dgvStaff.Rows[r].Cells["salary"].Value.ToString();
                txtGender.Text = dgvStaff.Rows[r].Cells["gender"].Value.ToString();
                dtpBirth.Text = dgvStaff.Rows[r].Cells["dateofbirth"].Value.ToString();
                txtUserID.Text = dgvStaff.Rows[r].Cells["userID"].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from nhanvien where name like N'%{0}%' ",
                txtSearch
                );
            DataSet ds = kn.laydulieu(query);
            dgvStaff.DataSource = ds.Tables[0];
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}