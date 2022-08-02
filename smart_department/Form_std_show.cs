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
    public partial class Form_std_show : Form
    {
        string str;
        public Form_std_show(string Name)
        {
            InitializeComponent();
            str = Name;
            

        }
      
        private void btn_std_show_basic_Click(object sender, EventArgs e)
        {
            
            Form_std_show_basic fm24 = new Form_std_show_basic(str);
            fm24.Show();
            this.Hide();
        }

        private void btn_std_log_out_Click(object sender, EventArgs e)
        {
            Form_main fm2 = new Form_main();

            fm2.Show();
            MessageBox.Show("Successfully Log out");
            this.Hide();
        }

        private void Form_std_show_Load(object sender, EventArgs e)
        {

        }

        private void btn_std_show_classlink_Click(object sender, EventArgs e)
        {
            Form_std_show_classlink fm25 = new Form_std_show_classlink(str);
            fm25.Show();
            this.Hide();
        }

        private void btn_std_show_RBook_Click(object sender, EventArgs e)
        {
            Form_std_show_RBook fm26 = new Form_std_show_RBook(str);
            fm26.Show();
            this.Hide();
        }

        private void btn_std_show_Slide_Record_Click(object sender, EventArgs e)
        {
            Form_std_show_SlideRecord fm27 = new Form_std_show_SlideRecord(str);
            fm27.Show();
            this.Hide();
        }

        private void btn_std_show_routine_Click(object sender, EventArgs e)
        {
            Form_std_show_routine fm28 = new Form_std_show_routine(str);
            fm28.Show();
            this.Hide();
        }

        private void btn_std_show_notice_Click(object sender, EventArgs e)
        {
            Form_std_show_notice fm29 = new Form_std_show_notice(str);
            fm29.Show();
            this.Hide();
        }
    }
}
