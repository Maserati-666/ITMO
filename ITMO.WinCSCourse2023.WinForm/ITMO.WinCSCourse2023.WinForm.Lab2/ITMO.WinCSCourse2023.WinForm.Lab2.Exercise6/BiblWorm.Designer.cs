namespace ITMO.WinCSCourse2023.WinForm.Lab2.Exercise6
{
    partial class BiblWorm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.books = new System.Windows.Forms.TabPage();
            this.pPeriodUse = new System.Windows.Forms.NumericUpDown();
            this.periodUse = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pReturnTime = new System.Windows.Forms.CheckBox();
            this.pExistence = new System.Windows.Forms.CheckBox();
            this.pInvNumber = new System.Windows.Forms.NumericUpDown();
            this.pYear = new System.Windows.Forms.NumericUpDown();
            this.pPage = new System.Windows.Forms.NumericUpDown();
            this.invNumber = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.page = new System.Windows.Forms.Label();
            this.publishHouse = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.pPublishHouse = new System.Windows.Forms.TextBox();
            this.pTitle = new System.Windows.Forms.TextBox();
            this.pAuthor = new System.Windows.Forms.TextBox();
            this.magazines = new System.Windows.Forms.TabPage();
            this.textWindow = new System.Windows.Forms.RichTextBox();
            this.pSortInvNumber = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPeriodUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pInvNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.books);
            this.tabControl1.Controls.Add(this.magazines);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(287, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // books
            // 
            this.books.BackColor = System.Drawing.Color.Gainsboro;
            this.books.Controls.Add(this.pPeriodUse);
            this.books.Controls.Add(this.periodUse);
            this.books.Controls.Add(this.button1);
            this.books.Controls.Add(this.pReturnTime);
            this.books.Controls.Add(this.pExistence);
            this.books.Controls.Add(this.pInvNumber);
            this.books.Controls.Add(this.pYear);
            this.books.Controls.Add(this.pPage);
            this.books.Controls.Add(this.invNumber);
            this.books.Controls.Add(this.year);
            this.books.Controls.Add(this.page);
            this.books.Controls.Add(this.publishHouse);
            this.books.Controls.Add(this.title);
            this.books.Controls.Add(this.author);
            this.books.Controls.Add(this.pPublishHouse);
            this.books.Controls.Add(this.pTitle);
            this.books.Controls.Add(this.pAuthor);
            this.books.Location = new System.Drawing.Point(4, 22);
            this.books.Name = "books";
            this.books.Padding = new System.Windows.Forms.Padding(3);
            this.books.Size = new System.Drawing.Size(279, 386);
            this.books.TabIndex = 0;
            this.books.Text = "Книги";
            this.books.Click += new System.EventHandler(this.books_Click);
            // 
            // pPeriodUse
            // 
            this.pPeriodUse.Location = new System.Drawing.Point(129, 271);
            this.pPeriodUse.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.pPeriodUse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pPeriodUse.Name = "pPeriodUse";
            this.pPeriodUse.Size = new System.Drawing.Size(125, 20);
            this.pPeriodUse.TabIndex = 16;
            this.pPeriodUse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // periodUse
            // 
            this.periodUse.AutoSize = true;
            this.periodUse.Location = new System.Drawing.Point(8, 278);
            this.periodUse.Name = "periodUse";
            this.periodUse.Size = new System.Drawing.Size(101, 13);
            this.periodUse.TabIndex = 15;
            this.periodUse.Text = "Срок пользования";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pReturnTime
            // 
            this.pReturnTime.AutoSize = true;
            this.pReturnTime.Location = new System.Drawing.Point(129, 313);
            this.pReturnTime.Name = "pReturnTime";
            this.pReturnTime.Size = new System.Drawing.Size(125, 17);
            this.pReturnTime.TabIndex = 13;
            this.pReturnTime.Text = "Возвращает в срок";
            this.pReturnTime.UseVisualStyleBackColor = true;
            // 
            // pExistence
            // 
            this.pExistence.AutoSize = true;
            this.pExistence.Location = new System.Drawing.Point(11, 313);
            this.pExistence.Name = "pExistence";
            this.pExistence.Size = new System.Drawing.Size(69, 17);
            this.pExistence.TabIndex = 12;
            this.pExistence.Text = "Наличие";
            this.pExistence.UseVisualStyleBackColor = true;
            // 
            // pInvNumber
            // 
            this.pInvNumber.Location = new System.Drawing.Point(111, 229);
            this.pInvNumber.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.pInvNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pInvNumber.Name = "pInvNumber";
            this.pInvNumber.Size = new System.Drawing.Size(143, 20);
            this.pInvNumber.TabIndex = 11;
            this.pInvNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pYear
            // 
            this.pYear.Location = new System.Drawing.Point(111, 187);
            this.pYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.pYear.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pYear.Name = "pYear";
            this.pYear.Size = new System.Drawing.Size(143, 20);
            this.pYear.TabIndex = 10;
            this.pYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // pPage
            // 
            this.pPage.Location = new System.Drawing.Point(111, 143);
            this.pPage.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pPage.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.pPage.Name = "pPage";
            this.pPage.Size = new System.Drawing.Size(143, 20);
            this.pPage.TabIndex = 9;
            this.pPage.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // invNumber
            // 
            this.invNumber.AutoSize = true;
            this.invNumber.Location = new System.Drawing.Point(8, 236);
            this.invNumber.Name = "invNumber";
            this.invNumber.Size = new System.Drawing.Size(90, 13);
            this.invNumber.TabIndex = 8;
            this.invNumber.Text = "Инвентарный №";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(8, 194);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(70, 13);
            this.year.TabIndex = 7;
            this.year.Text = "Год издания";
            // 
            // page
            // 
            this.page.AutoSize = true;
            this.page.Location = new System.Drawing.Point(8, 150);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(49, 13);
            this.page.TabIndex = 6;
            this.page.Text = "Страниц";
            // 
            // publishHouse
            // 
            this.publishHouse.AutoSize = true;
            this.publishHouse.Location = new System.Drawing.Point(8, 101);
            this.publishHouse.Name = "publishHouse";
            this.publishHouse.Size = new System.Drawing.Size(79, 13);
            this.publishHouse.TabIndex = 5;
            this.publishHouse.Text = "Издательство";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(8, 63);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(57, 13);
            this.title.TabIndex = 4;
            this.title.Text = "Название";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(8, 28);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(37, 13);
            this.author.TabIndex = 3;
            this.author.Text = "Автор";
            // 
            // pPublishHouse
            // 
            this.pPublishHouse.Location = new System.Drawing.Point(111, 94);
            this.pPublishHouse.Name = "pPublishHouse";
            this.pPublishHouse.Size = new System.Drawing.Size(143, 20);
            this.pPublishHouse.TabIndex = 2;
            // 
            // pTitle
            // 
            this.pTitle.Location = new System.Drawing.Point(111, 56);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(143, 20);
            this.pTitle.TabIndex = 1;
            // 
            // pAuthor
            // 
            this.pAuthor.BackColor = System.Drawing.SystemColors.Control;
            this.pAuthor.Location = new System.Drawing.Point(111, 21);
            this.pAuthor.Name = "pAuthor";
            this.pAuthor.Size = new System.Drawing.Size(143, 20);
            this.pAuthor.TabIndex = 0;
            // 
            // magazines
            // 
            this.magazines.Location = new System.Drawing.Point(4, 22);
            this.magazines.Name = "magazines";
            this.magazines.Padding = new System.Windows.Forms.Padding(3);
            this.magazines.Size = new System.Drawing.Size(279, 386);
            this.magazines.TabIndex = 1;
            this.magazines.Text = "Журналы";
            this.magazines.UseVisualStyleBackColor = true;
            // 
            // textWindow
            // 
            this.textWindow.Location = new System.Drawing.Point(288, 22);
            this.textWindow.Name = "textWindow";
            this.textWindow.Size = new System.Drawing.Size(365, 330);
            this.textWindow.TabIndex = 1;
            this.textWindow.Text = "";
            // 
            // pSortInvNumber
            // 
            this.pSortInvNumber.AutoSize = true;
            this.pSortInvNumber.Location = new System.Drawing.Point(447, 384);
            this.pSortInvNumber.Name = "pSortInvNumber";
            this.pSortInvNumber.Size = new System.Drawing.Size(195, 17);
            this.pSortInvNumber.TabIndex = 2;
            this.pSortInvNumber.Text = "Сортировать по инвентарному №";
            this.pSortInvNumber.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Просмотреть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BiblWorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(654, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pSortInvNumber);
            this.Controls.Add(this.textWindow);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BiblWorm";
            this.Text = "Библиотека";
            this.tabControl1.ResumeLayout(false);
            this.books.ResumeLayout(false);
            this.books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPeriodUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pInvNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage books;
        private System.Windows.Forms.TextBox pPublishHouse;
        private System.Windows.Forms.TextBox pTitle;
        private System.Windows.Forms.TextBox pAuthor;
        private System.Windows.Forms.TabPage magazines;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label publishHouse;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox pReturnTime;
        private System.Windows.Forms.CheckBox pExistence;
        private System.Windows.Forms.NumericUpDown pInvNumber;
        private System.Windows.Forms.NumericUpDown pYear;
        private System.Windows.Forms.NumericUpDown pPage;
        private System.Windows.Forms.Label invNumber;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label page;
        private System.Windows.Forms.RichTextBox textWindow;
        private System.Windows.Forms.CheckBox pSortInvNumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown pPeriodUse;
        private System.Windows.Forms.Label periodUse;
    }
}

