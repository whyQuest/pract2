using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract4
{
    public class FileRead : IRead
    {
        public void read(string path, ArrayAB a)
        {
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string line = "";
                try
                {
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        a.a[i] = Convert.ToInt32(line);
                        i++;
                    }
                    a.Length = i;
                    sr.Close();
                }
                catch (Exception e)
                {

                    throw new Exception("Error in file: " + e.Message);
                }


            }
        }
    }
}
