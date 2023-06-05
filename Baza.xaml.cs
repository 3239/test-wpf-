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

namespace Project_Kristina
{
    /// <summary>
    /// Логика взаимодействия для Baza.xaml
    /// </summary>
    public partial class Baza : Page
    {
        public Baza()
        {
            InitializeComponent();
        }

        private void Zapic_Click(object sender, RoutedEventArgs e)
        {
            XDocument xdoc = XDocument.Load("test.xml");
            var n = xdoc.Element("test")?
                .Elements("tes")
                .FirstOrDefault(p => p.Attribute("name")?.Value == combo_zamena.Text);
            if (n != null)
            {
                var vopros = n.Element("vopros");
                if (vopros != null) vopros.Value = zamena.Text;
                var o_1 = n.Element("otvet1");
                if (o_1 != null) o_1.Value = otvet_1.Text;
                var o_2 = n.Element("otvet2");
                if (o_2 != null) o_2.Value = otvet_2.Text;
                var o_3 = n.Element("otvet3");
                if (o_3 != null) o_3.Value = otvet_3.Text;
                var o_4 = n.Element("otvet4");
                if (o_4 != null) o_4.Value = otvet_4.Text;
                xdoc.Save("test.xml");
            }
        }

        private void Vybr_Click(object sender, RoutedEventArgs e)
        {
            XDocument xdoc = XDocument.Load("test.xml");
            var Unit = xdoc.Element("test")?
                    .Elements("tes")
                        .FirstOrDefault(p => p.Attribute("name")?.Value == combo_zamena.Text);
            var vopros = Unit?.Element("vopros")?.Value;
            zamena.Text = vopros;
            var o_1 = Unit?.Element("otvet1")?.Value;
            otvet_1.Text = o_1;
            var o_2 = Unit?.Element("otvet2")?.Value;
            otvet_2.Text = o_2;
            var o_3 = Unit?.Element("otvet3")?.Value;
            otvet_3.Text = o_3;
            var o_4 = Unit?.Element("otvet4")?.Value;
            otvet_4.Text = o_4;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XDocument xdoc = XDocument.Load("test.xml");
            var Unit = xdoc.Element("test")?
                    .Elements("tes")
                        .FirstOrDefault(p => p.Attribute("name")?.Value == combo_zamena.Text);
            var vopros = Unit?.Element("vopros")?.Value;
            zamena.Text = vopros;
            var o_1 = Unit?.Element("otvet1")?.Value;
            otvet_1.Text = o_1;
            var o_2 = Unit?.Element("otvet2")?.Value;
            otvet_2.Text = o_2;
            var o_3 = Unit?.Element("otvet3")?.Value;
            otvet_3.Text = o_3;
            var o_4 = Unit?.Element("otvet4")?.Value;
            otvet_4.Text = o_4;
        }
    }
}
