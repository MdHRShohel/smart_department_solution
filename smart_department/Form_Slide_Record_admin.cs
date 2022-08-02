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
    public partial class Form_Slide_Record_admin : Form
    {
        public Form_Slide_Record_admin()
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
                    comboBox_intake_select_Slide_Record.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void Form_Slide_Record_admin_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_intake_select_Slide_Record_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select * from intake where Intake_No = '" + comboBox_intake_select_Slide_Record.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dt_reader;

            try
            {
                con.Open();
                dt_reader = cmd.ExecuteReader();

                while (dt_reader.Read())
                {
                    string intake_NO = dt_reader.GetString("Intake_No").ToString();

                    txt_insert_Slide_Record_intake.Text = intake_NO;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void txt_insert_Slide_Record_intake_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_Slide_Record_ValueChanged(object sender, EventArgs e)
        {
            txt_insert_date_Slide_Record.Text = dateTimePicker_Slide_Record.Text;
        }

        private void btn_insert_Slide_Record_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();

            

            cmd.CommandText = "INSERT INTO slide_and_record(Intake_No, Sec, Record_Date, Course_ID, Slide_Link, Record_Video) VALUES(@intake, @Section, @R_date, @C_id, @S_link, @R_vdo)";
            cmd.Parameters.AddWithValue("@intake", txt_insert_Slide_Record_intake.Text);
            cmd.Parameters.AddWithValue("@Section", txt_insert_section_Slide_Record.Text);
            cmd.Parameters.AddWithValue("@R_date", txt_insert_date_Slide_Record.Text);
            cmd.Parameters.AddWithValue("@C_id", txt_insert_course_id_Slide_Record.Text);
            cmd.Parameters.AddWithValue("@S_link", txt_insert_slidelink_Slide_Record.Text);
            cmd.Parameters.AddWithValue("@R_vdo", txt_insert_recordlink_Slide_Record.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data successfully inserted.");
            txt_insert_Slide_Record_intake.Clear();
            txt_insert_section_Slide_Record.Clear();
            txt_insert_date_Slide_Record.Clear();
            txt_insert_course_id_Slide_Record.Clear();
            txt_insert_slidelink_Slide_Record.Clear();
            txt_insert_recordlink_Slide_Record.Clear();
            
        }

        private void btn_back_fm5_Click(object sender, EventArgs e)
        {
            Form_Data_Insert fm5 = new Form_Data_Insert();
            fm5.Show();
            this.Hide();
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
