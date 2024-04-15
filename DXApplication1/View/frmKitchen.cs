using DevExpress.Accessibility;
using DevExpress.XtraEditors;
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

namespace DXApplication1.View
{
    public partial class frmKitchen : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Ketnoi kn = new Ketnoi();
        public frmKitchen()
        {
            InitializeComponent();
            cn = new SqlConnection(kn.myConnection());
        }

        private void frmKitchen_Load(object sender, EventArgs e)
        {
            GetOrder();

        }

        private void GetOrder()
        {
            flowLayoutPanel1.Controls.Clear();
            string qry1 = @"select * from tblMain where status = 'Pending' ";
            SqlCommand cmd1 = new SqlCommand(qry1, cn);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt1);

            FlowLayoutPanel p1;

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.Width = 230;
                p1.Height = 350;
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(10, 10, 10, 10);

                FlowLayoutPanel p2 = new FlowLayoutPanel();
                p2 = new FlowLayoutPanel();
                p2.BackColor = Color.FromArgb(50, 55, 89);
                p2.AutoSize = true;
                p2.Width = 230;
                p2.Height = 125;
                p2.FlowDirection = FlowDirection.TopDown;
                p2.Margin = new Padding(0, 0, 0, 0);

                Label lb1 = new Label();
                lb1.ForeColor = Color.White;
                lb1.Margin = new Padding(10, 10, 3, 0);
                lb1.AutoSize = true;

                Label lb3 = new Label();
                lb3.ForeColor = Color.White;
                lb3.Margin = new Padding(10, 5, 3, 0);
                lb3.AutoSize = true;

                Label lb4 = new Label();
                lb4.ForeColor = Color.White;
                lb4.Margin = new Padding(10, 5, 3, 10);
                lb4.AutoSize = true;


                lb1.Text = "Table : " + dt1.Rows[i]["TableName"].ToString();
                lb3.Text = "Order Time : " + dt1.Rows[i]["aTime"].ToString();
                lb4.Text = "Order Type : " + dt1.Rows[i]["orderType"].ToString();

                p2.Controls.Add(lb1);
                p2.Controls.Add(lb3);
                p2.Controls.Add(lb4);

                p1.Controls.Add(p2);


                int mid = 0;
                mid = Convert.ToInt32(dt1.Rows[i]["MainID"].ToString());

                string qry2 = @"SELECT *
                                FROM tblMain m
                                INNER JOIN tblDetails d ON m.MainID = d.MainID
                                INNER JOIN product p ON p.idpr = d.proID
                                WHERE m.MainID = "+mid+"";


                try
                {
                    SqlCommand cmd2 = new SqlCommand(qry2, cn);
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    da2.Fill(dt2);
                    
                    for (int j = 0; j < dt2.Rows.Count; j++)
                    {
                        Label lb5 = new Label();
                        lb5.ForeColor = Color.Black;
                        lb5.Margin = new Padding(10, 5, 3, 0);
                        lb5.AutoSize = true;

                        int no = j + 1;

                        lb5.Text = " " + dt2.Rows[j]["namepr"].ToString() + " " + dt2.Rows[j]["qty"].ToString();

                        p1.Controls.Add(lb5);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Button b = new Button();
                b.Size = new Size(100, 35);
                b.Margin = new Padding(30, 5, 3, 10);
                b.Text = "Complete";
                b.Tag = dt1.Rows[i]["MainID"].ToString();

                b.Click += new EventHandler(b_click);
                p1.Controls.Add(b);



                flowLayoutPanel1.Controls.Add(p1);
            }
        }

        

        private void b_click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).Tag.ToString());
            
            if (MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string query = @"update tblMain set status ='Complete' where MainID = @ID";
                Hashtable ht = new Hashtable();
                ht.Add("@ID", id);

                if(SQL(query, ht) >0)
                {
                    MessageBox.Show("Saved Successfully", "Notification", MessageBoxButtons.OK);
                }
                GetOrder();
            }
        }
        public static int SQL(string query, Hashtable ht)
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection cn = new SqlConnection(kn.myConnection());
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.Text;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (cn.State == ConnectionState.Closed) { cn.Open(); }
                res = cmd.ExecuteNonQuery();
                if (cn.State == ConnectionState.Open) { cn.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                cn.Close();
            }
            return res;
        }
    }
}