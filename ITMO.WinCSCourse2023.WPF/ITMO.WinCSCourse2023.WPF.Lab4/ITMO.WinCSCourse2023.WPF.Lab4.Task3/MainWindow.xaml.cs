using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ITMO.WinCSCourse2023.WPF.Lab4.Task3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (FontFamily F in Fonts.SystemFontFamilies)
            {
                listBox.Items.Add(F.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            richTextBox.Selection.ApplyPropertyValue(FontWeightProperty, FontWeights.Bold);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            richTextBox.Selection.ApplyPropertyValue(FontStyleProperty, FontStyles.Italic);
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                richTextBox.Selection.ApplyPropertyValue(FontSizeProperty, Slider.Value.ToString());
            }
            catch { }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            richTextBox.Selection.ApplyPropertyValue(FontFamilyProperty, new FontFamily(listBox.SelectedValue.ToString()));
        }
    }
}
