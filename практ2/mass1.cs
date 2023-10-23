using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практ2
{
    internal class mass1
    {
        int[] mass;

       public mass1()
        {
            mass = new int[0];
        }

        public mass1(int[] mas)
        {
            mass = mas;
        }

        public int this[int i]
        {
            get 
            {
                if(i >= 0)
                {
                    return mass[i];
                }
                else
                { 
                    return 0; 
                }
            }
        }

        public int Length
        {
            get { return mass.Length; }
        }

        public int[] Getter()
        {
            return mass;
        }

        public double CalcMs(int[] mass)
        {
            double sum = 0;
            foreach(int num in mass)
            {
                sum = sum + num;
            }
            return sum / mass.Length;
        }
    }
}
