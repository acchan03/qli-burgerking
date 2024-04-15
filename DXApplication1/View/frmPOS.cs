using DevExpress.Data.Filtering;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraBars.Customization;
using DevExpress.XtraEditors;
using DXApplication1.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.View
{
    public partial class frmPOS : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Ketnoi kn = new Ketnoi();
        public frmPOS()
        {
            InitializeComponent();
            cn = new SqlConnection(kn.myConnection());
        }

        public int MainID = 0;
        public string OrderType;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //them nut loai san pham
        private void AddCategories()
        {
            CatPanel.Controls.Clear();
            string query = "select * from maloaisp";
            cm = new SqlCommand(query, cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                int buttonTop = 0;
                foreach (DataRow row in dt.Rows)
                {
                    Button btn = new Button
                    {
                        BackColor = Color.Orange,
                        Size = new Size(82, 35),
                        Text = row["nametype"].ToString(),
                        Visible = true,
                        Location = new Point(0, buttonTop)  // Thay đổi vị trí y của mỗi nút
                    };
                    btn.Click += new EventHandler(_Click);
                    CatPanel.Controls.Add(btn);
                    buttonTop += 50;  // Tăng khoảng cách giữa các nút
                }
            }
        }

        private void _Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var pro = (UCproduct)item;
                pro.Visible = pro.Categories.ToLower().Contains(btn.Text.Trim().ToLower());
            }
        }

        private void AddItems(string id,string proID , string name , string cat, string price)
        {
            var w = new UCproduct()
            {
                NameP = name,
                Price = price,
                Categories = cat,
                id = Convert.ToInt32(proID)
            };
            flowLayoutPanel1.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (UCproduct)ss;
                foreach (DataGridViewRow item in listDTGview.Rows)
                {
                    //check id product already there then a one to  quantity and update price
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) * double.Parse(item.Cells["dgvPrice"].Value.ToString());

                        return;
                    }
                }
                //them san pham va tong tien 
                listDTGview.Rows.Add(new object[] { 0,0, wdg.id, wdg.NameP, 1, wdg.Price, wdg.Price });
                Gettotal();
            };
        }
        //lay san pham tu database
        private void LoadProduct()
        {
            string query = "select product.*, maloaisp.nametype from product inner join maloaisp  on product.type = maloaisp.type";
            cm = new SqlCommand(query, cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);


            foreach (DataRow item in dt.Rows)
            {
                AddItems("0",item["idpr"].ToString(), item["namepr"].ToString(), item["nametype"].ToString(), item["price"].ToString());
                
            }
        }
        private void frmPOS_Load(object sender, EventArgs e)
        {
            AddCategories();
            flowLayoutPanel1.Controls.Clear();
            LoadProduct();
        }
        //tim kiem san pham
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var pro = (UCproduct)item;
                pro.Visible = pro.NameP.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        private void listDTGview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0; 
            foreach(DataGridViewRow row in  listDTGview.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        //cap nhat total khi gia tri cua amount thay doi
        private void listDTGview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem sự kiện thay đổi có xảy ra trong cột "Amount" hay không
            int dgvAmountColumnIndex = listDTGview.Columns["dgvAmount"]?.Index ?? -1;

            if (e.ColumnIndex == dgvAmountColumnIndex)
            {
                Gettotal(); // Gọi phương thức cập nhật tổng
            }
        }

        //lay gia tri total
        private void Gettotal()
        {
            double total = 0;
            lblTotal.Text = string.Empty;
            foreach (DataGridViewRow item in listDTGview.Rows)
            {
                object cellValue = item.Cells["dgvAmount"].Value;
                if (cellValue != null)
                {
                    total += double.Parse(cellValue.ToString());
                }
                else
                {
                    total += 0;
                }
                lblTotal.Text = total.ToString("N2");
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            listDTGview.Rows.Clear();
            MainID = 0;
            lblTotal.Text = "00";
            txtbillAmount.Text = string.Empty;
            txtchange.Text = string.Empty;
            txtreceive.Text = string.Empty;
        }

        private void btnDeli_Click(object sender, EventArgs e)
        {
            OrderType = "Delivery";
        }

        private void btnTkAway_Click(object sender, EventArgs e)
        {
            OrderType = "Take Away";
        }
        public void gettTable()
        {
            string query = "select * from tableee";
            DataSet ds = kn.laydulieu(query);
            cmbTable.DataSource = ds.Tables[0];
            cmbTable.DisplayMember = "numtb";
            cmbTable.ValueMember = "idtb";
        }
        private void btnDinin_Click(object sender, EventArgs e)
        {
            OrderType = "Din in";
            cmbTable.Enabled = true;
            gettTable();
        }

        private void btnKOT_Click(object sender, EventArgs e)
        {
            //luu du lieu vao database
            string query1 = "";
            string query2 = "";
            int detailID = 0;
            if(MainID == 0)
            {
                query1 = @"insert into tblMain values (@aDate, @aTime, @TableName, 
                            @status, @orderType, @total, @received, @change);
                                SELECT SCOPE_IDENTITY()";

            }
            else
            {
                query1 = @"update tblMain set status =@status, total = @total, received=@received, change=@change where MainID = @ID";

            }
            cm = new SqlCommand(query1, cn);
            cm.Parameters.AddWithValue("@ID", MainID);
            cm.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cm.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            if (cmbTable.SelectedValue != null)
            {
                //xử lí khi selected value khác null
                cm.Parameters.AddWithValue("@TableName", cmbTable.SelectedValue.ToString());
            }
            else
            {
                // Xử lý khi SelectedValue là null
                cm.Parameters.AddWithValue("@TableName", 0);
            }

            cm.Parameters.AddWithValue("@status", "Pending");
            cm.Parameters.AddWithValue("@orderType", OrderType);
            cm.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cm.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cm.Parameters.AddWithValue("@change", Convert.ToDouble(0));

            if (cn.State == ConnectionState.Closed) { cn.Open(); }
            if (MainID ==0)
            {
               MainID =  Convert.ToInt32(cm.ExecuteScalar());
            }
            else
            {
                cm.ExecuteNonQuery();
            }
            if (cn.State == ConnectionState.Open) { cn.Close(); }

            foreach (DataGridViewRow row in listDTGview.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0) //insert
                {
                    query2 = @"insert into tblDetails values (@MainID, @proID, @qty, @price, @amount) ";
                }
                else //update
                {
                    query2 = @"update tblDetails set proID = @proID, qty =@qty, price =  @price, amount = @amount)
                                where DetailID =@ID ";
                }

                SqlCommand cm2 = new SqlCommand(query2, cn);
                cm2.Parameters.AddWithValue("@ID", detailID);
                cm2.Parameters.AddWithValue("@MainID", MainID);
                cm2.Parameters.AddWithValue("@proID",Convert.ToInt32(row.Cells["dgvproID"].Value));
                cm2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cm2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cm2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (cn.State == ConnectionState.Closed) { cn.Open(); }
                cm2.ExecuteNonQuery();
                if (cn.State == ConnectionState.Open) { cn.Close(); }

                MessageBox.Show("Saved Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainID = 0; 
                detailID =0;
                listDTGview.Rows.Clear();
                lblTotal.Text = "00";
                txtbillAmount.Text = string.Empty;
                txtchange.Text = string.Empty;
                txtreceive.Text = string.Empty;

            }
        }
        public int id = 0;
        /*
        private void btnBillList_Click(object sender, EventArgs e)
        {
            BillList frm = new BillList();
            this.Visible = false;
            frm.Visible = true;

            if(frm.MainID > 0)
            {
                id = frm.MainID;
                LoadEntries();
            }
        }

        private void LoadEntries()
        {
            string query = @"SELECT *
                                FROM tblMain m
                                INNER JOIN tblDetails d ON m.MainID = d.MainID
                                INNER JOIN product p ON p.idpr = d.proID
                                WHERE m.MainID = "+ id +"";
            SqlCommand cmd2 = new SqlCommand(query, cn);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            listDTGview.Rows.Clear();
            foreach (DataRow item in dt2.Rows )
            {
                string detailid = item["DetailID"].ToString();
                string namepr = item["namepr"].ToString();
                string proid = item["proID"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();


                object[] obj = {0, detailid, proid,namepr, qty, price, amount };
                listDTGview.Rows.Add(obj);
            }
        }*/


        public double amt;

        private void txtreceive_TextChanged(object sender, EventArgs e)
        {
            double amt = 0;
            double receipt = 0;
            double change = 0;

            double.TryParse(txtbillAmount.Text, out amt);
            double.TryParse(txtreceive.Text, out receipt);

            change = Math.Abs(amt - receipt);
        
            txtchange.Text = change.ToString();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem DataGridView có dữ liệu không
                if (listDTGview.Rows.Count > 0)
                {
                    // Chọn vị trí để lưu tệp tin
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    saveFileDialog.Title = @"C:\\Bill\\BurBill.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            // Mở tệp tin để ghi
                            using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                            {
                            // Viết dữ liệu từ DataGridView vào tệp tin
                            if (listDTGview != null && listDTGview.Rows.Count > 0)
                            {
                                foreach (DataGridViewRow row in listDTGview.Rows)
                                {
                                    for (int i = 0; i < listDTGview.Columns.Count; i++)
                                    {
                                        object cellValue = row.Cells[i].Value;
                                        string cellText = (cellValue != null) ? cellValue.ToString() : string.Empty;
                                        sw.Write(cellText + "\t");
                                    }
                                    sw.WriteLine();
                                }
                            }
                        }

                            MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
