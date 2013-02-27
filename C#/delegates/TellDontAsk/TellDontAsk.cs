using System;
using NUnit.Framework;

namespace TellDontAsk
{
    public class TellDontAsk
    {
        private SendCommunication _sender;
        public void RegisterCommunication(Message message)
        {
            _sender += message.SendMessageWithEmail;
            _sender += message.SendMessageWithSms;
        }
        public void SendMessage(string textMessage, SenderEventHandlerArgs args)
        {
            _sender(textMessage, args);
        }

    }
    public delegate void SendCommunication(string message, SenderEventHandlerArgs args);

    public class Message
    {
        public Message()
        {
            SenderEvent = (s, e) => { };
        }
        public void SendMessageWithEmail(string message, SenderEventHandlerArgs args)
        {
            Console.WriteLine("Email this message {0}", message);
            //sending message with email
            args.IsEmailSent = true;
            SenderEvent(this, args);
        }

        public void SendMessageWithSms(string message, SenderEventHandlerArgs args)
        {
            Console.WriteLine("Sms this mesksage {0}", message);
            //sending message with Sms
            args.IsSmsSent = true;
            SenderEvent(this, args);
        }

        public event EventHandler<SenderEventHandlerArgs> SenderEvent;
    }

    public class SenderEventHandlerArgs : EventArgs
    {
        public bool IsEmailSent { get; set; }
        public bool IsSmsSent { get; set; }
    }


    [TestFixture]
    public class TestTellDontAsk
    {
        [Test]
        public void Given_Message_When_SendCommunication_Then_ShouldSendWithSmsAndEmail()
        {
            var tellDontAsk = new TellDontAsk();
            tellDontAsk.RegisterCommunication(new Message());
            var senderEventHandlerArgs = new SenderEventHandlerArgs { IsEmailSent = false, IsSmsSent = false };
            tellDontAsk.SendMessage("test message", senderEventHandlerArgs);
            Assert.IsTrue(senderEventHandlerArgs.IsEmailSent);
            Assert.IsTrue(senderEventHandlerArgs.IsSmsSent);

        }
    }
}
