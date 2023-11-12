using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5
{
    public class Bagazh : IComparable
    {
        string PIB;
        int count;
        int weight;

        public Bagazh(string PIB, int count, int weight)
        {
            this.PIB = PIB;
            this.count = count;
            this.weight = weight;
        }
        public Bagazh()
        {
            this.PIB = "Ampilogov Igor Andriiovych";
            var r = new Random();
            this.count = r.Next(1, 10);
            this.weight = r.Next(60, 300);
        }
        public string PIIB { get { return this.PIB; } set { this.PIB = value; } }

        public int Count
        {
            get { return this.count; }
            set
            {
                if (value > 0)
                {
                    this.count = value;
                }
                else
                {
                    throw new ArgumentException("Count <= 0");
                }
            }
        }

        public int Weight
        {
            get { return this.weight; }
            set
            {
                if (value > 0)
                {
                    this.weight = value;
                }
                else
                {
                    throw new ArgumentException("Weight <= 0");
                }
            }
        }

        public int CompareTo(object obj)
        {
            Bagazh s = obj as Bagazh;
            return weight.CompareTo(s.weight);
        }

    }
}
