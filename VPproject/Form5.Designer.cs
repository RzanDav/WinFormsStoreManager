using System.Windows.Forms;

namespace VPproject
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewdataofusers = new System.Windows.Forms.DataGridView();
            this.labeldataofusers = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_Logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labeladmns = new System.Windows.Forms.Label();
            this.btnsalesreports = new System.Windows.Forms.Button();
            this.btnaddproducts = new System.Windows.Forms.Button();
            this.btnaddcashier = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.pictureBoxadminadduser = new System.Windows.Forms.PictureBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnlmport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.comboBoxshift = new System.Windows.Forms.ComboBox();
            this.labelrole = new System.Windows.Forms.Label();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdataofusers)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxadminadduser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.dataGridViewdataofusers);
            this.panel2.Controls.Add(this.labeldataofusers);
            this.panel2.Location = new System.Drawing.Point(587, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 540);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Password,
            this.Shift,
            this.Image});
            this.dataGridView1.Location = new System.Drawing.Point(16, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(363, 493);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // Shift
            // 
            this.Shift.HeaderText = "Shift";
            this.Shift.Name = "Shift";
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            // 
            // dataGridViewdataofusers
            // 
            this.dataGridViewdataofusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdataofusers.EnableHeadersVisualStyles = false;
            this.dataGridViewdataofusers.Location = new System.Drawing.Point(-618, -297);
            this.dataGridViewdataofusers.Name = "dataGridViewdataofusers";
            this.dataGridViewdataofusers.Size = new System.Drawing.Size(327, 439);
            this.dataGridViewdataofusers.TabIndex = 1;
            this.dataGridViewdataofusers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewdataofusers_CellContentClick_2);
            // 
            // labeldataofusers
            // 
            this.labeldataofusers.AutoSize = true;
            this.labeldataofusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labeldataofusers.Location = new System.Drawing.Point(16, 10);
            this.labeldataofusers.Name = "labeldataofusers";
            this.labeldataofusers.Size = new System.Drawing.Size(118, 24);
            this.labeldataofusers.TabIndex = 0;
            this.labeldataofusers.Text = "Data of users";
            this.labeldataofusers.Click += new System.EventHandler(this.labeldataofusers_Click);
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
            this.groupBox1.TabIndex = 2;
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
            this.btnsalesreports.Click += new System.EventHandler(this.btnsalesreports_Click);
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
            this.btnaddcashier.Click += new System.EventHandler(this.btnaddcashier_Click);
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
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxid);
            this.panel1.Controls.Add(this.textBoxpassword);
            this.panel1.Controls.Add(this.pictureBoxadminadduser);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.btnlmport);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.comboBoxshift);
            this.panel1.Controls.Add(this.labelrole);
            this.panel1.Controls.Add(this.textBoxusername);
            this.panel1.Controls.Add(this.labelpassword);
            this.panel1.Controls.Add(this.labelusername);
            this.panel1.Location = new System.Drawing.Point(209, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 542);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(95, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID:";
            // 
            // textBoxid
            // 
            this.textBoxid.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBoxid.Location = new System.Drawing.Point(140, 357);
            this.textBoxid.Multiline = true;
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(140, 26);
            this.textBoxid.TabIndex = 16;
            this.textBoxid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxid_KeyPress);
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBoxpassword.Location = new System.Drawing.Point(140, 268);
            this.textBoxpassword.Multiline = true;
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(140, 26);
            this.textBoxpassword.TabIndex = 15;
            this.textBoxpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxpassword_KeyPress);
            // 
            // pictureBoxadminadduser
            // 
            this.pictureBoxadminadduser.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxadminadduser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxadminadduser.Image")));
            this.pictureBoxadminadduser.Location = new System.Drawing.Point(140, 35);
            this.pictureBoxadminadduser.Name = "pictureBoxadminadduser";
            this.pictureBoxadminadduser.Size = new System.Drawing.Size(80, 98);
            this.pictureBoxadminadduser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxadminadduser.TabIndex = 10;
            this.pictureBoxadminadduser.TabStop = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Plum;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnadd.Location = new System.Drawing.Point(68, 455);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(101, 35);
            this.btnadd.TabIndex = 21;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_2);
            // 
            // btnlmport
            // 
            this.btnlmport.BackColor = System.Drawing.Color.Plum;
            this.btnlmport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlmport.Location = new System.Drawing.Point(140, 138);
            this.btnlmport.Name = "btnlmport";
            this.btnlmport.Size = new System.Drawing.Size(80, 25);
            this.btnlmport.TabIndex = 11;
            this.btnlmport.Text = "lmport";
            this.btnlmport.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(140, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 79);
            this.panel3.TabIndex = 12;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Plum;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btndelete.Location = new System.Drawing.Point(195, 455);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(101, 35);
            this.btndelete.TabIndex = 19;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // comboBoxshift
            // 
            this.comboBoxshift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxshift.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxshift.FormattingEnabled = true;
            this.comboBoxshift.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboBoxshift.Location = new System.Drawing.Point(140, 313);
            this.comboBoxshift.Name = "comboBoxshift";
            this.comboBoxshift.Size = new System.Drawing.Size(140, 27);
            this.comboBoxshift.TabIndex = 14;
            // 
            // labelrole
            // 
            this.labelrole.AutoSize = true;
            this.labelrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelrole.Location = new System.Drawing.Point(82, 313);
            this.labelrole.Name = "labelrole";
            this.labelrole.Size = new System.Drawing.Size(39, 18);
            this.labelrole.TabIndex = 18;
            this.labelrole.Text = "shift:";
            // 
            // textBoxusername
            // 
            this.textBoxusername.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBoxusername.Location = new System.Drawing.Point(140, 222);
            this.textBoxusername.Multiline = true;
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(140, 26);
            this.textBoxusername.TabIndex = 17;
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelpassword.Location = new System.Drawing.Point(49, 273);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(79, 18);
            this.labelpassword.TabIndex = 16;
            this.labelpassword.Text = "Password:";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelusername.Location = new System.Drawing.Point(46, 228);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(81, 18);
            this.labelusername.TabIndex = 9;
            this.labelusername.Text = "Username:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
          
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdataofusers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxadminadduser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labeldataofusers;
        private System.Windows.Forms.DataGridView dataGridViewdataofusers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsalesreports;
        private System.Windows.Forms.Button btnaddproducts;
        private System.Windows.Forms.Button btnaddcashier;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labeladmns;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button but_Logout;
        private Panel panel1;
        private PictureBox pictureBoxadminadduser;
        private Button btnadd;
        private Button btnlmport;
        private Panel panel3;
        private Button btndelete;
        private ComboBox comboBoxshift;
        private Label labelrole;
        private TextBox textBoxusername;
        private Label labelpassword;
        private TextBox textBoxpassword;
        private Label labelusername;
        private Label label1;
        private TextBox textBoxid;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Shift;
        private DataGridViewImageColumn Image;
    }
}

