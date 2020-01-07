/*
 Question 1.a Get inputs from user and convert it into Integer
 */

namespace Q1A
{
    class Program
    {
        static void Main(string[] args) {

            // call TakeInput() for input
            string InputValue = TakeInput();

            // Call ConvertIntParse() 
            ConvertIntParse(InputValue);

            // Call ConvertIntToInt()
            ConvertIntToInt(InputValue);

            // call ConvertIntTryParse()
            ConvertIntTryParse(InputValue);
        }

        // function for taking the input from user and return
        static string TakeInput() {
            // Taking the input from user for conversion
            System.Console.WriteLine("Enter the Value to be Convert");
            string InputValue = System.Console.ReadLine();

            return InputValue;
        }

        // function for convert to int by int.parse()
        static void ConvertIntParse(string InputValue) {
            // Convert by int.parse() method
            int ConvertedValue = int.Parse(InputValue);
            System.Console.WriteLine("Input Converted Using the int.Parse() method");
            System.Console.WriteLine(ConvertedValue);
        }

        // function for convert to int by Convert.ToInt()
        static void ConvertIntToInt(string InputValue) {
            // Convert by the Convert.ToInt method
            int ConvertedValue = System.Convert.ToInt32(InputValue);
            System.Console.WriteLine("Input Converted Using the Convert.ToInt() method");
            System.Console.WriteLine(ConvertedValue);
        }

        // function for convert to int by int.TryParse()
        static void ConvertIntTryParse(string InputValue) {
            // For the use int the int.TryParse() method
            int DefaultValue = -1;
            bool ConvertedValueResult;
            ConvertedValueResult = int.TryParse(InputValue, out DefaultValue);
            System.Console.WriteLine("Input Converted Using the Convert.ToInt() method");
            System.Console.WriteLine(ConvertedValueResult);
        }
        
    }
}
