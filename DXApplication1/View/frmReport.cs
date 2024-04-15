using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.View
{
    public partial class frmReport : DevExpress.XtraEditors.XtraForm
    {
        public frmReport()
        {
            InitializeComponent();
        }

        Ketnoi kn = new Ketnoi();

        private void btnReport_Click(object sender, EventArgs e)
        {
            string query = string.Format(@"select * from tblMain m
                inner join tblDetails d on m.MainId = d.MainId
                inner join product p on p.idpr = d.proID
                inner join maloaisp c on c.type = p.type where Day(aDate) = {0} and Month(aDate) = {1} and Year(aDate) = {2}  ",
                txtDate.Text,
                txtMonth.Text,
                txtYear.Text
                );
            DataSet ds = kn.laydulieu(query);
            dgvReport.DataSource = ds.Tables[0];
        }
    }
}