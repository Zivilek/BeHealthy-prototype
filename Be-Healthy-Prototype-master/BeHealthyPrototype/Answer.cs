using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHealthyPrototype
{
    public class Answer
    {
        public void Save(List<string> answers)
        {
            string programPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\", @"Data\"));
            using (StreamWriter writer = new StreamWriter(programPath + "ClientAnswers.txt"))
            {
                foreach(string str in answers)
                {
                    writer.WriteLine(str);
                }
            }
        }
    }
}
