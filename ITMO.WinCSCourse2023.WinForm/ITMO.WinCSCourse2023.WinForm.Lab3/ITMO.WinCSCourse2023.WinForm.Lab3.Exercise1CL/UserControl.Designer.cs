namespace ITMO.WinCSCourse2023.WinForm.Lab3.Exercise1CL
{
    partial class UserControl
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(385, 100);
            this.label.TabIndex = 0;
            this.label.Text = "label";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label);
            this.Name = "UserControl";
            this.Size = new System.Drawing.Size(385, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timer;
    }
}
