using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BeHealthyPrototype
{
    public class Mailer
    {
        public void Send(ActivationCode code, string email)
        {
            send(code.Code, email, "Activation code");
        }
        private void send(string msg, string email, string subject)
        {
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.googlemail.com";
            client.Port = 587;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("behealthy2017psi@gmail.com", "behealthy2017");
            MailMessage mm = new MailMessage("behealthy2017psi@gmail.com", email, subject, msg);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.Send(mm);
        }
        public void SendHelpMsg(Message msg)
        {
            send(msg.MessageData, "behealthy2017psi@gmail.com", msg.Subject);
        }
    }
}
