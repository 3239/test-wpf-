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
    /// Логика взаимодействия для result_t.xaml
    /// </summary>
    public partial class result_t : Page
    {
        public result_t()
        {
            InitializeComponent();
            Zapis.vvod(chikl);
            Vyvod.doc3(chikl);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Avtorizac expenseReportPage = new Avtorizac();
            this.NavigationService.Navigate(expenseReportPage);
        }
    }
}
