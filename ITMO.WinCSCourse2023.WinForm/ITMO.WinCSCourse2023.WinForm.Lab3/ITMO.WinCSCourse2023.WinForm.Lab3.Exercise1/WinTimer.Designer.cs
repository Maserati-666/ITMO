namespace ITMO.WinCSCourse2023.WinForm.Lab3.Exercise1
{
    partial class WinTimer
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControlTimer = new ITMO.WinCSCourse2023.WinForm.Lab3.Exercise1.UserControlTimer();
            this.StartStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControlTimer
            // 
            this.userControlTimer.Font = new System.Drawing.Font("Algerian", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlTimer.Location = new System.Drawing.Point(2, 2);
            this.userControlTimer.Margin = new System.Windows.Forms.Padding(0);
            this.userControlTimer.Name = "userControlTimer";
            this.userControlTimer.Size = new System.Drawing.Size(535, 138);
            this.userControlTimer.TabIndex = 0;
            this.userControlTimer.TimeEnabled = true;
            // 
            // StartStop
            // 
            this.StartStop.Font = new System.Drawing.Font("Swis721 Blk BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStop.Location = new System.Drawing.Point(158, 164);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(249, 70);
            this.StartStop.TabIndex = 1;
            this.StartStop.Text = "Start/Stop";
            this.StartStop.UseVisualStyleBackColor = true;
            this.StartStop.Click += new System.EventHandler(this.StartStop_Click);
            // 
            // WinTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 246);
            this.Controls.Add(this.StartStop);
            this.Controls.Add(this.userControlTimer);
            this.Name = "WinTimer";
            this.Text = "WinTimer";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlTimer userControlTimer;
        private System.Windows.Forms.Button StartStop;
    }
}

