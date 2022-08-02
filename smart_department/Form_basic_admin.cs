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
    public partial class Form_basic_admin : Form
    {
        public Form_basic_admin()
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
                    comboBox_intake_select.Items.Add(sName);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void btn_insert_basic_intake_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO intake(Intake_No) VALUES(@inatake_NO)";
            cmd.Parameters.AddWithValue("@inatake_NO", txt_insert_basic_intake.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data successfully inserted.");
            txt_insert_basic_intake.Clear();

            comboBox_intake_select.Items.Clear();
            Fill_Combo_Intake_Select();

        }

        private void btn_insert_basic_course_id_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO courses(Intake_No, Course_ID, Course_Name) VALUES(@intake, @C_id, @C_name)";
            cmd.Parameters.AddWithValue("@intake", txt_insert_basic_intake2.Text);
            cmd.Parameters.AddWithValue("@C_id", txt_insert_basic_course_id.Text);
            cmd.Parameters.AddWithValue("@C_name", txt_insert_basic_course_name.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data successfully inserted.");
            txt_insert_basic_intake2.Clear();
            txt_insert_basic_course_id.Clear();
            txt_insert_basic_course_name.Clear();

            comboBox_intake_select.Items.Clear();
            Fill_Combo_Intake_Select();
            

        }

        private void btn_back_fm5_Click(object sender, EventArgs e)
        {
            Form_Data_Insert fm5 = new Form_Data_Insert();
            fm5.Show();
            this.Hide();
        }

        private void comboBox_intake_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select * from intake where Intake_No = '"+comboBox_intake_select.Text+"';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dt_reader;

            try
            {
                con.Open();
                dt_reader = cmd.ExecuteReader();

                while (dt_reader.Read())
                {
                    string intake_NO = dt_reader.GetString("Intake_No").ToString();

                    txt_insert_basic_intake2.Text = intake_NO;
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void Form_basic_admin_Load(object sender, EventArgs e)
        {

        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            Form_main fm2 = new Form_main();
            fm2.Show();
            MessageBox.Show("Successfully Log out");
            this.Hide();
        }
    }
}
