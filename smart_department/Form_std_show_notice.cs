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
    public partial class Form_std_show_notice : Form
    {
        string str;
        public Form_std_show_notice(string UName)
        {
            InitializeComponent();
            str = UName;
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
        private void GetNoticeRecord()
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM all_notice";

            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            con.Close();
            dataGridView_std_show_notice.DataSource = dt;
        }

        public Image ConvertByteArraytoImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void dataGridView_std_show_notice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            string query = "select Notice from all_notice";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                DataTable dt = dataGridView_std_show_notice.DataSource as DataTable;
                if (dt != null)
                {
                    DataRow row = dt.Rows[e.RowIndex];
                    pictureBox_std_show_notice.Image = ConvertByteArraytoImage((byte[])row["Notice"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void Form_std_show_notice_Load(object sender, EventArgs e)
        {
            GetNoticeRecord();
        }
    }
}
