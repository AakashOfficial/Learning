/*
 Question 2. Difference between “==” operator, object.Equals methods 
 and object.ReferenceEquals method
 */

namespace Q2
{
    class Program
    {
        static void Main(string[] args) {
            // input parameters using in the program
            string param = null;
            int param2 = 1;
            float param3 = 1.0F;


            // call CheckIntEqual()
            CheckIntEqual(param2, param3);

            // call CheckIntReferenceEquals()
            CheckIntReferenceEquals();

            // call CheckIntEquals()
            CheckIntEquals(param2, param3);

            // call CheckStringEqual()
            CheckStringEqual(param);

            // call CheckStringReferenceEquals()
            CheckStringReferenceEquals(param);

            // call CheckStringEquals()
            CheckStringEquals(param);
        }

        // method For check behaviour of == with int
        static void CheckIntEqual(int param2, float param3) {
            // Checking the behaviour of == for integers
            // Outcome : Values should be Same
            // return true if equals otherwise false
            if (param2 == param3) {
                System.Console.WriteLine(param2 == param3);
            } else {
                System.Console.WriteLine("False");
            }
        }

        // method For check behaviour of object.ReferenceEquals with int
        static void CheckIntReferenceEquals() {
            // Checking the behaviour of refrenceequals for integers
            // Outcome : Checking the Reference of the Objects
            // return true if equals otherwise false
            if (object.ReferenceEquals(5, 5.0)) {
                System.Console.WriteLine(object.ReferenceEquals(5, 5.0));
            } else {
                System.Console.WriteLine("False");
            }
        }

        // method For check behaviour of Equals with int
        static void CheckIntEquals(int param2, float param3) {
            // Checking the behaviour of Equals for integers
            // Outcome : both the parameters should be equal and same length
            // return true if equals otherwise false
            if (param2.Equals(param3)) {
                System.Console.WriteLine(param2.Equals(param3));
            } else {
                System.Console.WriteLine("False");
            }
        }

        // method For check behaviour of == with strings
        static void CheckStringEqual(string param) {
            // Checking the behaviour of == for String
            // Outcome : Checking the Values.
            // return true if equals otherwise false
            if (param == null) {
                System.Console.WriteLine(param == null);
            } else {
                System.Console.WriteLine("False");
            }
        }

        // method For check behaviour of object.ReferenceEquals with strings
        static void CheckStringReferenceEquals(string param) {
            // Checking the behaviour of refrenceequals for String
            // Outcome : Checking the Reference of the Objects
            // return true if equals otherwise false
            if (object.ReferenceEquals(param, null)) {
                System.Console.WriteLine(object.ReferenceEquals(param, null));
            } else {
                System.Console.WriteLine("False");
            }
        }

        // method For check behaviour of Equals with strings
        static void CheckStringEquals(string param) {
            // Checking the behaviour of refrenceequals for String
            // Outcome : Checking the Reference of the Objects
            // return true if equals otherwise false
            if (param.Equals(null)) {
                System.Console.WriteLine(param.Equals(null));
            } else {
                System.Console.WriteLine("False");
            }
            // Output : Exception because Reference of Object not be Null}
        }
    }
}