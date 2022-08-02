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
    public partial class Form_std_show_RBook : Form
    {
        string str;
        public Form_std_show_RBook(string UName)
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
                    comboBox_std_show_RBook_intake.Items.Add(sName);

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

        private void comboBox_std_show_RBook_intake_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select intake.Intake_No, user_registration.Sec from intake, user_registration where intake.Intake_No = '" + comboBox_std_show_RBook_intake.Text + "' " +
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

                    txt_std_show_RBook_intake.Text = intake_NO;

                    txt_std_show_RBook_sec.Text = SEC;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetRBookRecord()
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            try
            {
             
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT reference_book.Course_ID, Book_Name, Author, Edition, Book_Link FROM reference_book natural join user_registration where user_registration.Sec = '" + txt_std_show_RBook_sec.Text + "'" +
                    "and user_registration.Username = '" + str + "' and user_registration.Intake_No = '" + txt_std_show_RBook_intake.Text + "' ;";


                MySqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
                dataGridView_std_show_RBook.DataSource = dt;
                
            }
            catch (Exception)
            {
                MessageBox.Show("You are input wrong Intake");
            }

        }

        private void bnt_std_show_RBook_go_Click(object sender, EventArgs e)
        {
            GetRBookRecord();
        }

        private void dataGridView_std_show_RBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select Book_Link from reference_book";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                DataTable dt = dataGridView_std_show_RBook.DataSource as DataTable;
                if (dt != null)
                {
                    DataRow row = dt.Rows[e.RowIndex];
                    txt_std_show_RBook_selectlink.Text = row["Book_Link"].ToString();
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
            System.Diagnostics.Process.Start(txt_std_show_RBook_selectlink.Text);
        }

        private void Form_std_show_RBook_Load(object sender, EventArgs e)
        {

        }
    }
}
