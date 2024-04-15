using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.Model
{
    public partial class UCproduct : UserControl
    {
        public UCproduct()
        {
            InitializeComponent();
        }
        public event EventHandler onSelect = null;

        public int id { get; set; }

        public string Price { get; set; }
        public string Categories { get; set; }

        public string NameP {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
        
    }
}
