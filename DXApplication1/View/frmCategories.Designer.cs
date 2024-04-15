namespace DXApplication1.View
{
    partial class frmCategories
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTyPo = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshPr = new System.Windows.Forms.Button();
            this.btnDelPr = new System.Windows.Forms.Button();
            this.btnEditPr = new System.Windows.Forms.Button();
            this.btnAddPr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyPo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTyPo);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(350, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 393);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // dgvTyPo
            // 
            this.dgvTyPo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTyPo.Location = new System.Drawing.Point(6, 15);
            this.dgvTyPo.Name = "dgvTyPo";
            this.dgvTyPo.Size = new System.Drawing.Size(591, 378);
            this.dgvTyPo.TabIndex = 0;
            this.dgvTyPo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTyPo_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(838, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(145, 21);
            this.txtSearch.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 4;
            // 
            // txtNameType
            // 
            this.txtNameType.Location = new System.Drawing.Point(130, 122);
            this.txtNameType.Name = "txtNameType";
            this.txtNameType.Size = new System.Drawing.Size(197, 25);
            this.txtNameType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name type";
            // 
            // txtPTC
            // 
            this.txtPTC.Location = new System.Drawing.Point(130, 47);
            this.txtPTC.Name = "txtPTC";
            this.txtPTC.Size = new System.Drawing.Size(197, 25);
            this.txtPTC.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product type code";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefreshPr);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnDelPr);
            this.groupBox1.Controls.Add(this.txtNameType);
            this.groupBox1.Controls.Add(this.btnEditPr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddPr);
            this.groupBox1.Controls.Add(this.txtPTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 393);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infomation";
            // 
            // btnRefreshPr
            // 
            this.btnRefreshPr.BackColor = System.Drawing.Color.Orange;
            this.btnRefreshPr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshPr.ForeColor = System.Drawing.Color.White;
            this.btnRefreshPr.Location = new System.Drawing.Point(12, 298);
            this.btnRefreshPr.Name = "btnRefreshPr";
            this.btnRefreshPr.Size = new System.Drawing.Size(88, 43);
            this.btnRefreshPr.TabIndex = 7;
            this.btnRefreshPr.Text = "Refresh";
            this.btnRefreshPr.UseVisualStyleBackColor = false;
            this.btnRefreshPr.Click += new System.EventHandler(this.btnRefreshPr_Click);
            // 
            // btnDelPr
            // 
            this.btnDelPr.BackColor = System.Drawing.Color.Orange;
            this.btnDelPr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelPr.ForeColor = System.Drawing.Color.White;
            this.btnDelPr.Location = new System.Drawing.Point(226, 199);
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
            this.btnEditPr.Location = new System.Drawing.Point(114, 199);
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
            this.btnAddPr.Location = new System.Drawing.Point(8, 199);
            this.btnAddPr.Name = "btnAddPr";
            this.btnAddPr.Size = new System.Drawing.Size(88, 43);
            this.btnAddPr.TabIndex = 4;
            this.btnAddPr.Text = "Add";
            this.btnAddPr.UseVisualStyleBackColor = false;
            this.btnAddPr.Click += new System.EventHandler(this.btnAddPr_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(113, 43);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categories";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 100);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DXApplication1.Properties.Resources._2603910_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 512);
            this.panel2.TabIndex = 9;
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategories";
            this.Text = "frmCategories";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyPo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTyPo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelPr;
        private System.Windows.Forms.Button btnEditPr;
        private System.Windows.Forms.Button btnAddPr;
        private System.Windows.Forms.Button btnRefreshPr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}