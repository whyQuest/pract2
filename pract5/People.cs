using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace pract5
{
    public class People
    {
        public List<Bagazh> people = new List<Bagazh>();
        XmlSerializer serializer = new XmlSerializer(typeof(List<Bagazh>));

        public void Add(Bagazh person)
        {
            people.Add(person);
        }
        public void Remove(int i)
        {
            people.RemoveAt(i);
        }
        public void Sort()
        {
            SortWeight sortByAge = new SortWeight();
            people.Sort(sortByAge);
        }
        public void WriteFile(string fileName)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            serializer.Serialize(fileStream, people);
            fileStream.Close();
        }
        public void ReadFile(string fileName)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            people = serializer.Deserialize(fileStream) as List<Bagazh>;
            fileStream.Close();
        }
    }
}
