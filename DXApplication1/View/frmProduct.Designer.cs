namespace DXApplication1.View
{
    partial class frmProduct
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRefreshPr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelPr = new System.Windows.Forms.Button();
            this.btnEditPr = new System.Windows.Forms.Button();
            this.btnAddPr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamePr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDPr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchPr = new System.Windows.Forms.Button();
            this.txtSearchPr = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Orange;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1129, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 30);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Type";
            // 
            // btnRefreshPr
            // 
            this.btnRefreshPr.BackColor = System.Drawing.Color.Orange;
            this.btnRefreshPr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshPr.ForeColor = System.Drawing.Color.White;
            this.btnRefreshPr.Location = new System.Drawing.Point(416, 13);
            this.btnRefreshPr.Name = "btnRefreshPr";
            this.btnRefreshPr.Size = new System.Drawing.Size(88, 43);
            this.btnRefreshPr.TabIndex = 7;
            this.btnRefreshPr.Text = "Refresh";
            this.btnRefreshPr.UseVisualStyleBackColor = false;
            this.btnRefreshPr.Click += new System.EventHandler(this.btnRefreshPr_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 100);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(113, 43);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DXApplication1.Properties.Resources.burger8368_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.btnRefreshPr);
            this.panel3.Controls.Add(this.btnDelPr);
            this.panel3.Controls.Add(this.btnEditPr);
            this.panel3.Controls.Add(this.btnAddPr);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 702);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1307, 69);
            this.panel3.TabIndex = 0;
            // 
            // btnDelPr
            // 
            this.btnDelPr.BackColor = System.Drawing.Color.Orange;
            this.btnDelPr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelPr.ForeColor = System.Drawing.Color.White;
            this.btnDelPr.Location = new System.Drawing.Point(281, 14);
            this.btnDelPr.Name = "btnDelPr";
            this.btnDelPr.Size = new System.Drawing.Size(88, 43);
            this.btnDelPr.TabIndex = 6;
            this.btnDelPr.Text = "Delete";
            this.btnDelPr.UseVisualStyleBackColor = false;
            this.btnDelPr.Click += new System.EventHandler(this.btnDelPr_Click);
            // 
            // btnEditPr
            // 
            this.btnEditPr.BackColor = System.Drawing.Color.Orange;
            this.btnEditPr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPr.ForeColor = System.Drawing.Color.White;
            this.btnEditPr.Location = new System.Drawing.Point(154, 14);
            this.btnEditPr.Name = "btnEditPr";
            this.btnEditPr.Size = new System.Drawing.Size(88, 43);
            this.btnEditPr.TabIndex = 5;
            this.btnEditPr.Text = "Edit";
            this.btnEditPr.UseVisualStyleBackColor = false;
            this.btnEditPr.Click += new System.EventHandler(this.btnEditPr_Click);
            // 
            // btnAddPr
            // 
            this.btnAddPr.BackColor = System.Drawing.Color.Orange;
            this.btnAddPr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPr.ForeColor = System.Drawing.Color.White;
            this.btnAddPr.Location = new System.Drawing.Point(32, 14);
            this.btnAddPr.Name = "btnAddPr";
            this.btnAddPr.Size = new System.Drawing.Size(88, 43);
            this.btnAddPr.TabIndex = 4;
            this.btnAddPr.Text = "Add";
            this.btnAddPr.UseVisualStyleBackColor = false;
            this.btnAddPr.Click += new System.EventHandler(this.btnAddPr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNamePr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIDPr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 528);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infomation";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(66, 243);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(261, 25);
            this.cmbType.TabIndex = 17;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(66, 442);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(261, 25);
            this.txtQuantity.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantity";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(66, 344);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(261, 25);
            this.txtPrice.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 4;
            // 
            // txtNamePr
            // 
            this.txtNamePr.Location = new System.Drawing.Point(66, 143);
            this.txtNamePr.Name = "txtNamePr";
            this.txtNamePr.Size = new System.Drawing.Size(261, 25);
            this.txtNamePr.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txtIDPr
            // 
            this.txtIDPr.Location = new System.Drawing.Point(66, 47);
            this.txtIDPr.Name = "txtIDPr";
            this.txtIDPr.Size = new System.Drawing.Size(261, 25);
            this.txtIDPr.TabIndex = 1;
            this.txtIDPr.TextChanged += new System.EventHandler(this.txtIDPr_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(838, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 21);
            this.txtSearch.TabIndex = 4;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(6, 15);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(932, 507);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProduct);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(351, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(938, 528);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchPr);
            this.panel2.Controls.Add(this.txtSearchPr);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 771);
            this.panel2.TabIndex = 7;
            // 
            // btnSearchPr
            // 
            this.btnSearchPr.BackColor = System.Drawing.Color.Orange;
            this.btnSearchPr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPr.ForeColor = System.Drawing.Color.White;
            this.btnSearchPr.Location = new System.Drawing.Point(1129, 121);
            this.btnSearchPr.Name = "btnSearchPr";
            this.btnSearchPr.Size = new System.Drawing.Size(79, 30);
            this.btnSearchPr.TabIndex = 9;
            this.btnSearchPr.Text = "Search";
            this.btnSearchPr.UseVisualStyleBackColor = false;
            this.btnSearchPr.Click += new System.EventHandler(this.btnSearchPr_Click);
            // 
            // txtSearchPr
            // 
            this.txtSearchPr.Location = new System.Drawing.Point(838, 128);
            this.txtSearchPr.Name = "txtSearchPr";
            this.txtSearchPr.Size = new System.Drawing.Size(262, 21);
            this.txtSearchPr.TabIndex = 8;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 771);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRefreshPr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelPr;
        private System.Windows.Forms.Button btnEditPr;
        private System.Windows.Forms.Button btnAddPr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamePr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDPr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchPr;
        private System.Windows.Forms.TextBox txtSearchPr;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbType;
    }
}