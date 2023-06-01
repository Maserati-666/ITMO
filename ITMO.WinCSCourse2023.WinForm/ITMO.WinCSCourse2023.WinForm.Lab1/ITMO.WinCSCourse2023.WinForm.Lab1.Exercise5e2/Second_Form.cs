using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ITMO.WinCSCourse2023.WinForm.Lab1.Exercise5e2
{
    public partial class Second_Form : Form
    {
        public Second_Form()
        {
            InitializeComponent();
        }

        private void Second_Form_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath rhomb = new System.Drawing.Drawing2D.GraphicsPath();
            rhomb.AddPolygon(new Point[] { new Point(0, this.Height / 2), new Point(this.Width / 2, 0), new Point(this.Width, this.Height / 2), new Point(this.Width / 2, this.Height) });
            Region myRegion = new Region(rhomb);
            this.Region = myRegion;
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
