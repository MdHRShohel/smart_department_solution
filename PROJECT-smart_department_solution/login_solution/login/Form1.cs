using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
            string adminCode = textBox1.Text;
            string kye = textBox2.Text;

            string q = "select count(admin_login.Admin_Code) as tcount from admin_login where admin_login.Admin_Code = '" + adminCode + "' and admin_login.kye = '" + kye + "'";

            if(isLogin(q) == true)
            {
                MessageBox.Show("Admin Login Successfully");
            }
            else
                MessageBox.Show("Error");

        }

        private bool isLogin(string q)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();
            try
            {
                MySqlCommand comd = new MySqlCommand(q, con);
                MySqlDataReader DR = comd.ExecuteReader();
                while (DR.Read())
                {

                }

                if (Convert.ToInt32(DR.GetString("tcount")) == 1)
                {
                    con.Close();
                    return true;
                }


            }
            catch (Exception var)
            {
                MessageBox.Show(var.Message);

            }
            con.Close();
            return false;
        }
    }
}
