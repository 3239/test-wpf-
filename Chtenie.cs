using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Test_Psyg
{
    public class Chtenie
    {
        XDocument xdoc = new XDocument();
        public static void Chten(string s, TextBlock text, RadioButton rb1, RadioButton rb2, RadioButton rb3, RadioButton rb4)
        {
            XDocument xdoc = XDocument.Load("test.xml");
            var Unit = xdoc.Element("test")?
                    .Elements("tes")
                        .FirstOrDefault(p => p.Attribute("name")?.Value == s);
            var vopros = Unit?.Element("vopros")?.Value;
            text.Text = vopros;
            var o_1 = Unit?.Element("otvet1")?.Value;
            rb1.Content = o_1;
            var o_2 = Unit?.Element("otvet2")?.Value;
            rb2.Content = o_2;
            var o_3 = Unit?.Element("otvet3")?.Value;
            rb3.Content = o_3;
            var o_4 = Unit?.Element("otvet4")?.Value;
            rb4.Content = o_4;
        }
    }
}
