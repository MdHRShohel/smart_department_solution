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
using System.Data.SqlClient;

namespace smart_department
{
    public partial class Form_std_main : Form
    {
        public Form_std_main()
        {
            InitializeComponent();
        }

        private void btn_back_fm2_Click(object sender, EventArgs e)
        {
            Form_main fm2 = new Form_main();

            fm2.Show();
            this.Hide();
        }

        private void btn_user_reg_Click(object sender, EventArgs e)
        {
            Form_user_reg fm21 = new Form_user_reg();
            fm21.Show();
            this.Hide();
        }

        private void btn_user_login_Click(object sender, EventArgs e)
        {
            string userName = txt_user_reg_username.Text;
            string UPass = txt_user_reg_pass.Text;

            string user_check_query = "select count(user_login.Username) as Total_count from user_login where user_login.Username = '" + userName + "' and user_login.Pass = '" + UPass + "'";

            if (isLogin(user_check_query) == true)
            {
                MessageBox.Show("Successfully Log in");
                this.Hide();

                Form_std_show fm23 = new Form_std_show(userName);
                fm23.Show();

                

            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
                txt_user_reg_username.Clear();
                txt_user_reg_pass.Clear();
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

                while (dt_reader.Read())
                {

                }
                if (Convert.ToInt32(dt_reader.GetString("Total_count")) == 1)
                {
                    con.Close();
                    return true;
                }
            }
            catch (Exception excption)
            {
                MessageBox.Show(excption.Message);
            }

            con.Close();
            return false;
        }

        private void Form_std_main_Load(object sender, EventArgs e)
        {

        }
    }
}
