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
using System.Xml.Linq;
using Test_Psyg;

namespace Project_Kristina
{
    /// <summary>
    /// Логика взаимодействия для Avtorizac.xaml
    /// </summary>
    public partial class Avtorizac : Page
    {
        XDocument xdoc = new XDocument();
        public Avtorizac()
        {
            InitializeComponent();
        }

        private void raschet_Click(object sender, RoutedEventArgs e)
        {
            string a = avtoriz.Text;
            XDocument xdoc = XDocument.Load("people.xml");
            var root = xdoc.Element("test")?
                .Elements("tes");
            if (a != "")
            {
                if (avtoriz.Text == "admin")
                {
                    Baza expenseReportPage = new Baza();
                    this.NavigationService.Navigate(expenseReportPage);
                }
                else if (root.FirstOrDefault(p => p.Attribute("name")?.Value == a) != null)
                {
                    Vyvod.doc(a);
                    Page10 expenseReportPage = new Page10();
                    this.NavigationService.Navigate(expenseReportPage);

                }
                else
                {
                    Vyvod.doc2(a);
                    Test expenseReportPage = new Test();
                    this.NavigationService.Navigate(expenseReportPage);
                }
            } else
            {
                MessageBox.Show("Введите имя пользователя!");
            }

        }
    }
}
