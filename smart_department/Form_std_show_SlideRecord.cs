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
    public partial class Form_std_show_SlideRecord : Form
    {
        string str;
        public Form_std_show_SlideRecord(string UName)
        {
            InitializeComponent();
            str = UName;
            Fill_Combo_Intake_Select();
        }
        void Fill_Combo_Intake_Select()
        {

            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select intake.Intake_No from intake, user_registration where intake.Intake_No = user_registration.Intake_No and user_registration.Username = '" + str + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dt_reader;

            try
            {
                con.Open();
                dt_reader = cmd.ExecuteReader();

                while (dt_reader.Read())
                {
                    string sName = dt_reader.GetString("Intake_No");
                    comboBox_intake_select_SlideRecord_std_show.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void btn_back_fm24_show_Click(object sender, EventArgs e)
        {
            Form_std_show fm24 = new Form_std_show(str);
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

        private void comboBox_intake_select_SlideRecord_std_show_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select intake.Intake_No, user_registration.Sec from intake, user_registration where intake.Intake_No = '" + comboBox_intake_select_SlideRecord_std_show.Text + "' " +
                "and intake.Intake_No = user_registration.Intake_No and user_registration.Username = '" + str + "'; ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dt_reader;

            try
            {
                con.Open();
                dt_reader = cmd.ExecuteReader();

                while (dt_reader.Read())
                {
                    string intake_NO = dt_reader.GetString("Intake_No").ToString();
                    string SEC = dt_reader.GetString("Sec").ToString();

                    txt_std_show_SlideRecord_intake.Text = intake_NO;

                    txt_std_show_SlideRecord_sec.Text = SEC;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetSlideRecord()
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            try
            {

                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT slide_and_record.Course_ID, Slide_Link, Record_Video FROM slide_and_record natural join user_registration where user_registration.Sec = '" + txt_std_show_SlideRecord_sec.Text + "'" +
                    "and user_registration.Username = '" + str + "' and user_registration.Intake_No = '" + txt_std_show_SlideRecord_intake.Text + "' and Record_Date = '" + txt_std_show_SlideRecord_date.Text + "';";


                MySqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
                dataGridView_SlideRecord_std_show.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("You are input wrong Intake");
            }

        }
        private void dateTimePicker_SlideRecord_std_show_ValueChanged(object sender, EventArgs e)
        {
            txt_std_show_SlideRecord_date.Text = dateTimePicker_SlideRecord_std_show.Text;
        }

        private void bnt_std_show_SlideRecord_go_Click(object sender, EventArgs e)
        {
            GetSlideRecord();
        }

        private void dataGridView_SlideRecord_std_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select Slide_Link, Record_Video from slide_and_record";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                DataTable dt = dataGridView_SlideRecord_std_show.DataSource as DataTable;
                if (dt != null)
                {
                    DataRow row = dt.Rows[e.RowIndex];

                    txt_std_show_RBook_selectlink_s.Text = row["Slide_Link"].ToString();
                    txt_std_show_RBook_selectlink_r.Text = row["Record_Video"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void linkLbl_golink_s_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(txt_std_show_RBook_selectlink_s.Text);
        }

        private void linkLbl_golink_r_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(txt_std_show_RBook_selectlink_r.Text);
        }
    }
}
