using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHealthyPrototype
{
    public class Period
    {
        public int Month { get; set; }
        public Period()
        {

        }
        public Period(int month)
        {
            Month = month;
        }
        public List<Period> GetPeriods()
        {

            string programPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\", @"Data\"));
            List<Period> list = new List<Period>();
            using (StreamReader str = new StreamReader(programPath + "Periods.txt"))
            {
                while (!str.EndOfStream)
                {
                    int month;
                    if (int.TryParse(str.ReadLine(), out month) && month != 0)
                        list.Add(new Period(month));
                }
            }
            return list;
        }
        public Period GetPeriod(ActivationCode code)
        {
            string programPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\", @"Data\"));
            using (StreamReader str = new StreamReader(programPath + "ActivationCodes.txt"))
            {
                while (!str.EndOfStream)
                {
                    string[] temp = str.ReadLine().Split(' ');
                    if (temp[0].Equals(code.Code))
                    {
                        int month;
                        if (int.TryParse(temp[1], out month) && month != 0)
                            return new Period(month);
                    }
                }
            }
            return null;
        }
        public override String ToString()
        {
            return Month + "mėn.";
        }
    }
}
