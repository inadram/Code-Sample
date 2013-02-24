using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TellDontAsk
{
    public class TellDontAsk
    {
    }

    public interface ICommunication
    {
        void SendMessageWithEmail(string message);
        void SendMessageWithSms(string message);
    }
}
