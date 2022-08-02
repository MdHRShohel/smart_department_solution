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
    public partial class Form_std_show_classlink : Form
    {
        string str;
        public Form_std_show_classlink(string Name)
        {
            InitializeComponent();
            str = Name;
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
                    comboBox_std_show_classlink_intake_select.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void Form_std_show_classlink_Load(object sender, EventArgs e)
        {

        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            Form_main fm2 = new Form_main();

            fm2.Show();
            MessageBox.Show("Successfully Log out");
            this.Hide();
        }

        private void btn_back_fm12_show_Click(object sender, EventArgs e)
        {
            string UName = str;
            Form_std_show fm24 = new Form_std_show(UName);
            fm24.Show();
            this.Hide();
        }

        private void comboBox_std_show_classlink_intake_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select intake.Intake_No, user_registration.Sec from intake, user_registration where intake.Intake_No = '" + comboBox_std_show_classlink_intake_select.Text + "' " +
                "and intake.Intake_No = user_registration.Intake_No and user_registration.Username = '"+ str +"'; ";
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

                    txt_std_show_classlink_intake.Text = intake_NO;
                    
                    txt_std_show_classlink_sec.Text = SEC;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetStudentsRecord()
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            try
            {
                //string UName = str;
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT class_link.Course_ID, Classroom_Code, Link FROM class_link natural join user_registration where user_registration.Sec = '" + txt_std_show_classlink_sec.Text + "'" +
                    "and user_registration.Username = '" + str + "' and user_registration.Intake_No = '" + txt_std_show_classlink_intake.Text + "' ;";


                MySqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
                dataGridView_std_show_classlink.DataSource = dt;
                //MessageBox.Show(txt_std_show_classlink_sec.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("You are input wrong Intake");
            }

        }

        private void bnt_std_show_classlink_go_Click(object sender, EventArgs e)
        {
            GetStudentsRecord();

        }

        private void dataGridView_std_show_classlink_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select Link from class_link";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                DataTable dt = dataGridView_std_show_classlink.DataSource as DataTable;
                if (dt != null)
                {
                    DataRow row = dt.Rows[e.RowIndex];
                    txt_std_show_classlink_selectlink.Text = row["Link"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void linkLbl_golink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(txt_std_show_classlink_selectlink.Text);
        }
    }
}
