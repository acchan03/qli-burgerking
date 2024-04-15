using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Ketnoi kn = new Ketnoi();
        public frmLogin()
        {
            InitializeComponent();
            cn = new SqlConnection(kn.myConnection());
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from users where username='{0}' and upass= '{1}'",
                txtUser.Text,
                txtPassword.Text
                );
            DataSet ds = kn.laydulieu(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 1)
            {
                frmMain frmMain = new frmMain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login error!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
