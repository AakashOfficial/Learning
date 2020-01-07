/*
 Question 3. Write a program to print all prime numbers between two given numbers.
 Ask the user to input two positive non-equal integers (between 2 and 1000), first number entered 
 should be smaller than larger number and if that’s not the case, ask the user to re-enter both 
 the numbers. Until user enters valid input, show appropriate message and keep asking 
 for the input again.
 */

namespace Q3
{
    class Program
    {
        // this function validate the User Input and rerurn 1 only if the both the input
        static int InputValidator(int firstInput, int secondInput) {
            // Validate the First Number should be greater than or Equals to 2 and smaller than 1000
            if (firstInput > 1 && firstInput < 1000) {
                // Validate the Second Number Should be greater than or Equals to 3 and smaller than or Equals to 1000
                if (secondInput > 2 && secondInput <= 1000) {
                    // Validate that Second Input Should be greater than First Input
                    if (firstInput < secondInput) {
                        return 1;
                    } else {
                        System.Console.WriteLine("Second Input Should be greater than First Input");
                        return 0;
                    }
                } else {
                    System.Console.WriteLine("Second Input Should between 3 to 1000");
                    return 0;
                }
            } else {
                System.Console.WriteLine("First Input Should between 2 to 999");
                return 0;
            }
        }

        static void Main(string[] args) {
            int firstInput, secondInput, count = 0;
            // do while loop to take two input in correct format
            do {
                System.Console.WriteLine("Enter First Input Number");
                firstInput = System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Enter Second Input Number");
                secondInput = System.Convert.ToInt32(System.Console.ReadLine());
            } while (InputValidator(firstInput, secondInput) == 0);

            // call FindPrime()
            FindPrime(firstInput, secondInput, count);
        }

        // function to find the prime number
        static void FindPrime(int firstInput, int secondInput, int count) {
            // for loop is used to print prime nuber between two number
            for (int number = firstInput; number <= secondInput; number++) {
                count = 0;
                for (int j = 2; j <= number / 2; j++) {

                    if (number % j == 0) {
                        count++;
                        break;
                    }

                    // No Need to Check for the Even Number greater than 2 
                    // because if the Number is not divided by 2 then Number will not divide by Even Number.
                    if (j % 2 == 1) {
                        j = j++;
                    }
                }
                if (count == 0 && number != 1) {
                    System.Console.WriteLine(number);
                }
            }
        }
    }
}
