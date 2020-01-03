/*
 Question 2. Difference between “==” operator, object.Equals methods 
 and object.ReferenceEquals method
 */

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string param = null;
            int param2 = 1;
            float param3 = 1.0F;

            // Checking the behaviour of == for integers
            // Outcome : Values should be Same
            // return true if equals otherwise false
            if (param2 == param3) {
                System.Console.WriteLine(param2 == param3);
            } else {
                System.Console.WriteLine("False");
            }

            // Checking the behaviour of Equals for integers
            // Outcome : both the parameters should be equal and same length
            // return true if equals otherwise false
            if (param2.Equals(param3)) {
                System.Console.WriteLine(param2.Equals(param3));
            } else {
                System.Console.WriteLine("False");
            }

            // Checking the behaviour of refrenceequals for integers
            // Outcome : Checking the Reference of the Objects
            // return true if equals otherwise false
            if (object.ReferenceEquals(5, 5.0)) {
                System.Console.WriteLine(object.ReferenceEquals(5, 5.0));
            } else {
                System.Console.WriteLine("False");
            }

            // Checking the behaviour of refrenceequals for String
            // Outcome : Checking the Values.
            // return true if equals otherwise false
            if (param == null) {
                System.Console.WriteLine(param == null);
            } else {
                System.Console.WriteLine("False");
            }

            // Checking the behaviour of refrenceequals for String
            // Outcome : Checking the Reference of the Objects
            // return true if equals otherwise false
            if (object.ReferenceEquals(param, null)) {
                System.Console.WriteLine(object.ReferenceEquals(param, null));
            } else {
                System.Console.WriteLine("False");
            }

            // Checking the behaviour of refrenceequals for String
            // Outcome : Checking the Reference of the Objects
            // return true if equals otherwise false
            if (param.Equals(null)) {
                System.Console.WriteLine(param.Equals(null));
            } else {
                System.Console.WriteLine("False");
            }
            // Output : Exception because Reference of Object not be Null
        }
    }
}
