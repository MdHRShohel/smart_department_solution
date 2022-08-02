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
    public partial class Form_Data_Insert : Form
    {
        public Form_Data_Insert()
        {
            InitializeComponent();
        }

        private void btn_basic_Click(object sender, EventArgs e)
        {
            

            Form_basic_admin fm6 = new Form_basic_admin();
            fm6.Show();
            this.Hide();

        }

        

        private void btn_classlink_Click(object sender, EventArgs e)
        {
            Form_class_link_admin fm7 = new Form_class_link_admin();
            fm7.Show();
            this.Hide();
        }

        private void btn_RBook_Click(object sender, EventArgs e)
        {
            Form_RBook_admin fm8 = new Form_RBook_admin();
            fm8.Show();
            this.Hide();
        }

        

        private void btn_Slide_Record_Click(object sender, EventArgs e)
        {
            Form_Slide_Record_admin fm9 = new Form_Slide_Record_admin();
            fm9.Show();
            this.Hide();
        }

        private void btn_back_fm4_Click(object sender, EventArgs e)
        {
            Admin_Login_After_form1 fm4 = new Admin_Login_After_form1();
            fm4.Show();
            this.Hide();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            Form_main fm2 = new Form_main();

            fm2.Show();
            MessageBox.Show("Successfully Log out");
            this.Hide();
        }

        private void btn_routine_Click(object sender, EventArgs e)
        {
            Form_routine_admin fm10 = new Form_routine_admin();
            fm10.Show();
            this.Hide();
        }

        private void btn_notice_Click(object sender, EventArgs e)
        {
            Form_notice_admin fm11 = new Form_notice_admin();
            fm11.Show();
            this.Hide();
        }
    }
}
