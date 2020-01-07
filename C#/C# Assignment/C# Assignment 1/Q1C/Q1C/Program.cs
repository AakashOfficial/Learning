/*
 Question 1.c Get inputs from user and convert it into Boolean
 */

namespace Q1C
{
    class Program
    {
        static void Main(string[] args)
        {
            // call TakeInput()
            string InputValue = TakeInput();

            // call ConvertBoolParse()
            ConvertBoolParse(InputValue);

            // call ConvertBoolTryParse()
            ConvertBoolTryParse(InputValue);
        }

        // fuction for aking input from user
        static string TakeInput()
        {
            // Show message to user
            System.Console.WriteLine("Enter Input to be Converted");

            // taking Input from the User
            string InputValue = System.Console.ReadLine();

            return InputValue;
        }

        // function for convert to bool using bool.Parse()
        static void ConvertBoolParse(string InputValue)
        {
            // Converted using the bool.Parse() method
            bool ConvertedValue = bool.Parse(InputValue);
            System.Console.WriteLine("Converted using the bool.Parse() method");
            System.Console.WriteLine("Output : " + ConvertedValue);
        }

        // function for convert to bool using bool.TryParse()
        static void ConvertBoolTryParse(string InputValue)
        {
            // Converted using the bool.TryParse() method
            bool def = true;
            bool ConvertedValue = bool.TryParse(InputValue, out def);
            System.Console.WriteLine("Converted using the bool.TryParse() method");
            System.Console.WriteLine("Output : " + ConvertedValue);
        }
    }
}