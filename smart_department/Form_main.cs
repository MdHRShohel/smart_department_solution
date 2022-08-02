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

namespace smart_department
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void btn_admin_go_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());

            try
            {
                con.Open();
                MessageBox.Show("Admin must have login first with code and key");
                Admin_login_form fm3 = new Admin_login_form();
                fm3.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Wrong");
            }
        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }

        private void btn_student_go_Click(object sender, EventArgs e)
        {
            Form_std_main fm20 = new Form_std_main();
            fm20.Show();
            this.Hide();
            MessageBox.Show("If you not have an account, Please Click the \"REG. HERE\" button and Registration first. You must use the Student ID for Username.");
        }

        private void btn_back_fm0_Click(object sender, EventArgs e)
        {
            department_Form fm0 = new department_Form();

            fm0.Show();
            this.Hide();
        }
    }
}
