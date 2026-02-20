using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VPproject
{
    public partial class Form3 : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-5UVJP9J;Initial Catalog=projectVP;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
            textBoxPW.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxSP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSP.Checked)
            {

                textBoxPW.PasswordChar = '\0';


            }
            else
            {
                textBoxPW.PasswordChar = '*';


            }
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string password = textBoxPW.Text;
            string userName = textBoxUN.Text;


            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                conn.Open();


                string query = "SELECT COUNT(1) FROM cashiers WHERE Name=@userName AND Password=@password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("username", userName);
                    cmd.Parameters.AddWithValue("password", password);

                    int rows = (int)cmd.ExecuteScalar();
                    if (rows > 0)
                    {
                        MessageBox.Show("تم تسجيل الدخول بنجاح");


                        Form4 f = new Form4();
                        f.ShowDialog();
                    }
                    else if(userName=="kholoud" && password == "000")
                    {

                        MessageBox.Show("تم تسجيل الدخول بنجاح");


                        Form1 f = new Form1();
                        f.ShowDialog();

                    }

                    else
                    {
                        MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيحة");
                    }
                }


            }
        }
    }
}
