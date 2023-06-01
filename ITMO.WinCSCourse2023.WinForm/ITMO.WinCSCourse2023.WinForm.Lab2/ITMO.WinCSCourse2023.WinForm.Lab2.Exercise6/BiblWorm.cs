using MyClass;
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

namespace ITMO.WinCSCourse2023.WinForm.Lab2.Exercise6
{
    public partial class BiblWorm : Form
    {
        public BiblWorm()
        {
            InitializeComponent();
        }

        public string Author // автор 
        {
            get { return pAuthor.Text; }
            set { pAuthor.Text = value; }
        }

        public string Title // Название 
        {
            get { return pTitle.Text; }
            set { pTitle.Text = value; }
        }

        public string PublishHouse // Издательство 
        {
            get { return pPublishHouse.Text; }
            set { pPublishHouse.Text = value; }
        }

        public int Page // Количество страниц 
        {
            get { return (int)pPage.Value; }
            set { pPage.Value = value; }
        }

        public int Year // Год издания 
        {
            get { return (int)pYear.Value; }
            set { pYear.Value = value; }
        }

        public int InvNumber // Инвентарный номер 
        {
            get { return (int)pInvNumber.Value; }
            set { pInvNumber.Value = value; }
        }

        public bool Existence // Наличие 
        {
            get { return pExistence.Checked; }
            set { pExistence.Checked = value; }
        }

        public bool SortInvNumber // Сортировка по инвентарному номеру 
        {
            get { return pSortInvNumber.Checked; }
            set { pSortInvNumber.Checked = value; }
        }

        public bool ReturnTime // Возвращение в срок 
        {
            get { return pReturnTime.Checked; }
            set { pReturnTime.Checked = value; }
        }

        public int PeriodUse // Инвентарный номер 
        {
            get { return (int)pPeriodUse.Value; }
            set { pPeriodUse.Value = value; }
        }

        List<Item> its = new List<Item>();
        private void books_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            its.Add(b);
            Author = Title = PublishHouse = "";
            Page = 5;
            InvNumber = PeriodUse = 1;
            Year = 1000;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            textWindow.Text = sb.ToString();
        }
    }
}
