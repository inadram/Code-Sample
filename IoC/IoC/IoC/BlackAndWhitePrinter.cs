namespace IoC
{
    public class BlackAndWhitePrinter : ITypeOfPrinter
    {
        public string Printing()
        {
            NumberOfPrints++;
            return string.Format("it is Black and white printing {0}",NumberOfPrints);

        }
        public int NumberOfPrints { get; set; }
    }
}