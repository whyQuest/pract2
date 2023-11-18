using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract6
{
    internal class Lisnevsky : IgoInstruct, IgoZavKaf
    {
        double t;

        public Lisnevsky(double t)
        {
            this.t = t;
        }

        public double T { get { return t; } set { t = value; } }

        public string goInstr()
        {
            return "Базаров переведений на контракт";
        }

        public string stud()
        {
            return "Базаров йде на розмову з завідуючим кафедрою";
        }

        public void lisnevsky_Message()
        {
           if (t > 4)
            {
                MessageBox.Show(goInstr());
            }
           if (t > 6)
            {
                MessageBox.Show(stud());
            }
        }


    }
}
