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
            //the Assert part of this test will be completed in tell dont ask topic
            var delegateMethod = new DelegateMethod(new Communication());
            _message = "Test Message";
            delegateMethod.InvokeCommunication(_message);

        }
    }
}