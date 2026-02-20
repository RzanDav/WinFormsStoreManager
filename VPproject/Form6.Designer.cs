using System.Windows.Forms;

namespace VPproject
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeldataofproducts = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxdateUpdated = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxdataAdded = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.comboBoxstatus = new System.Windows.Forms.ComboBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.txtproductld = new System.Windows.Forms.TextBox();
            this.labelprice = new System.Windows.Forms.Label();
            this.labelstatus = new System.Windows.Forms.Label();
            this.labelstock = new System.Windows.Forms.Label();
            this.labeltype = new System.Windows.Forms.Label();
            this.labelproductname = new System.Windows.Forms.Label();
            this.lableld = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_Logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labeladmns = new System.Windows.Forms.Label();
            this.btnsalesreports = new System.Windows.Forms.Button();
            this.btnaddproducts = new System.Windows.Forms.Button();
            this.btnaddcashier = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labeldataofproducts);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(233, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 304);
            this.panel1.TabIndex = 0;
            // 
            // labeldataofproducts
            // 
            this.labeldataofproducts.AutoSize = true;
            this.labeldataofproducts.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.labeldataofproducts.Location = new System.Drawing.Point(11, 6);
            this.labeldataofproducts.Name = "labeldataofproducts";
            this.labeldataofproducts.Size = new System.Drawing.Size(164, 22);
            this.labeldataofproducts.TabIndex = 0;
            this.labeldataofproducts.Text = "Data of products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.ProductName,
            this.ProductType,
            this.pQuantity,
            this.ProductPrice,
            this.Status,
            this.DateAdded,
            this.DateUpdated});
            this.dataGridView1.Location = new System.Drawing.Point(11, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(719, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PID
            // 
            this.PID.HeaderText = "ProductID";
            this.PID.Name = "PID";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "ProductType";
            this.ProductType.Name = "ProductType";
            // 
            // pQuantity
            // 
            this.pQuantity.HeaderText = "pQuantity";
            this.pQuantity.Name = "pQuantity";
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "ProductPrice";
            this.ProductPrice.Name = "ProductPrice";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // DateAdded
            // 
            this.DateAdded.HeaderText = "DateAdded";
            this.DateAdded.Name = "DateAdded";
            // 
            // DateUpdated
            // 
            this.DateUpdated.HeaderText = "DateUpdated";
            this.DateUpdated.Name = "DateUpdated";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxdateUpdated);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxdataAdded);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.btnclear);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.comboBoxstatus);
            this.panel2.Controls.Add(this.txtstock);
            this.panel2.Controls.Add(this.txtprice);
            this.panel2.Controls.Add(this.txtproductname);
            this.panel2.Controls.Add(this.txtproductld);
            this.panel2.Controls.Add(this.labelprice);
            this.panel2.Controls.Add(this.labelstatus);
            this.panel2.Controls.Add(this.labelstock);
            this.panel2.Controls.Add(this.labeltype);
            this.panel2.Controls.Add(this.labelproductname);
            this.panel2.Controls.Add(this.lableld);
            this.panel2.Location = new System.Drawing.Point(233, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 218);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(433, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Date Updated:";
            // 
            // textBoxdateUpdated
            // 
            this.textBoxdateUpdated.Location = new System.Drawing.Point(541, 118);
            this.textBoxdateUpdated.Name = "textBoxdateUpdated";
            this.textBoxdateUpdated.Size = new System.Drawing.Size(140, 20);
            this.textBoxdateUpdated.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(433, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "DateAdded:";
            // 
            // textBoxdataAdded
            // 
            this.textBoxdataAdded.Location = new System.Drawing.Point(541, 92);
            this.textBoxdataAdded.Name = "textBoxdataAdded";
            this.textBoxdataAdded.Size = new System.Drawing.Size(140, 20);
            this.textBoxdataAdded.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "flower ",
            "gift "});
            this.comboBox1.Location = new System.Drawing.Point(190, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Plum;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnadd.Location = new System.Drawing.Point(156, 163);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(101, 35);
            this.btnadd.TabIndex = 16;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Plum;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnclear.Location = new System.Drawing.Point(545, 163);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(101, 35);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Plum;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btndelete.Location = new System.Drawing.Point(421, 163);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(101, 35);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Plum;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnupdate.Location = new System.Drawing.Point(287, 163);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(101, 35);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // comboBoxstatus
            // 
            this.comboBoxstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxstatus.FormattingEnabled = true;
            this.comboBoxstatus.Items.AddRange(new object[] {
            "available",
            "unavailable"});
            this.comboBoxstatus.Location = new System.Drawing.Point(190, 84);
            this.comboBoxstatus.Name = "comboBoxstatus";
            this.comboBoxstatus.Size = new System.Drawing.Size(140, 21);
            this.comboBoxstatus.TabIndex = 12;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(541, 30);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(140, 20);
            this.txtstock.TabIndex = 10;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(541, 62);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(140, 20);
            this.txtprice.TabIndex = 9;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(190, 54);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(140, 20);
            this.txtproductname.TabIndex = 8;
            // 
            // txtproductld
            // 
            this.txtproductld.Location = new System.Drawing.Point(190, 28);
            this.txtproductld.Name = "txtproductld";
            this.txtproductld.Size = new System.Drawing.Size(140, 20);
            this.txtproductld.TabIndex = 7;
            this.txtproductld.TextChanged += new System.EventHandler(this.txtproductld_TextChanged);
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelprice.Location = new System.Drawing.Point(433, 62);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(68, 18);
            this.labelprice.TabIndex = 6;
            this.labelprice.Text = "Price ($):";
            this.labelprice.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelstatus.Location = new System.Drawing.Point(50, 83);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(54, 18);
            this.labelstatus.TabIndex = 5;
            this.labelstatus.Text = "Status:";
            // 
            // labelstock
            // 
            this.labelstock.AutoSize = true;
            this.labelstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelstock.Location = new System.Drawing.Point(433, 32);
            this.labelstock.Name = "labelstock";
            this.labelstock.Size = new System.Drawing.Size(51, 18);
            this.labelstock.TabIndex = 4;
            this.labelstock.Text = "Stock:";
            this.labelstock.Click += new System.EventHandler(this.label5_Click);
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labeltype.Location = new System.Drawing.Point(50, 112);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(44, 18);
            this.labeltype.TabIndex = 3;
            this.labeltype.Text = "Type:";
            // 
            // labelproductname
            // 
            this.labelproductname.AutoSize = true;
            this.labelproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelproductname.Location = new System.Drawing.Point(50, 56);
            this.labelproductname.Name = "labelproductname";
            this.labelproductname.Size = new System.Drawing.Size(108, 18);
            this.labelproductname.TabIndex = 2;
            this.labelproductname.Text = "Product Name:";
            // 
            // lableld
            // 
            this.lableld.AutoSize = true;
            this.lableld.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lableld.Location = new System.Drawing.Point(50, 27);
            this.lableld.Name = "lableld";
            this.lableld.Size = new System.Drawing.Size(82, 18);
            this.lableld.TabIndex = 1;
            this.lableld.Text = "Product ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Plum;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.but_Logout);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.labeladmns);
            this.groupBox1.Controls.Add(this.btnsalesreports);
            this.groupBox1.Controls.Add(this.btnaddproducts);
            this.groupBox1.Controls.Add(this.btnaddcashier);
            this.groupBox1.Controls.Add(this.btndashboard);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 564);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // but_Logout
            // 
            this.but_Logout.BackColor = System.Drawing.Color.Plum;
            this.but_Logout.Location = new System.Drawing.Point(26, 512);
            this.but_Logout.Name = "but_Logout";
            this.but_Logout.Size = new System.Drawing.Size(120, 26);
            this.but_Logout.TabIndex = 8;
            this.but_Logout.Text = "Logout";
            this.but_Logout.UseVisualStyleBackColor = false;
            this.but_Logout.Click += new System.EventHandler(this.but_Logout_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Plum;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::VPproject.Properties.Resources.rb_214786132;
            this.pictureBox1.Location = new System.Drawing.Point(26, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labeladmns
            // 
            this.labeladmns.AutoSize = true;
            this.labeladmns.BackColor = System.Drawing.Color.Plum;
            this.labeladmns.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.labeladmns.Location = new System.Drawing.Point(14, 138);
            this.labeladmns.Name = "labeladmns";
            this.labeladmns.Size = new System.Drawing.Size(145, 22);
            this.labeladmns.TabIndex = 7;
            this.labeladmns.Text = "Admin\'s Portal";
            // 
            // btnsalesreports
            // 
            this.btnsalesreports.BackColor = System.Drawing.Color.Plum;
            this.btnsalesreports.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnsalesreports.Location = new System.Drawing.Point(26, 334);
            this.btnsalesreports.Name = "btnsalesreports";
            this.btnsalesreports.Size = new System.Drawing.Size(120, 26);
            this.btnsalesreports.TabIndex = 4;
            this.btnsalesreports.Text = "Sales Reports";
            this.btnsalesreports.UseVisualStyleBackColor = false;
            this.btnsalesreports.Click += new System.EventHandler(this.btnsalesreports_Click_1);
            // 
            // btnaddproducts
            // 
            this.btnaddproducts.BackColor = System.Drawing.Color.Plum;
            this.btnaddproducts.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnaddproducts.Location = new System.Drawing.Point(26, 302);
            this.btnaddproducts.Name = "btnaddproducts";
            this.btnaddproducts.Size = new System.Drawing.Size(120, 26);
            this.btnaddproducts.TabIndex = 3;
            this.btnaddproducts.Text = "Add Products";
            this.btnaddproducts.UseVisualStyleBackColor = false;
            this.btnaddproducts.Click += new System.EventHandler(this.btnaddproducts_Click);
            // 
            // btnaddcashier
            // 
            this.btnaddcashier.BackColor = System.Drawing.Color.Plum;
            this.btnaddcashier.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnaddcashier.Location = new System.Drawing.Point(26, 271);
            this.btnaddcashier.Name = "btnaddcashier";
            this.btnaddcashier.Size = new System.Drawing.Size(120, 26);
            this.btnaddcashier.TabIndex = 2;
            this.btnaddcashier.Text = "Add Cashier";
            this.btnaddcashier.UseVisualStyleBackColor = false;
            this.btnaddcashier.Click += new System.EventHandler(this.btnaddcashier_Click_1);
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.Plum;
            this.btndashboard.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btndashboard.Location = new System.Drawing.Point(26, 240);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(120, 26);
            this.btndashboard.TabIndex = 1;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click_1);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 564);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labeldataofproducts;
        private System.Windows.Forms.Label lableld;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.Label labelstock;
        private System.Windows.Forms.Label labelproductname;
        private System.Windows.Forms.TextBox txtproductld;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ComboBox comboBoxstatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn PID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductType;
        private DataGridViewTextBoxColumn pQuantity;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn DateAdded;
        private DataGridViewTextBoxColumn DateUpdated;
        private TextBox textBoxdataAdded;
        private Label labeltype;
        private Label label1;
        private TextBox textBoxdateUpdated;
        private Label label2;
        private GroupBox groupBox1;
        private Button but_Logout;
        private PictureBox pictureBox1;
        private Label labeladmns;
        private Button btnsalesreports;
        private Button btnaddproducts;
        private Button btnaddcashier;
        private Button btndashboard;
    }
}

