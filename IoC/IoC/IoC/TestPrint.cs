using NUnit.Framework;

namespace IoC
{
    [TestFixture]
    public class TestPrint
    {
        [Test]
        public void Given_ColorfulPrinterType_When_Print_Then_ItShouldBeColorful()
        {
            var print=new Print(new ColorfullPrinter());
            string printedText = print.print();
            Assert.IsTrue(printedText.Contains("colorfull"));
        }

        [Test]
        public void Given_BlackAndWhitePrinterType_When_Print_Then_ItShouldNotBeColorful()
        {
            var print = new Print(new BlackAndWhitePrinter());
            string printedText = print.print();
            Assert.IsFalse(printedText.Contains("colorfull"));
        }

        [Test]
        public void Given_Resolver_When_Print_Then_ItShouldFindAppropriateType()
        {
            var resolver=new Resolver();
            
            var print = new Print(resolver.ResolvePrinterType());
            string printedText = print.print();
            Assert.Pass(printedText);
        }
        [Test]
        public void Given_Nothing_When_Print_Then_ItShouldFindAppropriateType()
        {
            var resolver = new Resolver();
            resolver.Register<Print, Print>();
            //resolver.Register<ITypeOfPrinter, ColorfullPrinter>();
            resolver.Register<ITypeOfPrinter, BlackAndWhitePrinter>();
            var resolvedPrinter = resolver.Resolve<Print>();
            
            string printedText = resolvedPrinter.print();
            Assert.Pass(printedText);
        }
    }
}