using System;
using System.Windows.Forms;

namespace VPproject
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataMenu = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.productid = new System.Windows.Forms.TextBox();
            this.buttonadd = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnclear = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxtype = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelchange = new System.Windows.Forms.Label();
            this.labelTP = new System.Windows.Forms.Label();
            this.buttonreceipt = new System.Windows.Forms.Button();
            this.textBoxAmo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.but_Logout = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cashier\'s Portal";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dataMenu);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(215, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 276);
            this.panel3.TabIndex = 2;
            // 
            // dataMenu
            // 
            this.dataMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.ProductName,
            this.ProductType,
            this.pQuantity,
            this.ProductPrice});
            this.dataMenu.Location = new System.Drawing.Point(0, 37);
            this.dataMenu.Name = "dataMenu";
            this.dataMenu.RowTemplate.Height = 26;
            this.dataMenu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataMenu.Size = new System.Drawing.Size(491, 223);
            this.dataMenu.TabIndex = 1;
            this.dataMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMenu_CellContentClick);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Menu";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txtprice);
            this.panel4.Controls.Add(this.txtproductname);
            this.panel4.Controls.Add(this.productid);
            this.panel4.Controls.Add(this.buttonadd);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.btnclear);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.comboBoxtype);
            this.panel4.Location = new System.Drawing.Point(215, 294);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(491, 258);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(134, 138);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(96, 26);
            this.txtprice.TabIndex = 21;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(134, 88);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(96, 26);
            this.txtproductname.TabIndex = 20;
            // 
            // productid
            // 
            this.productid.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.productid.Location = new System.Drawing.Point(367, 141);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(96, 23);
            this.productid.TabIndex = 18;
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.Plum;
            this.buttonadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonadd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonadd.ForeColor = System.Drawing.Color.Black;
            this.buttonadd.Location = new System.Drawing.Point(85, 196);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(140, 30);
            this.buttonadd.TabIndex = 9;
            this.buttonadd.Text = "ADD";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.Location = new System.Drawing.Point(343, 88);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Plum;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnclear.Location = new System.Drawing.Point(278, 196);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(140, 30);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(240, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Quantity:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(26, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "price($):";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(15, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Product Name: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(240, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Product ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(131, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Type:";
            // 
            // comboBoxtype
            // 
            this.comboBoxtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtype.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.comboBoxtype.FormattingEnabled = true;
            this.comboBoxtype.Items.AddRange(new object[] {
            "flower ",
            "gift "});
            this.comboBoxtype.Location = new System.Drawing.Point(184, 31);
            this.comboBoxtype.Name = "comboBoxtype";
            this.comboBoxtype.Size = new System.Drawing.Size(121, 24);
            this.comboBoxtype.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.labelchange);
            this.panel5.Controls.Add(this.labelTP);
            this.panel5.Controls.Add(this.buttonreceipt);
            this.panel5.Controls.Add(this.textBoxAmo);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(724, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 540);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prID,
            this.PrName,
            this.Quantity,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(3, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.Size = new System.Drawing.Size(259, 268);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // prID
            // 
            this.prID.HeaderText = "prID";
            this.prID.Name = "prID";
            // 
            // PrName
            // 
            this.PrName.HeaderText = "PrName";
            this.PrName.Name = "PrName";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // labelchange
            // 
            this.labelchange.AutoSize = true;
            this.labelchange.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelchange.Location = new System.Drawing.Point(119, 394);
            this.labelchange.Name = "labelchange";
            this.labelchange.Size = new System.Drawing.Size(23, 16);
            this.labelchange.TabIndex = 16;
            this.labelchange.Text = "80";
            this.labelchange.Click += new System.EventHandler(this.labelchange_Click);
            // 
            // labelTP
            // 
            this.labelTP.AutoSize = true;
            this.labelTP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelTP.Location = new System.Drawing.Point(126, 301);
            this.labelTP.Name = "labelTP";
            this.labelTP.Size = new System.Drawing.Size(31, 16);
            this.labelTP.TabIndex = 15;
            this.labelTP.Text = "100";
            this.labelTP.Click += new System.EventHandler(this.labelTP_Click);
            // 
            // buttonreceipt
            // 
            this.buttonreceipt.BackColor = System.Drawing.Color.Plum;
            this.buttonreceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonreceipt.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonreceipt.Location = new System.Drawing.Point(61, 469);
            this.buttonreceipt.Name = "buttonreceipt";
            this.buttonreceipt.Size = new System.Drawing.Size(140, 30);
            this.buttonreceipt.TabIndex = 13;
            this.buttonreceipt.Text = "RECEIPT";
            this.buttonreceipt.UseVisualStyleBackColor = false;
            this.buttonreceipt.Click += new System.EventHandler(this.buttonreceipt_Click);
            // 
            // textBoxAmo
            // 
            this.textBoxAmo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBoxAmo.Location = new System.Drawing.Point(126, 339);
            this.textBoxAmo.Name = "textBoxAmo";
            this.textBoxAmo.Size = new System.Drawing.Size(130, 23);
            this.textBoxAmo.TabIndex = 16;
            this.textBoxAmo.Text = "120";
            this.textBoxAmo.TextChanged += new System.EventHandler(this.textBoxAmo_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(30, 394);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "Change($):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(29, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "Amount($):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(29, 301);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Total Price($):";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Plum;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.but_Logout);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 564);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VPproject.Properties.Resources.rb_214786132;
            this.pictureBox2.Location = new System.Drawing.Point(21, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // but_Logout
            // 
            this.but_Logout.BackColor = System.Drawing.Color.Plum;
            this.but_Logout.Location = new System.Drawing.Point(21, 431);
            this.but_Logout.Name = "but_Logout";
            this.but_Logout.Size = new System.Drawing.Size(140, 30);
            this.but_Logout.TabIndex = 4;
            this.but_Logout.Text = "Logout";
            this.but_Logout.UseVisualStyleBackColor = false;
            this.but_Logout.Click += new System.EventHandler(this.but_Logout_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(990, 564);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form4";
            this.Text = "Flowerista management system";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
         
        }

       

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxtype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataMenu;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxAmo;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private Button but_Logout;
        private Button buttonadd;
        private Button buttonreceipt;
        private Label labelTP;
        private Label labelchange;
        private TextBox productid;
        private DataGridViewTextBoxColumn PID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductType;
        private DataGridViewTextBoxColumn pQuantity;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn prID;
        private DataGridViewTextBoxColumn PrName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private TextBox txtproductname;
        private Label label10;
        private TextBox txtprice;
    }
}

