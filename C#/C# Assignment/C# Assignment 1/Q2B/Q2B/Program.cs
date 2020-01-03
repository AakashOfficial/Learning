
namespace Q2B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Show message to user
            System.Console.WriteLine("Enter Input to be Converted");

            // taking Input from the User
            string InputValue = System.Console.ReadLine();

            // Converted using the float.Parse() method
            float ConvertedValue = float.Parse(InputValue);
            System.Console.WriteLine("Converted using the float.Parse() method");
            System.Console.WriteLine("Output : " + ConvertedValue);

            // Converted using the float.TryParse() method
            float def = 2.0F;
            bool ConvertedValuetryParse = float.TryParse(InputValue, out def);
            System.Console.WriteLine("Converted using the float.TryParse() method");
            System.Console.WriteLine("Output : " + ConvertedValuetryParse);


        }
    }
}
