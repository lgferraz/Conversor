using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_05
{
    internal class Conversor
    {
        public string Dollar(string d, string c)
        {
            double v = double.Parse(d);
            double vc = double.Parse(c);
            double r = (v * vc);
            return "R$ " + r.ToString();
        }
        public string Celcius(string c)
        {
            double v = double.Parse(c);
            return "°Fh " + (v*(9/2)+32);
        }
        public string Fahrenheit(string f)
        {
            double v = double.Parse(f);
            return "°C " + ((v-32)*(5/9));
        }
    }
}
