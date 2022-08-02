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
    public partial class Form_user_reg : Form
    {
        public Form_user_reg()
        {
            InitializeComponent();
            Fill_Combo_Intake_Select();
        }
        void Fill_Combo_Intake_Select()
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select * from intake;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dt_reader;

            try
            {
                con.Open();
                dt_reader = cmd.ExecuteReader();

                while (dt_reader.Read())
                {
                    string sName = dt_reader.GetString("Intake_No");
                    comboBox_intake_select_user_reg.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void btn_back_fm20_Click(object sender, EventArgs e)
        {
            Form_std_main fm20 = new Form_std_main();
            fm20.Show();
            this.Hide();
        }

        private void Form_user_reg_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_intake_select_user_reg_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select * from intake where Intake_No = '" + comboBox_intake_select_user_reg.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dt_reader;

            try
            {
                con.Open();
                dt_reader = cmd.ExecuteReader();

                while (dt_reader.Read())
                {
                    string intake_NO = dt_reader.GetString("Intake_No").ToString();

                    txt_user_reg_intake.Text = intake_NO;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btn_user_reg_submit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            try
            {
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO user_registration(Name, Username, Intake_No, Sec, Email, Phone) VALUES(@StdName, @StdUserName, @Stdintake, @StdSec, @StdEmail, @StdPhone)";
                cmd.Parameters.AddWithValue("@StdName", txt_user_reg_name.Text);
                cmd.Parameters.AddWithValue("@StdUserName", txt_user_reg_username.Text);
                cmd.Parameters.AddWithValue("@Stdintake", txt_user_reg_intake.Text);
                cmd.Parameters.AddWithValue("@StdSec", txt_user_reg_sec.Text);
                cmd.Parameters.AddWithValue("@StdEmail", txt_user_reg_email.Text);
                cmd.Parameters.AddWithValue("@StdPhone", txt_user_reg_phone.Text);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO user_login(Username, Pass) VALUES(@StdUserNameL, @StdPass)";
                cmd.Parameters.AddWithValue("@StdUserNameL", txt_user_reg_username.Text);
                cmd.Parameters.AddWithValue("@StdPass", txt_user_reg_pass.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registration successful");
                
            }

            catch (Exception)
            {
                MessageBox.Show("Already Registrared");

            }
            txt_user_reg_name.Clear();
            txt_user_reg_username.Clear();
            txt_user_reg_intake.Clear();
            txt_user_reg_sec.Clear();
            txt_user_reg_email.Clear();
            txt_user_reg_phone.Clear();
            txt_user_reg_pass.Clear();
        }
    }
}
