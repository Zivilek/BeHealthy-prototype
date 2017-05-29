using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHealthyPrototype
{
    public class Message
    {
        public Client Sender { get; set; }
        public string Subject { get; set; }
        public string MessageData { get; set; }
        public Message(string subject, string msgData, Client client)
        {
            Sender = client;
            subject = Subject;
            MessageData = msgData;
        }
    }
}
