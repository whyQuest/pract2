using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.pr3
{
    public class Calculation_ab
    {
        int a, b;

        public Calculation_ab(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int A { get; set; }
        public int B { get; set; }

        public int Sun()
        {
            var sum = 0;
            
            if (a > b) { throw new ArgumentOutOfRangeException("А не може бути більше B"); }

            if (a == b)
            {
                return 0;
            }
            else
            {
                for(int i =a; i <= b; i++) 
                {
                    if (i % 11 == 0 && i % 8 == 5)
                    {
                        sum += i;
                    }
                }
                return sum;
            }
        }
    }
}
