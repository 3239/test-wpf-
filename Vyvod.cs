using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Test_Psyg
{
    
    public class Vyvod
    {
        XDocument xdoc = new XDocument();
        public static string d;
        public static string v;
        public static void doc(string a)
        {
            d = a;
        }

        public static void doc2(string a)
        {
            v = a;
        }

        public static void doc1(TextBlock ter)
        {
            XDocument xdoc = XDocument.Load("people.xml");
            var Unit = xdoc.Element("test")?
                    .Elements("tes")
                        .FirstOrDefault(p => p.Attribute("name")?.Value == d);
            var o_5 = Unit?.Element("result")?.Value;
            ter.Text = o_5;
        }

        public static void doc3(TextBlock ter)
        {
            XDocument xdoc = XDocument.Load("people.xml");
            var root = xdoc.Element("test");
            
            if(root.Elements("tes").FirstOrDefault(p => p.Attribute("name")?.Value == d) == null)
            {
                root.Add(new XElement("tes",
                        new XAttribute("name", v),
                        new XElement("result", ter.Text)));
                xdoc.Save("people.xml");
            }
            if (root.Elements("tes").FirstOrDefault(p => p.Attribute("name")?.Value == d) != null)
            {
                var o_3 = root.Elements("tes").FirstOrDefault(p => p.Attribute("name")?.Value == d).Element("result");
                if (o_3 != null) o_3.Value = ter.Text;
                xdoc.Save("people.xml");
            }
        }
    }
}
