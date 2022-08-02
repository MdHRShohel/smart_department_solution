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

namespace smart_department
{
    public partial class Admin_login_form : Form
    {
        public Admin_login_form()
        {
            InitializeComponent();
        }

        private void btn_Admin_login_Click(object sender, EventArgs e)
        {
            string adminCode = txt_admin_code.Text;
            string adminKye = txt_Admin_Kye.Text;

            string admin_check_query = "select count(admin_login.Admin_Code) as Total_count from admin_login where admin_login.Admin_Code = '" + adminCode + "' and admin_login.Kye = '" + adminKye + "'";

            if(isLogin(admin_check_query) == true)
            {
                MessageBox.Show("Successfully Log in");
                this.Hide();

                Admin_Login_After_form1 fm4 = new Admin_Login_After_form1();
                fm4.Show();
            }
            else
            {
                MessageBox.Show("Wrong Code or Kye");
                txt_admin_code.Clear();
                txt_Admin_Kye.Clear();
            }

        }
        private bool isLogin(String admin_check_query)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(admin_check_query, con);
                MySqlDataReader dt_reader = cmd.ExecuteReader();

                while(dt_reader.Read()){

                }
                if(Convert.ToInt32(dt_reader.GetString("Total_count"))== 1)
                {
                    con.Close();
                    return true;
                }
            }
            catch(Exception excption)
            {
                MessageBox.Show(excption.Message);
            }

            con.Close();
            return false;
        }

        private void Admin_login_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_fm2_Click(object sender, EventArgs e)
        {
            Form_main fm2 = new Form_main();

            fm2.Show();
            this.Hide();
        }
    }
}
