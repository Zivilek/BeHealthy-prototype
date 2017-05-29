using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHealthyPrototype
{
    public class ActivationCode
    {
        public string Code { get; set; }
        Client client;
        public ActivationCode()
        {
        }
        public ActivationCode(string code)
        {
            Code = code;
        }
        public void GetNewActivationCode(Client client, int value)
        {
            ActivationCode code = Generate(value);
            string email = client.Email;
            new Mailer().Send(code, email);

        }
        public ActivationCode Generate(int value)
        {
            int length = 15;
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string str = new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            string programPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\", @"Data\"));
            using (TextWriter tw = new StreamWriter(programPath + "ActivationCodes.txt", append: true))
            {
                tw.WriteLine(str + " " + value + " ");
            }
            return new ActivationCode(str);
        }
        public bool Check(ActivationCode code)
        {
            Period period = new Period().GetPeriod(code);
            if (period == null) return false;
            Client client = new Client().GetCurrent();
            #region aktyvacijos kodu duombazes pakoregavimas
            string line = null;
            string line_to_delete = code.Code;
            string programPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\", @"Data\"));
            using (StreamReader reader = new StreamReader(programPath + "ActivationCodes.txt"))
            {
                using (StreamWriter writer = new StreamWriter(programPath + "temp.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] temp = line.Split(' ');
                        if (String.Compare(temp[0], line_to_delete) == 0)
                            continue;

                        writer.WriteLine(line);
                    }
                }
            }
            using (StreamReader reader = new StreamReader(programPath + "temp.txt"))
            {
                using (StreamWriter writer = new StreamWriter(programPath + "ActivationCodes.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                        writer.WriteLine(line);
                }
            }
            #endregion
            client.UpdatePremiumVersionDate(period);
            return true;
        }
    }
}
