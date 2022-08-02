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
    public partial class form_start : Form
    {
        public form_start()
        {
            InitializeComponent();
        }

        private void form_start_Load(object sender, EventArgs e)
        {

        }

        private void timer_progress_Tick(object sender, EventArgs e)
        {
            pnl_progress1.Width += 3;

            if(pnl_progress1.Width >= 599)
            {
                timer_progress.Stop();
                department_Form fm0 = new department_Form();

                fm0.Show();
                this.Hide();
            }
        }
    }
}
