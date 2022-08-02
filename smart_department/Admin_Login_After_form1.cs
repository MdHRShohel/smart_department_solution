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
    public partial class Admin_Login_After_form1 : Form
    {
        public Admin_Login_After_form1()
        {
            InitializeComponent();
        }

        private void btn_data_insert_Click(object sender, EventArgs e)
        {
            Form_Data_Insert fm5 = new Form_Data_Insert();
            fm5.Show();
            this.Hide();
        }

        private void Admin_Login_After_form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            Form_main fm2 = new Form_main();
            
            fm2.Show();
            MessageBox.Show("Successfully Log out");
            this.Hide();
        }

        private void btn_data_show_Click(object sender, EventArgs e)
        {
            Form_Data_Show fm12 = new Form_Data_Show();
            fm12.Show();
            this.Hide();
        }
    }
}
