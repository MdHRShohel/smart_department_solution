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
    public partial class Form_routine_admin : Form
    {
        public Form_routine_admin()
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

        private void btn_back_fm5_Click(object sender, EventArgs e)
        {
            Form_Data_Insert fm5 = new Form_Data_Insert();
            fm5.Show();
            this.Hide();
        }

        private void Form_routine_admin_Load(object sender, EventArgs e)
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

                    txt_insert_routine_intake.Text = intake_NO;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btn_insert_img_choose_Routine_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_insert_routine.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btn_insert_Routine_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox_insert_routine.Image.Save(ms, pictureBox_insert_routine.Image.RawFormat);
                byte[] img = ms.ToArray();

                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO all_routine(Intake_No, Sec, Routine) VALUES(@intake, @section, @Croutine)";
                cmd.Parameters.AddWithValue("@intake", txt_insert_routine_intake.Text);
                cmd.Parameters.AddWithValue("@section", txt_insert_routine_sec.Text);
                cmd.Parameters.AddWithValue("@Croutine", img);

                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Data successfully inserted.");

                txt_insert_routine_intake.Clear();
                txt_insert_routine_sec.Clear();
              
                comboBox_intake_select_routine.Items.Clear();
                Fill_Combo_Intake_Select();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
