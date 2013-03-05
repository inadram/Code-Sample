using System;
using NUnit.Framework;

namespace ErrorHandler
{
    [Serializable]
    public class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    public class ErrorHandler
    {
        public void RaiseException()
        {
            throw new ArgumentException("This is RaiseException exception");
        }

        public string DoSomething()
        {
            string exceptionMessage = string.Empty;
            try
            {
                RaiseException();
            }
            catch (DivideByZeroException exception)
            {
                exceptionMessage = "divide by zero";
            }
            catch(ArgumentException exception)
            {
                exceptionMessage = "argument exception";
            }
            catch(Exception exception)
            {
                exceptionMessage = "General exception";
            }
            finally
            {
                exceptionMessage = exceptionMessage + " finally";
            }
            return exceptionMessage;
        }

        public void DoSomethingMore()
        {
            try
            {
                DoSomething();
            }
            catch (Exception)
            {
                
                throw new Exception();
            }

        }
    }

    [TestFixture]
    public class TestErrorHandler
    {
        [Test]
        public void When_RaiseExceptionCalled_Then_anExceptionShouldbeRaise()
        {
            var  errorHandler=new ErrorHandler();
            try
            {
                errorHandler.RaiseException();
            }
            catch (Exception ex)
            {
                Assert.That("This is RaiseException exception", Is.EqualTo(ex.Message));
            }
        }

        [Test]
        public void When_DoSomeWorkCalled_Then_ExceptionShouldBeCatched()
        {
            var errorHandler = new ErrorHandler();
            errorHandler.DoSomething();
           Assert.Pass();
        }

        [Test]
        public void When_RaiseException_ThePriorityIsForTopOneThatMatches()
        {
            var errorHandler = new ErrorHandler();
            string exceptionMessage = errorHandler.DoSomething();
            Assert.That(exceptionMessage.Contains("argument exception"));
        }

        [Test]
        public void When_WeHaveTwoTryCatchBlockThePriorityIsByInnerBlock()
        {
            var errorHandler=new ErrorHandler();
            errorHandler.DoSomethingMore();
            Assert.Pass();
        }

        public void When_DoSomethingCalled_Then_FinallyBlockShouldExecute()
        {
            var errorHandler = new ErrorHandler();
            string exceptionMessage = errorHandler.DoSomething();
            Assert.That(exceptionMessage.Contains("finally"));
        }
    }
}
