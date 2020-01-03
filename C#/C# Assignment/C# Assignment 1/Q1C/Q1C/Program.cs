/*
 Question 1.c Get inputs from user and convert it into Boolean
 */

namespace Q1C
{
    class Program
    {
        static void Main(string[] args)
        {
            // Show message to user
            System.Console.WriteLine("Enter Input to be Converted");

            // taking Input from the User
            string InputValue = System.Console.ReadLine();

            // Converted using the bool.Parse() method
            bool ConvertedValue = bool.Parse(InputValue);
            System.Console.WriteLine("Converted using the bool.Parse() method");
            System.Console.WriteLine("Output : " + ConvertedValue);

            // Converted using the bool.TryParse() method
            bool def = true;
            ConvertedValue = bool.TryParse(InputValue, out def);
            System.Console.WriteLine("Converted using the bool.TryParse() method");
            System.Console.WriteLine("Output : " + ConvertedValue);
        }
    }
}