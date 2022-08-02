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
    public partial class department_Form : Form
    {
        public department_Form()
        {
            InitializeComponent();
        }

        private void btn_cse_Click(object sender, EventArgs e)
        {
            Form_main fm2 = new Form_main();

            fm2.Show();
            this.Hide();
        }

        private void department_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
