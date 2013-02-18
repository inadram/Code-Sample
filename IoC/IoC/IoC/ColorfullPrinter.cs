namespace IoC
{
    public class ColorfullPrinter : ITypeOfPrinter
    {
        public string Printing()
        {
            NumberOfPrints++;
            return string.Format("it is colorfull printing {0}",NumberOfPrints);

        }

        public int NumberOfPrints { get; set; }
    }
}