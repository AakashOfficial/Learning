using System;

namespace Extensions {

    // it is a main class which calls all the function of the extension ma class 
    class ExtensionMain {

        static void Main(string[] args) {
            int oddNumber;
            int evenNumber;
            int primeNumber;
            int negativeNumber;
            int checkDivide;
            int byNumber;

            ExtensionWork extension = new ExtensionWork();
            Console.WriteLine("Enter the number to check whether it is odd or not");
            oddNumber = int.Parse(Console.ReadLine());
            extension.IsOdd(oddNumber);
            Console.WriteLine("Enter the number to check whether it is even or not");
            evenNumber = int.Parse(Console.ReadLine());
            extension.IsEven(evenNumber);
            Console.WriteLine("Enter the number to check whether it is prime or not");
            primeNumber = int.Parse(Console.ReadLine());
            extension.IsPrime(primeNumber);
            Console.WriteLine("Enter the number to check whether it is negative or not");
            negativeNumber = int.Parse(Console.ReadLine());
            extension.IsNegative(negativeNumber);
            Console.WriteLine("Enter the number to check whether  number  ");
            checkDivide = int.Parse(Console.ReadLine());
            Console.WriteLine("isdivisible by this number or not");
            byNumber= int.Parse(Console.ReadLine());
            extension.IsDivisibleBy(checkDivide,byNumber);
        }
    }
}