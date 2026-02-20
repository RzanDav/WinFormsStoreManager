using VPproject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;


namespace VPproject
{
    public partial class Form4 : Form
    {
        private projectVPEntities1 db = new projectVPEntities1();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadData();     // تحميل البيانات

        }
        private void LoadData()
        {
            // إضافة بيانات ثابتة إلى DataGridView عند فتح الفورم

            // مسح البيانات الحالية في DataGridView قبل إضافة البيانات الجديدة
            dataMenu.Rows.Clear();

            // إنشاء بيانات ثابتة (مصفوفة أو قائمة) لتضاف إلى DataGridView
            var data = new[]
            {
                new { ProductID = 1, ProductName = "rose", ProductType = "flower " , pQuantity = "200", ProductPrice = "10.00"},
                new { ProductID = 2, ProductName = "lily", ProductType = "flower " , pQuantity = "300", ProductPrice = "25.00"},
                new { ProductID = 3, ProductName = "daisy ", ProductType = "flower " , pQuantity = "400", ProductPrice = "10.00"},
                new { ProductID = 4, ProductName = "tulip", ProductType = "flower " , pQuantity = "500", ProductPrice = "20.00"},
                new { ProductID = 5, ProductName = "surprise box", ProductType = "gift" , pQuantity = "150", ProductPrice = "200.00"},
                new { ProductID = 6, ProductName = "love box", ProductType = "gift" , pQuantity = "200", ProductPrice = "250.00"},
                new { ProductID = 7, ProductName = "treat box", ProductType = "gift" , pQuantity = "150", ProductPrice = "150.00"},
                new { ProductID = 8, ProductName = "craft box", ProductType = "gift" , pQuantity = "200", ProductPrice = "200.00"}
            };
            // إضافة البيانات إلى DataGridView
            foreach (var item in data)
            {
                dataMenu.Rows.Add(item.ProductID, item.ProductName, item.ProductType, item.pQuantity, item.ProductPrice);
            }

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Btnclear_Click(object sender, EventArgs e)
        {

        }

       

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }




        private void buttonremove_Click(object sender, EventArgs e)
        {

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {


            int textdata1 = int.Parse(productid.Text);
            string textdata2 = txtproductname.Text;
            int textdata4 = int.Parse(numericUpDown1.Text);
            int textdata5 = int.Parse(txtprice.Text);
            dataGridView1.Rows.Add(textdata1, textdata2,  textdata4,textdata5);

            foreach (Control control in panel4.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1; // أو يمكنك تعيينه إلى قيمة افتراضية
                }
                else if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.Value = numericUpDown.Minimum; // تعيين القيمة إلى الحد الأدنى
                }
            }
            
            }

      

        private void buttonreceipt_Click(object sender, EventArgs e)
        {

        }

        private void but_Logout_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
      
        private void dataMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {

            foreach (Control control in panel4.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1; // أو يمكنك تعيينه إلى قيمة افتراضية
                }
                else if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.Value = numericUpDown.Minimum; // تعيين القيمة إلى الحد الأدنى
                }
            }
        }

        private void labelTP_Click(object sender, EventArgs e)
        {

        }

        private void labelchange_Click(object sender, EventArgs e)
        {
            labelchange.Text = (int.Parse(textBoxAmo.Text) - int.Parse(labelTP.Text)).ToString();


        }

        private void textBoxAmo_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}
