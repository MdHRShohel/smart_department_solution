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
    public partial class Form_RBook_admin : Form
    {
        public Form_RBook_admin()
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
                    comboBox_intake_select_RBook.Items.Add(sName);

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

        private void comboBox_intake_select_RBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select * from intake where Intake_No = '" + comboBox_intake_select_RBook.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dt_reader;

            try
            {
                con.Open();
                dt_reader = cmd.ExecuteReader();

                while (dt_reader.Read())
                {
                    string intake_NO = dt_reader.GetString("Intake_No").ToString();

                    txt_insert_RBook_intake.Text = intake_NO;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btn_insert_RBook_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO reference_book(Intake_No, Sec, Course_ID, Book_Name, Author, Edition, Book_Link) VALUES(@intake, @Section,  @C_id, @Bname, @Aname, @editionn, @B_link)";
            cmd.Parameters.AddWithValue("@intake", txt_insert_RBook_intake.Text);
            cmd.Parameters.AddWithValue("@Section", txt_insert_section_RBook.Text);
            cmd.Parameters.AddWithValue("@C_id", txt_insert_course_id_RBook.Text);
            cmd.Parameters.AddWithValue("@Bname", txt_insert_Bname_RBook.Text);
            cmd.Parameters.AddWithValue("@Aname", txt_insert_Aname_RBook.Text);
            cmd.Parameters.AddWithValue("@editionn", txt_insert_editon_RBook.Text);
            cmd.Parameters.AddWithValue("@B_link", txt_insert_Blink_RBook.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data successfully inserted.");
            txt_insert_RBook_intake.Clear();
            txt_insert_section_RBook.Clear();
            txt_insert_course_id_RBook.Clear();
            txt_insert_Bname_RBook.Clear();
            txt_insert_Aname_RBook.Clear();
            txt_insert_editon_RBook.Clear();
            txt_insert_Blink_RBook.Clear();
        }

        private void Form_RBook_admin_Load(object sender, EventArgs e)
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
