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
using Test_Psyg;

namespace Project_Kristina
{
    /// <summary>
    /// Логика взаимодействия для Page9.xaml
    /// </summary>
    public partial class Page9 : Page
    {
        public Page9()
        {
            InitializeComponent();
            string s = vop.Text.ToString();
            Chtenie.Chten(s, chik, rb_1, rb_2, rb_3, rb_4);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rb_1.IsChecked == false && rb_2.IsChecked == false && rb_3.IsChecked == false && rb_4.IsChecked == false)
            {
                MessageBox.Show("Выберите ответ!");
            }
            else
            {
                result_t expenseReportPage = new result_t();
                this.NavigationService.Navigate(expenseReportPage);
                Zapis.raschet(rb_1, rb_2, rb_3, rb_4);
            }
        }
    }
}
