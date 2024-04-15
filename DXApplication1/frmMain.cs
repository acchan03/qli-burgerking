using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DXApplication1.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            label3.Text = Ketnoi.USER;
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            frmCategories frm = new frmCategories();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            frmStaff frm = new frmStaff();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.FormClosed += (s, args) => this.Show();
            this.Hide();
            frm.Show();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            frmKitchen frm = new frmKitchen();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}