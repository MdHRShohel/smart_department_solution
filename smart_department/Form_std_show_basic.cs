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
    public partial class Form_std_show_basic : Form
    {
        string str;
        public Form_std_show_basic(string userName)
        {
            InitializeComponent();
            
            str = userName;
            Fill_Combo_Intake_Select();


        }
        void Fill_Combo_Intake_Select()
        {
            string UName = str;
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select intake.Intake_No from intake, user_registration where intake.Intake_No = user_registration.Intake_No and user_registration.Username = '" + UName + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dt_reader;

            try
            {
                con.Open();
                dt_reader = cmd.ExecuteReader();

                while (dt_reader.Read())
                {
                    string sName = dt_reader.GetString("Intake_No");
                    comboBox_std_show_intake_select_basic.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void btn_back_fm24_Click(object sender, EventArgs e)
        {
            string UName = str;
            Form_std_show fm24 = new Form_std_show(UName);
            fm24.Show();
            this.Hide();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            Form_main fm2 = new Form_main();

            fm2.Show();
            MessageBox.Show("Successfully Log out");
            this.Hide();
        }

        private void Form_std_show_basic_Load(object sender, EventArgs e)
        {

        }

        private void txt_std_show_intake_basic_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void GetStudentsRecord()
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            try
            {
                string UName = str;
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT Course_ID, Course_Name FROM courses, user_registration where courses.Intake_No = user_registration.Intake_No and user_registration.Username = '"+ UName + "' and user_registration.Intake_No = '" + txt_std_show_intake_basic.Text + "';";
                
                
                MySqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
                dataGridView_std_show_basic.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("You are input wrong Intake");
            }
            
        }
        private void bnt_std_show_basic_go_Click(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }

        private void comboBox_std_show_intake_select_basic_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select * from intake where Intake_No = '" + comboBox_std_show_intake_select_basic.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dt_reader;

            try
            {
                con.Open();
                dt_reader = cmd.ExecuteReader();

                while (dt_reader.Read())
                {
                    string intake_NO = dt_reader.GetString("Intake_No").ToString();

                    txt_std_show_intake_basic.Text = intake_NO;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
