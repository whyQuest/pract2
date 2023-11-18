using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract6
{

    delegate void Zayavlenie();
    internal class Zayava
    {

        public event Zayavlenie help;

        public void helping(double t)
        {
            if (t >= 0) { help(); }
        }
    }
}
