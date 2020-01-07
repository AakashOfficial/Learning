/*
 Question 1.b Get inputs from user and convert it into Float
 */

namespace Q1B
{
    class Program
    {
        static void Main(string[] args) {
            // call TakeInput()
            string InputValue = TakeInput();

            // call ConvertFloatParse()
            ConvertFloatParse(InputValue);

            // call ConvertFloatTryParse()
            ConvertFloatTryParse(InputValue);
        }

        // Function for taking the input from user
        static string TakeInput() {
            // Show message to user
            System.Console.WriteLine("Enter Input to be Converted");

            // taking Input from the User
            string InputValue = System.Console.ReadLine();

            return InputValue;
        }

        // Function for convert to float using float.Parse()
        static void ConvertFloatParse(string InputValue) {
            // Converted using the float.Parse() method
            float ConvertedValue = float.Parse(InputValue);
            System.Console.WriteLine("Converted using the float.Parse() method");
            System.Console.WriteLine("Output : " + ConvertedValue);
        }

        // Function for Convert to float using float.TryParse()
        static void ConvertFloatTryParse(string InputValue) {
            // Converted using the float.TryParse() method
            float def = 2.0F;
            bool ConvertedValuetryParse = float.TryParse(InputValue, out def);
            System.Console.WriteLine("Converted using the float.TryParse() method");
            System.Console.WriteLine("Output : " + ConvertedValuetryParse);
        }
    }
}
