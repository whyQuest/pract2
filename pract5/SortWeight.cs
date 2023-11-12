using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static pract5.Bagazh;

namespace pract5
{
    internal class SortWeight : IComparer <Bagazh>
    {
        public int Compare(Bagazh x, Bagazh y)
        {
            if (x.Weight < y.Weight) return -1;
            if (x.Weight > y.Weight) return 1;
            return 0;
        }
    }
}
