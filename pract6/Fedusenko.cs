using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract6
{
    internal class Fedusenko : IgoTeach, IgoInstruct
    {

        double t;

        public Fedusenko(double t)
        { this.t = t; }

        public double T { get { return t; }  set { t = value; }  }

        public string goTeach()
        {
            return "Базаров знятий з стипендії!";
        }

        public string goInstr()
        {
            return "Базаров йде на розмову з куратором";
        }

        public void Fedusenko_Message()
        {
            if (t > 2)
            {
                MessageBox.Show(goTeach());
            }
           if(t > 4)
            {
                MessageBox.Show(goInstr());
            }
        }
    }
}
