using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ITMO.WinCSCourse2023.WinForm.Lab2.Exercise8
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
                System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
                txt.Location = new System.Drawing.Point(80, 75);
                txt.Size = new System.Drawing.Size(160, 20);
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = "";
                //txt.KeyPress += new
                //System.Windows.Forms.KeyPressEventHandler(this.pin_KeyPress);
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

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                errorProvider.SetError(name, "Must be letter");
                e.Handled = true;
                MessageBox.Show("Поле Name не может содержать цифры");
            }
        }

        //private void pin_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("Поле PIN не может содержать буквы");
        //    }
        //}

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void pin_Validating(object sender, CancelEventArgs e)
        {
            if (pin.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(pin.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле PIN не может содержать буквы");
                }
            }
        }
    }
}
