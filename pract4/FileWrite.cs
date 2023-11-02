using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract4
{
    public class FileWrite : IWrite
    {
        public void write(string path, ArrayAB a)
        {
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                foreach (var item in a.b)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
            }
        }
    }
}
