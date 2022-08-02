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
    public partial class Form_notice_admin : Form
    {
        public Form_notice_admin()
        {
            InitializeComponent();
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

        private void dateTimePicker_notice_ValueChanged(object sender, EventArgs e)
        {
            txt_insert_notice_date.Text = dateTimePicker_notice.Text;
        }

        private void btn_insert_img_choose_Notice_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_insert_notice.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btn_insert_Notice_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox_insert_notice.Image.Save(ms, pictureBox_insert_notice.Image.RawFormat);
                byte[] img = ms.ToArray();

                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO all_notice(Notice_Date, Type, Notice) VALUES(@date, @Ntype, @ANotice)";
                cmd.Parameters.AddWithValue("@date", txt_insert_notice_date.Text);
                cmd.Parameters.AddWithValue("@Ntype", comboBox_insert_notice_Ntype.Text);
                cmd.Parameters.AddWithValue("@ANotice", img);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data successfully inserted.");

                txt_insert_notice_date.Clear();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
