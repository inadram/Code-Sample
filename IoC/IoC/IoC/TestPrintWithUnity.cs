using Microsoft.Practices.Unity;
using NUnit.Framework;

namespace IoC
{
    [TestFixture]
    public class TestPrintWithUnity
    {
        [Test]
        public void Given_Unity_When_Print_Then_ShouldResolveExpectedType()
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<ITypeOfPrinter, ColorfullPrinter>();

            var print = unityContainer.Resolve<Print>();
            string colorfullText = print.print();

            Assert.Pass(colorfullText);
        }

        [Test]
        public void Given_Unity_When_OverridePrint_Then_ShouldResolveExpectedType()
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<ITypeOfPrinter, ColorfullPrinter>();

            var print = unityContainer.Resolve<Print>(new ParameterOverride("typeOfPrinter",new BlackAndWhitePrinter()));
            string colorfullText = print.print();

            Assert.IsFalse(colorfullText.Contains("colorfull"));
        }

        [Test]
        public void Given_UnityWithProperty_When_Print_Then_ShouldResolveExpectedType()
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<ITypeOfPrinter, ColorfullPrinter>();
            unityContainer.RegisterType<ITypeOfPrinter, ColorfullPrinter>(new InjectionProperty("NumberOfPrints", 5));

            var print = unityContainer.Resolve<Print>();
            string colorfullText = print.print();

            Assert.Pass(colorfullText);
        }


        [Test]
        public void Given_UnityWithNormalLifeCycle_When_Print_Then_ShouldResolveExpectedType()
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<ITypeOfPrinter, ColorfullPrinter>();
           
            var print = unityContainer.Resolve<Print>();

            var print2 = unityContainer.Resolve<Print>();

            string colorfullText = print.print();
            string colorfullText2 = print2.print();

            Assert.That(colorfullText, Is.EqualTo(colorfullText2));
        }

        [Test]
        public void Given_UnityWithContainerControlledLifeCycle_When_Print_Then_ShouldResolveExpectedType()
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<ITypeOfPrinter, ColorfullPrinter>(new ContainerControlledLifetimeManager());

            var print = unityContainer.Resolve<Print>();

            var print2 = unityContainer.Resolve<Print>();

            string colorfullText = print.print();
            string colorfullText2 = print2.print();

            Assert.That(colorfullText, Is.Not.EqualTo(colorfullText2));
            Assert.Pass(colorfullText2);
        }


    }
}
