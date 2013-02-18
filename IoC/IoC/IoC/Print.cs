namespace IoC
{
    public class Print
    {
        private readonly ITypeOfPrinter _typeOfPrinter;

        public Print(ITypeOfPrinter typeOfPrinter)
        {
            _typeOfPrinter = typeOfPrinter;
        }

        public string print()
        {
          return _typeOfPrinter.Printing();
        }
    }
}
