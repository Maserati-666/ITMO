namespace ITMO.WinCSCourse2023.WinForm.Lab2.Exercise8
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.TextBox();
            this.chbAdvancedFeatures = new System.Windows.Forms.CheckBox();
            this.butRegistration = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите тип регистрации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите регистрационные данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PIN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(80, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(161, 20);
            this.name.TabIndex = 4;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // pin
            // 
            this.pin.Location = new System.Drawing.Point(80, 37);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(161, 20);
            this.pin.TabIndex = 5;
            this.pin.Validating += new System.ComponentModel.CancelEventHandler(this.pin_Validating);
            // 
            // chbAdvancedFeatures
            // 
            this.chbAdvancedFeatures.AutoSize = true;
            this.chbAdvancedFeatures.Location = new System.Drawing.Point(199, 178);
            this.chbAdvancedFeatures.Name = "chbAdvancedFeatures";
            this.chbAdvancedFeatures.Size = new System.Drawing.Size(169, 17);
            this.chbAdvancedFeatures.TabIndex = 6;
            this.chbAdvancedFeatures.Text = "Расширенные возможности";
            this.chbAdvancedFeatures.UseVisualStyleBackColor = true;
            this.chbAdvancedFeatures.CheckedChanged += new System.EventHandler(this.chbAdvancedFeatures_CheckedChanged);
            // 
            // butRegistration
            // 
            this.butRegistration.Location = new System.Drawing.Point(98, 225);
            this.butRegistration.Name = "butRegistration";
            this.butRegistration.Size = new System.Drawing.Size(111, 30);
            this.butRegistration.TabIndex = 7;
            this.butRegistration.Text = "Регистрация";
            this.butRegistration.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pin);
            this.groupBox.Controls.Add(this.name);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Location = new System.Drawing.Point(57, 54);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(310, 115);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(380, 267);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.butRegistration);
            this.Controls.Add(this.chbAdvancedFeatures);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.CheckBox chbAdvancedFeatures;
        private System.Windows.Forms.Button butRegistration;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

