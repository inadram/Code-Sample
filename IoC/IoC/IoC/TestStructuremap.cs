using NUnit.Framework;
using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Pipeline;

namespace IoC
{
    [TestFixture]
   public class TestStructuremap
    {
        [Test]
        public void Given_structuremap_when_print_then_shouldReturnAppropriateTypes()
        {
            var container = new Container();
            container.Configure(x=>x.For<ITypeOfPrinter>().Use<ColorfullPrinter>());
            var printerInstance = container.GetInstance<Print>();
            string colorfullPrintText = printerInstance.print();
            Assert.Pass(colorfullPrintText);
        }

        [Test]
        public void Given_structuremapWithDependency_when_print_then_shouldReturnAppropriateTypes()
        {
            var container = new Container(x => x.For<ITypeOfPrinter>().Use<ColorfullPrinter>());
            var printerInstance = container.GetInstance<Print>();
            string colorfullPrintText = printerInstance.print();
            Assert.Pass(colorfullPrintText);
        }

        [Test]
        public void Given_structuremapWithRegistry_when_print_then_shouldReturnAppropriateTypes()
        {
            var container = new Container(new Registering());
            var printerInstance = container.GetInstance<Print>();
            string blackAndWhitePrintText = printerInstance.print();
            Assert.Pass(blackAndWhitePrintText);
        }

        [Test]
        public void Given_structuremapWithNormalLifecycle_when_print_then_shouldReturnAppropriateTypes()
        {
            var container = new Container(new Registering());
            var printerInstance = container.GetInstance<Print>();
            var printerInstance2 = container.GetInstance<Print>();
            string blackAndWhitePrintText = printerInstance.print();
            string blackAndWhitePrintText2 = printerInstance2.print();
            Assert.That(blackAndWhitePrintText,Is.EqualTo(blackAndWhitePrintText2));
        }

        [Test]
        public void Given_structuremapWithingeltonLifecycle_when_print_then_shouldReturnAppropriateTypes()
        {
            var container = new Container();
            container.Configure(x=>x.For<ITypeOfPrinter>().LifecycleIs(new SingletonLifecycle()).Use<BlackAndWhitePrinter>());
            var printerInstance = container.GetInstance<Print>();
            var printerInstance2 = container.GetInstance<Print>();

            string blackAndWhitePrintText = printerInstance.print();
            string blackAndWhitePrintText2 = printerInstance2.print();
            Assert.That(blackAndWhitePrintText, Is.Not.EqualTo(blackAndWhitePrintText2));
        }

        [Test]
        public void Given_structuremapWithTryGetInstance_when_print_then_shouldReturnAppropriateTypes()
        {
            var container = new Container(new Registering());
            var printerInstance = container.TryGetInstance<ITypeOfPrinter>();
            string blackAndWhitePrintText = printerInstance.Printing();
            Assert.Pass(blackAndWhitePrintText);
        }

        [Test]
        public void Given_structuremap_when_printWhatDoIHave_then_shouldReturnWhatDoIHave()
        {
            var container = new Container(new Registering());
            var printerInstance = container.TryGetInstance<ITypeOfPrinter>();
            string blackAndWhitePrintText = printerInstance.Printing();
            Assert.Pass(container.WhatDoIHave());
        }
    }

    public class Registering:Registry
    {
        public Registering()
        {
            For<ITypeOfPrinter>().Use<BlackAndWhitePrinter>();
        }
    }
}
