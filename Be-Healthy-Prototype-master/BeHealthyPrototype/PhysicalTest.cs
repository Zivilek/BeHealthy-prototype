using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHealthyPrototype
{
    public class PhysicalTest
    {
        public List<string> NewQuestion(int i)
        {
            List<string> list = new List<string>();
            string programPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\", @"Data\"));
            using(StreamReader reader = new StreamReader(programPath + "Questions.txt"))
            {
                
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if ((int)line.ElementAt(0) == i+48)
                    {
                        list.Add(line);
                        while (!reader.EndOfStream && (line = reader.ReadLine()).ElementAt(0) == '-')
                        {
                            list.Add(line.Remove(0,2));
                        }
                        return list;
                    }
                }
            }
            return list;
        }
    }
}
