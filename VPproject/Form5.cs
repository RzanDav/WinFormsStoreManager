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
    public partial class Form5 : Form
    {
        private projectVPEntities1 db = new projectVPEntities1();
        private object Command;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(52,"OMAR-AHMED","2154A","AM");
            dataGridView1.Rows.Add(54, "HAMD-HANI", "H9687", "PM");

        }

       
    private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void btnaddcashier_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
        }

        private void btnaddproducts_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.ShowDialog();
        }

        private void btnsalesreports_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

     


        private void comboBoxshift_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewdataofusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewdataofusers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewdataofusers_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labeldataofusers_Click(object sender, EventArgs e)
        {

        }

       

        private void btnadd_Click_2(object sender, EventArgs e)
        {
            int textdata1 = int.Parse(textBoxid.Text);
            string textdata2 = textBoxusername.Text;
            int textdata3 = int.Parse(textBoxpassword.Text);
            string combodata1 = comboBoxshift.SelectedItem.ToString();

            dataGridView1.Rows.Add(textdata1, textdata2, textdata3, combodata1);

            
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
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show( "الرجاء تحديد الصف المراد حذفه");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                textBoxusername.Text = selectedRow.Cells[1].Value.ToString();
                textBoxpassword.Text = selectedRow.Cells[2].Value.ToString();
                comboBoxshift.SelectedItem = selectedRow.Cells[3].Value;
                textBoxid.Text = selectedRow.Cells[0].Value.ToString();
            }
        }

        private void textBoxusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // التأكد من أن الصف الحالي موجود
                if (dataGridView1.CurrentCell != null)
                {
                    // الحصول على الصف الذي يتم تعديله بناءً على الخلية الحالية
                    DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

                    // التحقق من أن الحقول ليست فارغة
                    if (!string.IsNullOrEmpty(textBoxusername.Text) &&
                        !string.IsNullOrEmpty(textBoxpassword.Text) &&
                        comboBoxshift.SelectedItem != null &&
                        !string.IsNullOrEmpty(textBoxid.Text))
                    {
                        // تحديث الخلايا بناءً على القيم المدخلة في الحقول
                        selectedRow.Cells[1].Value = textBoxusername.Text;
                        selectedRow.Cells[2].Value = textBoxpassword.Text;
                        selectedRow.Cells[3].Value = comboBoxshift.SelectedItem.ToString();
                        selectedRow.Cells[0].Value = textBoxid.Text;

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
        }

        private void textBoxpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // التأكد من أن الصف الحالي موجود
                if (dataGridView1.CurrentCell != null)
                {
                    // الحصول على الصف الذي يتم تعديله بناءً على الخلية الحالية
                    DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

                    // التحقق من أن الحقول ليست فارغة
                    if (!string.IsNullOrEmpty(textBoxusername.Text) &&
                        !string.IsNullOrEmpty(textBoxpassword.Text) &&
                        comboBoxshift.SelectedItem != null &&
                        !string.IsNullOrEmpty(textBoxid.Text))
                    {
                        // تحديث الخلايا بناءً على القيم المدخلة في الحقول
                        selectedRow.Cells[1].Value = textBoxusername.Text;
                        selectedRow.Cells[2].Value = textBoxpassword.Text;
                        selectedRow.Cells[3].Value = comboBoxshift.SelectedItem.ToString();
                        selectedRow.Cells[0].Value = textBoxid.Text;

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
        }

        private void textBoxid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // التأكد من أن الصف الحالي موجود
                if (dataGridView1.CurrentCell != null)
                {
                    // الحصول على الصف الذي يتم تعديله بناءً على الخلية الحالية
                    DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

                    // التحقق من أن الحقول ليست فارغة
                    if (!string.IsNullOrEmpty(textBoxusername.Text) &&
                        !string.IsNullOrEmpty(textBoxpassword.Text) &&
                        comboBoxshift.SelectedItem != null &&
                        !string.IsNullOrEmpty(textBoxid.Text))
                    {
                        // تحديث الخلايا بناءً على القيم المدخلة في الحقول
                        selectedRow.Cells[1].Value = textBoxusername.Text;
                        selectedRow.Cells[2].Value = textBoxpassword.Text;
                        selectedRow.Cells[3].Value = comboBoxshift.SelectedItem.ToString();
                        selectedRow.Cells[0].Value = textBoxid.Text;

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
        }

        private void but_Logout_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}
