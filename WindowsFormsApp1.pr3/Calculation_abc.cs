using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.pr3
{
    public class Calculation_abc
    {
        int a, b, c;

        public Calculation_abc(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public double D()
        {
            int sum = 0;

            if ((a % 7 == 0) || (b % 7 == 0) || (c % 7 == 0))
            {
                if(a % 7 == 0)
                {
                    sum += (a * a * a);
                }
                if (b % 7 == 0)
                {
                    sum += (b * b * b);
                }
                if (c % 7 == 0)
                {
                    sum += (c * c * c);
                }
            }
            else
            {
                return sum;
            }

            return sum;
        }



    }
}
