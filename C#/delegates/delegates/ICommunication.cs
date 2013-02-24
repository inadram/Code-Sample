namespace delegates
{
    public interface ICommunication
    {
        void SendMessageWithEmail(string message);
        void SendMessageWithSms(string message);
    }
}