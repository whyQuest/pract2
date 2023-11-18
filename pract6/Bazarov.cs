using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract6
{
    internal class Bazarov : IgoTeach, BazarovGoodStudent
    {

        double t;

        public Bazarov(double t)
        {
            this.t = t;
        }

        public double T { get { return t; } set { t = value; } }

        public string goTeach() 
        {
            return "Базаров йде на розмову з викладачем";
        }

        public string good()
        {
            return "Базарова простили, все добре";
        }



        public void Bazarov_Massage()
        {
            if (t > 2)
            {
                MessageBox.Show(goTeach());
            }
            else
            {
                MessageBox.Show(good());
            }
        }
    }
}
