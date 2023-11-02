using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract4
{
    internal class ShowArray
    {

        public string showArray(int[] array) 
        {
            string s = "";
            foreach(int i in array)
            {
                s += i.ToString() + " ";
            }
            return s;
        }
    }
}
