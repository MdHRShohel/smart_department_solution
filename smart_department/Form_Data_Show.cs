using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smart_department
{
    public partial class Form_Data_Show : Form
    {
        public Form_Data_Show()
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

        private void btn_back_fm4_Click(object sender, EventArgs e)
        {
            Admin_Login_After_form1 fm4 = new Admin_Login_After_form1();
            fm4.Show();
            this.Hide();
        }

        private void btn_basic_show_data_Click(object sender, EventArgs e)
        {
            Form_admin_basic_show fm13 = new Form_admin_basic_show();
            fm13.Show();
            this.Hide();
        }

        private void btn_classlink_show_data_Click(object sender, EventArgs e)
        {
            Form_admin_classlink_show fm14 = new Form_admin_classlink_show();
            fm14.Show();
            this.Hide();
        }

        private void btn_RBook_show_data_Click(object sender, EventArgs e)
        {
            Form_admin_RBook_show fm15 = new Form_admin_RBook_show();
            fm15.Show();
            this.Hide();
        }

        private void btn_Slide_Record_show_data_Click(object sender, EventArgs e)
        {
            Form_admin_SlideRecord_show fm16 = new Form_admin_SlideRecord_show();
            fm16.Show();
            this.Hide();
        }

        private void btn_routine_show_data_Click(object sender, EventArgs e)
        {
            Form_admin_routine_show fm17 = new Form_admin_routine_show();
            fm17.Show();
            this.Hide();
        }

        private void btn_notice_show_data_Click(object sender, EventArgs e)
        {
            Form_admin_notice_show fm18 = new Form_admin_notice_show();
            fm18.Show();
            this.Hide();
        }

        private void Form_Data_Show_Load(object sender, EventArgs e)
        {

        }
    }
}
