using System;

namespace delegates
{
    public class Communication : ICommunication
    {
        public void SendMessageWithEmail(string message)
        {
            Console.WriteLine("send with email {0}", message);
            // send message with email
        }
        public void SendMessageWithSms(string message)
        {
            Console.WriteLine("send with sms {0}", message);
            //send message with sms
        }
    }
}