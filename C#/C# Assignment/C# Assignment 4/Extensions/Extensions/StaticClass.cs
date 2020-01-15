using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions {

    // here static class in which method of extension work is executed
    static class StaticClass {

        /* 
         * it is a extesion method which become part of wxension wor class
         * its role is to check whether number is odd or not 
         */
        public static void IsOdd(this ExtensionWork extension,int oddNumber) {
            if(oddNumber%2!=0) {
                Console.WriteLine("It is a odd number");
            } else {
                Console.WriteLine("It is  not a odd number");
            }
        }

        /*
         * it is a extesion method which become part of wxension wor class
         * its role is to check whether number is even or not
         */
        public static void IsEven(this ExtensionWork extension,int evenNumber) {
            if(evenNumber%2==0) {
                Console.WriteLine("it is a even number");
            } else {
                Console.WriteLine("it is not a even number");
            }
        }

        /*
         * it is a extesion method which become part of wxension wor class
         * its role is to check whether number is prime or not
         */ 
        public static void IsPrime(this ExtensionWork extension,int primeNumber) {           

            for (int number = 2; number <= (primeNumber / 2); number++) {
                 if (primeNumber % number == 0) {
                    Console.WriteLine("it is  prime number");
                    return;
                 }
            }
            Console.WriteLine("It is  not a prime number");
        }

        /*
         * it is a extesion method which become part of wxension wor class
         * its role is to check whether number is divisible or not
         */ 
        public static void IsDivisibleBy(this ExtensionWork extension,int chectDivide,int byNubmer) {
            if(chectDivide%byNubmer==0) {
                Console.WriteLine("It is divisible");
            } else {
                Console.WriteLine("It is  not divisible");
            }
        }
    }
}