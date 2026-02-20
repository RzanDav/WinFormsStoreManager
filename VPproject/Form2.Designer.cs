using System.Windows.Forms;

namespace VPproject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataSalesReports = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_Logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labeladmns = new System.Windows.Forms.Label();
            this.btnsalesreports = new System.Windows.Forms.Button();
            this.btnaddproducts = new System.Windows.Forms.Button();
            this.btnaddcashier = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalesReports)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Reports";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataSalesReports);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(193, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 540);
            this.panel1.TabIndex = 4;
            // 
            // dataSalesReports
            // 
            this.dataSalesReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSalesReports.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataSalesReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSalesReports.Location = new System.Drawing.Point(13, 35);
            this.dataSalesReports.Name = "dataSalesReports";
            this.dataSalesReports.RowTemplate.Height = 25;
            this.dataSalesReports.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataSalesReports.Size = new System.Drawing.Size(757, 489);
            this.dataSalesReports.TabIndex = 1;
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
            this.groupBox1.TabIndex = 5;
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
            this.but_Logout.Click += new System.EventHandler(this.but_Logout_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.btnaddproducts.Click += new System.EventHandler(this.btnaddproducts_Click_1);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 564);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Flowerista management system";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalesReports)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Panel panel1;
        private DataGridView dataSalesReports;
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