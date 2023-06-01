using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace ITMO.WinCSCourse2023.WinForm.Lab3.Exercise1CL
{
    public partial class UserControl: System.Windows.Forms.UserControl
    {
        public UserControl()
        {
            InitializeComponent();
        }

        public bool TimeEnabled
        {
            get { return timer.Enabled; }
            set { timer.Enabled = value; }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
