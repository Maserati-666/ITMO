using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinCSCourse2023.WinForm.Lab3.Exercise1
{
    public partial class WinTimer : Form
    {
        public WinTimer()
        {
            InitializeComponent();
        }

        private void StartStop_Click(object sender, EventArgs e)
        {
            if (userControlTimer.TimeEnabled == true)
                userControlTimer.TimeEnabled = false;
            else
                userControlTimer.TimeEnabled = true;
        }
    }
}
