using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ITMO.WinCSCourse2023.WinForm.Lab2.Exercise7
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void chbAdvancedFeatures_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAdvancedFeatures.Checked == true)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(16, 80);
                lbl.Size = new System.Drawing.Size(32, 23);
                lbl.Name = "labelll";
                lbl.TabIndex = 2;
                lbl.Text = "PIN2";
                groupBox.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(80, 75);
                txt.Size = new System.Drawing.Size(160, 20);
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = "";
                groupBox.Controls.Add(txt);
            }
            else
            {
                int lcv;
                lcv = groupBox.Controls.Count;// определяется количество элементов 
                while (lcv > 4)
                {
                    groupBox.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
