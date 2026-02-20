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
    public partial class Form6 : Form
    {
        private projectVPEntities1 db = new projectVPEntities1();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadData();     // تحميل البيانات
        }
        private void LoadData()
        {
            // إضافة بيانات ثابتة إلى DataGridView عند فتح الفورم

            // مسح البيانات الحالية في DataGridView قبل إضافة البيانات الجديدة
            dataGridView1.Rows.Clear();

            // إنشاء بيانات ثابتة (مصفوفة أو قائمة) لتضاف إلى DataGridView
            var data = new[]
            {
                new { ProductID = 1, ProductName = "rose", ProductType = "flower " , pQuantity = "200", ProductPrice = "10.00",Status ="available ", DateAdded ="2024-11-20", DateUpdated= "2024-11-20"},
                new { ProductID = 2, ProductName = "lily", ProductType = "flower " , pQuantity = "300", ProductPrice = "25.00",Status ="available ", DateAdded ="2024-11-20", DateUpdated= "2024-11-21"},
                new { ProductID = 3, ProductName = "daisy ", ProductType = "flower " , pQuantity = "400", ProductPrice = "10.00",Status ="available ", DateAdded ="2024-11-20", DateUpdated= "2024-11-23"},
                new { ProductID = 4, ProductName = "tulip", ProductType = "flower " , pQuantity = "500", ProductPrice = "20.00",Status ="available", DateAdded ="2024-11-20", DateUpdated= "2024-11-21" },
                new { ProductID = 5, ProductName = "surprise box", ProductType = "gift" , pQuantity = "150", ProductPrice = "200.00",Status ="available ", DateAdded ="2024-11-20", DateUpdated= "2024-11-21"},
                new { ProductID = 6, ProductName = "love box", ProductType = "gift" , pQuantity = "200", ProductPrice = "250.00",Status ="available ", DateAdded ="2024-11-20", DateUpdated= "2024-11-23"},
                new { ProductID = 7, ProductName = "treat box", ProductType = "gift" , pQuantity = "150", ProductPrice = "150.00",Status ="available ", DateAdded ="2024-11-20", DateUpdated= "2024-11-23"},
                new { ProductID = 8, ProductName = "craft box", ProductType = "gift" , pQuantity = "200", ProductPrice = "200.00",Status ="available ", DateAdded ="2024-11-20", DateUpdated= "2024-11-20" }
            };
            // إضافة البيانات إلى DataGridView
            foreach (var item in data)
            {
                dataGridView1.Rows.Add(item.ProductID, item.ProductName, item.ProductType, item.pQuantity, item.ProductPrice, item.Status, item.DateAdded, item.DateUpdated);
            }

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtproductld.Text = selectedRow.Cells[0].Value.ToString();
                txtproductname.Text = selectedRow.Cells[1].Value.ToString();
                comboBox1.SelectedItem = selectedRow.Cells[2].Value;
                txtstock.Text = selectedRow.Cells[3].Value.ToString();
                txtprice.Text = selectedRow.Cells[4].Value.ToString();
                comboBoxstatus.SelectedItem = selectedRow.Cells[5].Value;
                textBoxdataAdded.Text = selectedRow.Cells[6].Value.ToString();
                textBoxdateUpdated.Text = selectedRow.Cells[7].Value.ToString();



            }
        }

        

      

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (Control control in panel2.Controls)
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


        private void groupBoxdataproducts_Enter(object sender, EventArgs e)
        {

        }

      

        private void txtproductld_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            int textdata1 = int.Parse(txtproductld.Text);
            string textdata2 = txtproductname.Text;
            string combodata1 = comboBoxstatus.SelectedItem.ToString(); 
            string combodata2 = comboBox1.SelectedItem.ToString();
            int textdata3 = int.Parse(txtstock.Text);
            int textdata4 = int.Parse(txtprice.Text);
            string textdata5 = (textBoxdataAdded.Text);
            string textdata6 = (textBoxdateUpdated.Text);



            dataGridView1.Rows.Add(textdata1, textdata2, combodata1, combodata2, textdata3, textdata4, textdata5, textdata6);


            foreach (Control control in panel1.Controls)
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("الرجاء تحديد الصف المراد حذفه");
            }
            foreach (Control control in panel1.Controls)
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

        private void btnupdate_Click(object sender, EventArgs e)
        {

            // التأكد من أن الصف الحالي موجود
            if (dataGridView1.CurrentCell != null)
            {
                // الحصول على الصف الذي يتم تعديله بناءً على الخلية الحالية
                DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

                // التحقق من أن الحقول ليست فارغة
                if (!string.IsNullOrEmpty(txtproductld.Text) &&
                    !string.IsNullOrEmpty(txtproductname.Text) &&
                    comboBoxstatus.SelectedItem != null &&
                    comboBox1.SelectedItem != null &&
                    !string.IsNullOrEmpty(txtstock.Text) &&
                    !string.IsNullOrEmpty(txtprice.Text) &&
                    !string.IsNullOrEmpty(textBoxdataAdded.Text) &&
                    !string.IsNullOrEmpty(textBoxdateUpdated.Text))
                {
                    // تحديث الخلايا بناءً على القيم المدخلة في الحقول
                    selectedRow.Cells[0].Value = txtproductld.Text;
                    selectedRow.Cells[1].Value = txtproductname.Text;
                    selectedRow.Cells[6].Value = comboBoxstatus.SelectedItem.ToString();
                    selectedRow.Cells[3].Value = comboBox1.SelectedItem.ToString();
                    selectedRow.Cells[4].Value = txtstock.Text;
                    selectedRow.Cells[5].Value = txtprice.Text;
                    selectedRow.Cells[6].Value = textBoxdataAdded.Text;
                    selectedRow.Cells[7].Value = textBoxdateUpdated.Text;

                    // تأكيد التحديث للمستخدم (اختياري)
                    MessageBox.Show("تم تحديث البيانات بنجاح.");
                }
                else
                {
                    // في حال وجود حقول فارغة
                    MessageBox.Show("يرجى ملء جميع الحقول.");
                }
            }
        }

        private void btndashboard_Click_1(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void btnaddcashier_Click_1(object sender, EventArgs e)
        {

            Form5 f = new Form5();
            f.ShowDialog();
        }

        private void btnaddproducts_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.ShowDialog();
        }

        private void btnsalesreports_Click_1(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();

        }

        private void but_Logout_Click_1(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}
