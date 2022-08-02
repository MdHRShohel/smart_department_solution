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
    public partial class Form_class_link_admin : Form
    {
        public Form_class_link_admin()
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
                    comboBox_intake_select_classlink.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void btn_back_fm5_Click(object sender, EventArgs e)
        {
            Form_Data_Insert fm5 = new Form_Data_Insert();
            fm5.Show();
            this.Hide();
        }

        private void Form_class_link_admin_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_intake_select_classlink_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select * from intake where Intake_No = '" + comboBox_intake_select_classlink.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dt_reader;

            try
            {
                con.Open();
                dt_reader = cmd.ExecuteReader();

                while (dt_reader.Read())
                {
                    string intake_NO = dt_reader.GetString("Intake_No").ToString();

                    txt_insert_classlink_intake.Text = intake_NO;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btn_insert_classlink_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO class_link(Intake_No, Sec, Course_ID, Classroom_Code, Link) VALUES(@intake, @Section,  @C_id, @C_code, @Cl_link)";
            cmd.Parameters.AddWithValue("@intake", txt_insert_classlink_intake.Text);
            cmd.Parameters.AddWithValue("@Section", txt_insert_section_classlink.Text);
            cmd.Parameters.AddWithValue("@C_id", txt_insert_course_id_classlink.Text);
            cmd.Parameters.AddWithValue("@C_code", txt_insert_classCode_classlink.Text);
            cmd.Parameters.AddWithValue("@Cl_link", txt_insert_link_classlink.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data successfully inserted.");
            txt_insert_classlink_intake.Clear();
            txt_insert_section_classlink.Clear();
            txt_insert_course_id_classlink.Clear();
            txt_insert_classCode_classlink.Clear();
            txt_insert_link_classlink.Clear();

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
