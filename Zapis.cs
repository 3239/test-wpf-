using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Test_Psyg
{
    public class Zapis
    {
        XDocument xdoc = new XDocument();
        public static int s = 0;
        public static void raschet(RadioButton rb_1, RadioButton rb_2, RadioButton rb_3, RadioButton rb_4)
        {
            
            if (rb_2.IsChecked == true)
            {
                s = s + 1;
            }
            else if (rb_3.IsChecked == true)
            {
                s = s + 2;
            }
            else if (rb_4.IsChecked == true)
            {
                s = s + 3;
            }
        }

        public static void vvod(TextBlock textb)
        {
            string f = "dd";
            if (s < 5)
            {
                f = "result_1";
            }

            if (s > 4 && s < 11)
            {
                f = "result_2";
            }

            if (s > 10 && s < 13)
            {
                f = "result_3";
            }

            if (s > 12 && s < 16)
            {
                f = "result_4";
            }

            if (s > 15)
            {
                f = "result_5";
            }
            XDocument xdoc = XDocument.Load("test.xml");
            var Unit = xdoc.Element("test")?
                    .Elements("tes")
                        .FirstOrDefault(p => p.Attribute("name")?.Value == f);
            if (f == "result_1")
            {
                var o_5 = Unit?.Element("result1")?.Value;
                if (o_5 != null) textb.Text = o_5;
            }
            if (f == "result_2")
            {
                var o_1 = Unit?.Element("result2")?.Value;
                if (o_1 != null) textb.Text = o_1;
            }
            if (f == "result_3")
            {
                var o_2 = Unit?.Element("result3")?.Value;
                if (o_2 != null) textb.Text = o_2;
            }
            if (f == "result_4")
            {
                var o_3 = Unit?.Element("result4")?.Value;
                if (o_3 != null) textb.Text = o_3;
            }
            if (f == "result_5")
            {
                var o_4 = Unit?.Element("result5")?.Value;
                if (o_4 != null) textb.Text = o_4;
            }
        }
    }
}
