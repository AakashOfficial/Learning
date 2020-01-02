namespace Q1A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taking the input from user for conversion
            System.Console.WriteLine("Enter the Value to be Convert");
            string InputValue = System.Console.ReadLine() ;

            // Convert by int.parse() method
            int ConvertedValue = int.Parse(InputValue);
            System.Console.WriteLine("Input Converted Using the int.Parse() method") ;
            System.Console.WriteLine(ConvertedValue);

            // Convert by the Convert.ToInt method
            ConvertedValue = System.Convert.ToInt32(InputValue);
            System.Console.WriteLine("Input Converted Using the Convert.ToInt() method");
            System.Console.WriteLine(ConvertedValue);

            // For the use int the int.TryParse() method
            int DefaultValue = -1;
            bool ConvertedValueResult;
            ConvertedValueResult = int.TryParse(InputValue , out DefaultValue);
            System.Console.WriteLine("Input Converted Using the Convert.ToInt() method");
            System.Console.WriteLine(ConvertedValueResult);

        }
    }
}
