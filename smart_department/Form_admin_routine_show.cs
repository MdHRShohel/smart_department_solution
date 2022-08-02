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
    public partial class Form_admin_routine_show : Form
    {
        public Form_admin_routine_show()
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
                    comboBox_intake_select_routine.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
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
            Form_Data_Show fm12 = new Form_Data_Show();
            fm12.Show();
            this.Hide();
        }

        private void Form_admin_routine_show_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_intake_select_routine_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select * from intake where Intake_No = '" + comboBox_intake_select_routine.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dt_reader;

            try
            {
                con.Open();
                dt_reader = cmd.ExecuteReader();

                while (dt_reader.Read())
                {
                    string intake_NO = dt_reader.GetString("Intake_No").ToString();

                    txt_show_routine_intake.Text = intake_NO;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void bnt_show_routine_go_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select Routine from all_routine where Intake_No = '" + comboBox_intake_select_routine.Text + "' and Sec = '" + txt_show_routine_sec.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            
            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);

                byte[] img = (byte[])table.Rows[0]["Routine"];

                MemoryStream ms = new MemoryStream(img);
                
                pictureBox_show_routine.Image = Image.FromStream(ms);
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
