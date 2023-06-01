namespace ITMO.WinCSCourse2023.WinForm.Lab1.Exercise5e2
{
    partial class Second_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseForm
            // 
            this.CloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseForm.Location = new System.Drawing.Point(331, 197);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(138, 57);
            this.CloseForm.TabIndex = 0;
            this.CloseForm.Text = "GREENPEACE";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // Second_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Second_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Second_Form";
            this.Load += new System.EventHandler(this.Second_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseForm;
    }
}