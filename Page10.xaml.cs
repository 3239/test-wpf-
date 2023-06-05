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
    /// Логика взаимодействия для Page10.xaml
    /// </summary>
    public partial class Page10 : Page
    {
        public Page10()
        {
            InitializeComponent();
            Vyvod.doc1(chikl);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Test expenseReportPage = new Test();
            this.NavigationService.Navigate(expenseReportPage);
        }
    }
}
