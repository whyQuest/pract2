using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace практ2
{
    internal class mass2
    {
        int m = 4;
        int n = 4;
        int[,] mass;

        public mass2(int rolls, int colls)
        {
            m = rolls;
            n = colls;

            mass = new int[m, n];
            Random rand = new Random();

            for(int i = 0; i < m; i++) 
            {
                for(int j = 0; j < n; j++)
                {
                    mass[i, j] = rand.Next(-20, 20);
                }
            }

        }
        public mass2()
        {
            mass = new int[m, n];
            Random rand = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = rand.Next(-20, 20);
                }
            }
        }

        public int get_m()
        {
            return m;
        }

        public int get_n()
        {
            return n;
        }

        public int[,] get_mass()
        {
            return mass;
        }

        public int this[int i, int j]
        {
            get
            {
                if (i >= 0 && j >= 0)
                {
                    return mass[i, j];
                }
                else
                {
                    return 0;
                }
            }
        }



       public int[,] Sol(int rolls, int colls, int[,] mass)
        {
            for (int i = 0; i < rolls; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    if (mass[i, j] < 5)
                    {
                        mass[i, j] = 111;
                    }
                }
            }

            return mass;
        }
    }

}
