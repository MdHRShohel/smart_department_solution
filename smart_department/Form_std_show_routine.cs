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
using System.IO;

namespace smart_department
{
    
    public partial class Form_std_show_routine : Form
    {
        string str;
        public Form_std_show_routine(string UName)
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
                    comboBox_intake_select_routine_std_show.Items.Add(sName);

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

        private void Form_std_show_routine_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_intake_select_routine_std_show_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select intake.Intake_No, user_registration.Sec from intake, user_registration where intake.Intake_No = '" + comboBox_intake_select_routine_std_show.Text + "' " +
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

                    txt_std_show_routine_intake.Text = intake_NO;

                    txt_std_show_routine_sec.Text = SEC;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bnt_std_show_routine_go_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select Routine from all_routine where Intake_No = '" + comboBox_intake_select_routine_std_show.Text + "' and Sec = '" + txt_std_show_routine_sec.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);

                byte[] img = (byte[])table.Rows[0]["Routine"];

                MemoryStream ms = new MemoryStream(img);

                pictureBox_std_show_routine.Image = Image.FromStream(ms);
                da.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
