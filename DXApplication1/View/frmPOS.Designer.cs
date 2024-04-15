namespace DXApplication1.View
{
    partial class frmPOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.CatPanel = new System.Windows.Forms.Panel();
            this.btnDeli = new System.Windows.Forms.Button();
            this.btnKOT = new System.Windows.Forms.Button();
            this.listDTGview = new System.Windows.Forms.DataGridView();
            this.dgvSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvproID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDinin = new System.Windows.Forms.Button();
            this.btnTkAway = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtbillAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtchange = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtreceive = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEntry = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.listDTGview)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(1430, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Exit";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CatPanel
            // 
            this.CatPanel.BackColor = System.Drawing.Color.Transparent;
            this.CatPanel.Location = new System.Drawing.Point(1, 51);
            this.CatPanel.Name = "CatPanel";
            this.CatPanel.Size = new System.Drawing.Size(111, 580);
            this.CatPanel.TabIndex = 2;
            // 
            // btnDeli
            // 
            this.btnDeli.BackColor = System.Drawing.Color.Orange;
            this.btnDeli.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeli.ForeColor = System.Drawing.Color.White;
            this.btnDeli.Location = new System.Drawing.Point(625, 12);
            this.btnDeli.Name = "btnDeli";
            this.btnDeli.Size = new System.Drawing.Size(158, 68);
            this.btnDeli.TabIndex = 6;
            this.btnDeli.Text = "Delivery";
            this.btnDeli.UseVisualStyleBackColor = false;
            this.btnDeli.Click += new System.EventHandler(this.btnDeli_Click);
            // 
            // btnKOT
            // 
            this.btnKOT.BackColor = System.Drawing.Color.Orange;
            this.btnKOT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKOT.ForeColor = System.Drawing.Color.White;
            this.btnKOT.Location = new System.Drawing.Point(415, 12);
            this.btnKOT.Name = "btnKOT";
            this.btnKOT.Size = new System.Drawing.Size(158, 68);
            this.btnKOT.TabIndex = 5;
            this.btnKOT.Text = "KOT";
            this.btnKOT.UseVisualStyleBackColor = false;
            this.btnKOT.Click += new System.EventHandler(this.btnKOT_Click);
            // 
            // listDTGview
            // 
            this.listDTGview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDTGview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSR,
            this.dgvid,
            this.dgvproID,
            this.dgvTen,
            this.dgvQty,
            this.dgvPrice,
            this.dgvAmount});
            this.listDTGview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDTGview.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listDTGview.Location = new System.Drawing.Point(0, 0);
            this.listDTGview.Name = "listDTGview";
            this.listDTGview.Size = new System.Drawing.Size(584, 628);
            this.listDTGview.TabIndex = 0;
            this.listDTGview.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.listDTGview_CellFormatting);
            this.listDTGview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.listDTGview_CellValueChanged);
            // 
            // dgvSR
            // 
            this.dgvSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSR.FillWeight = 35F;
            this.dgvSR.HeaderText = "Sr#";
            this.dgvSR.Name = "dgvSR";
            this.dgvSR.Width = 35;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "id";
            this.dgvid.Name = "dgvid";
            this.dgvid.Visible = false;
            // 
            // dgvproID
            // 
            this.dgvproID.HeaderText = "ProductID";
            this.dgvproID.Name = "dgvproID";
            this.dgvproID.Visible = false;
            // 
            // dgvTen
            // 
            this.dgvTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvTen.HeaderText = "Name";
            this.dgvTen.Name = "dgvTen";
            this.dgvTen.Width = 180;
            // 
            // dgvQty
            // 
            this.dgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvQty.FillWeight = 35F;
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.Width = 35;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.Width = 120;
            // 
            // dgvAmount
            // 
            this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.Name = "dgvAmount";
            // 
            // btnDinin
            // 
            this.btnDinin.BackColor = System.Drawing.Color.Orange;
            this.btnDinin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinin.ForeColor = System.Drawing.Color.White;
            this.btnDinin.Location = new System.Drawing.Point(1030, 15);
            this.btnDinin.Name = "btnDinin";
            this.btnDinin.Size = new System.Drawing.Size(158, 68);
            this.btnDinin.TabIndex = 8;
            this.btnDinin.Text = "Din In";
            this.btnDinin.UseVisualStyleBackColor = false;
            this.btnDinin.Click += new System.EventHandler(this.btnDinin_Click);
            // 
            // btnTkAway
            // 
            this.btnTkAway.BackColor = System.Drawing.Color.Orange;
            this.btnTkAway.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTkAway.ForeColor = System.Drawing.Color.White;
            this.btnTkAway.Location = new System.Drawing.Point(828, 12);
            this.btnTkAway.Name = "btnTkAway";
            this.btnTkAway.Size = new System.Drawing.Size(158, 68);
            this.btnTkAway.TabIndex = 7;
            this.btnTkAway.Text = "Take Away";
            this.btnTkAway.UseVisualStyleBackColor = false;
            this.btnTkAway.Click += new System.EventHandler(this.btnTkAway_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Orange;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(213, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(158, 68);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.CatPanel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1684, 701);
            this.panel2.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtbillAmount);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtchange);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtreceive);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(1430, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(254, 628);
            this.panel5.TabIndex = 7;
            // 
            // txtbillAmount
            // 
            this.txtbillAmount.Location = new System.Drawing.Point(25, 75);
            this.txtbillAmount.Name = "txtbillAmount";
            this.txtbillAmount.Size = new System.Drawing.Size(180, 21);
            this.txtbillAmount.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(21, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Bill Amount";
            // 
            // txtchange
            // 
            this.txtchange.Location = new System.Drawing.Point(25, 353);
            this.txtchange.Name = "txtchange";
            this.txtchange.Size = new System.Drawing.Size(180, 21);
            this.txtchange.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(21, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Change";
            // 
            // txtreceive
            // 
            this.txtreceive.Location = new System.Drawing.Point(25, 209);
            this.txtreceive.Name = "txtreceive";
            this.txtreceive.Size = new System.Drawing.Size(180, 21);
            this.txtreceive.TabIndex = 12;
            this.txtreceive.TextChanged += new System.EventHandler(this.txtreceive_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(21, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Payment Received";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(166, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 21);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(118, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(715, 580);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel4.Controls.Add(this.listDTGview);
            this.panel4.Location = new System.Drawing.Point(839, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(584, 628);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnEntry);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 632);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1684, 69);
            this.panel3.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(931, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 30);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "0.000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(834, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total:";
            // 
            // btnEntry
            // 
            this.btnEntry.Appearance.BackColor = System.Drawing.Color.Orange;
            this.btnEntry.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnEntry.Appearance.Options.UseBackColor = true;
            this.btnEntry.Appearance.Options.UseFont = true;
            this.btnEntry.Location = new System.Drawing.Point(1285, 14);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(128, 43);
            this.btnEntry.TabIndex = 2;
            this.btnEntry.Text = "ENTRY";
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(127, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "POS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.cmbTable);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnDinin);
            this.panel1.Controls.Add(this.btnTkAway);
            this.panel1.Controls.Add(this.btnDeli);
            this.panel1.Controls.Add(this.btnKOT);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1684, 100);
            this.panel1.TabIndex = 4;
            // 
            // cmbTable
            // 
            this.cmbTable.Enabled = false;
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(1285, 15);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(72, 21);
            this.cmbTable.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1245, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Table";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DXApplication1.Properties.Resources.download_removebg_preview__4_;
            this.pictureBox1.Location = new System.Drawing.Point(38, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 801);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOS";
            this.Text = "frmPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listDTGview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Panel CatPanel;
        private System.Windows.Forms.Button btnDeli;
        private System.Windows.Forms.Button btnKOT;
        private System.Windows.Forms.DataGridView listDTGview;
        private System.Windows.Forms.Button btnDinin;
        private System.Windows.Forms.Button btnTkAway;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvproID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtreceive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbillAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtchange;
        private System.Windows.Forms.Label label5;
    }
}