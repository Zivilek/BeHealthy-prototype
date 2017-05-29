using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BeHealthyPrototype
{
    public class Client: User
    {
        public int Height { get; set; }
        public int Weight { get; set; }
        public string HealthHistory { get; set; }
        public string PhysicalTestAnswers { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime PremiumExpireDate { get; set; }
        public Client()
        {

        }
        public Client(string name, string surname, string email, int height, int weight, string registerTime, string premiumTime): base(name, surname, email)
        {
            Height = height;
            Weight = weight;
            RegisterDate = DateTime.ParseExact(registerTime, "yyyy.MM.dd", null);
            if (!premiumTime.Equals("null")) PremiumExpireDate = DateTime.ParseExact(premiumTime, "yyyy.MM.dd", null);
        }
        public bool CheckEmail(string email)
        {
            string programPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\", @"Data\"));
            using (StreamReader str = new StreamReader(programPath + "Clients.txt"))
            {
                while (!str.EndOfStream)
                {
                    string[] temp = str.ReadLine().Split(' ');
                    if (temp[2].ToLower().Equals(email.ToLower())) return true;
                }
            }
            return false;
        }
        public Client GetCurrent()
        {
            string programPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\", @"Data\"));
            using (StreamReader str = new StreamReader(programPath + "Clients.txt"))
            {
                string[] temp = str.ReadLine().Split(' ');
                int height;
                int weight;
                int.TryParse(temp[3], out height);
                int.TryParse(temp[4], out weight);
                return new Client(temp[0], temp[1], temp[2], height, weight, temp[5], temp[6]);
            }
        }
        public override string ToString()
        {
            string expire;
            if (PremiumExpireDate == null) expire = "null";
            else expire = PremiumExpireDate.ToString("yyyy.MM.dd");
            return Name + " " + Surname + " " + Email + " " + Height + " " + Weight + " " + RegisterDate.ToString("yyyy.MM.dd") + " " + expire;
        }
        public void UpdatePremiumVersionDate(Period period)
        {
            if (PremiumExpireDate == DateTime.MinValue) PremiumExpireDate = DateTime.Now;
            PremiumExpireDate = PremiumExpireDate.AddMonths(period.Month);
            #region duombazes pakoregavimas
            string line = ToString();
            string line_to_delete = Email;
            string programPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\", @"Data\"));  
            using (StreamReader reader = new StreamReader(programPath + "Clients.txt"))
            {
                using (StreamWriter writer = new StreamWriter(programPath + "temp.txt"))
                {
                    writer.WriteLine(ToString());
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] temp = line.Split(' ');
                        if (String.Compare(temp[2], line_to_delete) == 0)
                            continue;

                        writer.WriteLine(line);
                    }
                }
            }
            using(StreamReader reader = new StreamReader(programPath + "temp.txt"))
            {
                using(StreamWriter writer = new StreamWriter(programPath + "Clients.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                        writer.WriteLine(line);
                }
            }
            #endregion
        }
    }
}
