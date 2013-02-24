using NUnit.Framework;
using Rhino.Mocks;

namespace delegates
{
    [TestFixture]
    public class TestDelegateMethod
    {
        private string _message;

        [Test]
        public void Given_Message_When_InvokeDelegate_Then_ShouldCalledSmsAndEmail()
        {
            var communicationMock = MockRepository.GenerateMock<ICommunication>();
            var delegateMethod = new DelegateMethod(communicationMock);
            _message = "Test Message";
            delegateMethod.InvokeCommunication(_message);
            communicationMock.AssertWasCalled(x => x.SendMessageWithEmail(_message));
            communicationMock.AssertWasCalled(x => x.SendMessageWithSms(_message));

        }
    }
}