using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract6
{
    internal class Kuchansky : IgoZavKaf, Goodbye
    {
        double t;

        public Kuchansky(double t)
        {
            this.t = t;
        }

        public double T { get { return t; } set { t = value; } }

        public string kick()
        {
            return "Базаров Іван відрахований";
        }

        public string stud()
        {
            return "Базаров Іван переїзджає під Бахмут";
        }

        public void Kuchansky_Message()
        {
            if (t > 6)
            {
                MessageBox.Show(stud());
            }
           if (t > 8)
            {
                MessageBox.Show(kick());
            }
        }
    }
}
