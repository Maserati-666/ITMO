using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinCSCourse2023.WinForm.Lab3.Exercise1
{
    public partial class UserControlTimer : UserControl
    {
        public UserControlTimer()
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
