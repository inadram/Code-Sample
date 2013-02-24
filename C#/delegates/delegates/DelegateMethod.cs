namespace delegates
{
    public class DelegateMethod
    {
        private readonly ICommunication _communication;
        private readonly Sender _sender;

        public DelegateMethod( Communication communication)
        {
            _communication = communication;
            _sender = _communication.SendMessageWithEmail;
            _sender += _communication.SendMessageWithSms;
        }
        public void InvokeCommunication(string message)
        {
            _sender(message);
        }

        private delegate void Sender(string message);
    }
}
