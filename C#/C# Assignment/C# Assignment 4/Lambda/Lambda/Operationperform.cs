using System;
using System.Collections.Generic;
using System.Linq;

namespace LamdaAndDelegate {

    class Operationperform {

        public delegate int WhereDelegate(int value);
        public delegate int MethodtheDelegate(int value);
        public delegate void MethodDelegate(List<int> elements);
        public delegate void FindNumber(List<int> elements);

        // find odd without curly bracket
        public void FindOdd(List<int> elements) {
            var output=elements.Where(x=>x%2!=0);
            foreach(var answer in  output) {
                Console.WriteLine("odd element from list of  i {0}", answer);
            }
        }

        //find even with curly bracket
        public void FindEven(List<int> elements) {
            var output = elements.Where(x => {
                return x % 2 == 0;
            });

            foreach (var answer in output) {
                Console.WriteLine("answer is {0}", answer);
            }
        }

        //find prime using delegate
        public void FindPrime(FindNumber f ,List<int> elements) {
            f(elements);
        }

        // find prime using lambda expression
        public void FindPrimeTwo( List<int> elements) {
            var isPrime = elements.GroupBy(n => {
                if (n < 2)
                    return 0;
                for (int i = 2; i <=n/2; i++)
                    if (n % i == 0) return 0; 
                return n;
            } );

            foreach(var output in isPrime) {
                Console.WriteLine(output.Key);
            }
        }

        //find greater than five using method convension syntax
        public void FindGreaterThanFive(List<int> element) {
            //object of delegate is created without new 
            MethodDelegate d = GreaterThanFive;
            d(element);
        }

        //delegagate function defination
        public void GreaterThanFive(List<int> element) {
            var output = element.Where(x => x > 5);
            Console.WriteLine("number greater than five are in the list ");
            Console.WriteLine(output.Count());
        }

        /*
         * find smaller than five using – Delegate Object in Where –
         * Method Group Conversion Syntax in Constructor of Object
         */        
        public void FindSmallerThanFive(List<int> element) {
            MethodtheDelegate d = SmallerThanFive;
            var query = element.Select(x=>d(x));
            Console.WriteLine("number greater than five are in the list ");
            foreach(var output in query) {
                if (output < 5) {
                    Console.WriteLine(output);
                } else {
                    continue;
                }
            }
        }

        public int SmallerThanFive(int value) {
            if(value<5)
             return value;
            
               return 6;
        }

        //find three k – Delegate Object in Where –Lambda Expression in Constructor of Object
        public void ThreeK(List<int> element) {
            WhereDelegate del = (int value ) => value*3;
            var query = element.Select(x=>del(x));
            foreach (var output in query) {
                Console.WriteLine("output is " + output);
            }
        }

        // find three k+1 using  Delegate Object in Where –Anonymous Method in Constructor of Object
        public void FindThreekPlusOne(List<int> element) {
            WhereDelegate del = delegate (int value) {
                return (value * 3) + 1;
            };
            var query = element.Select(x =>del(x));
            
            foreach (var output in query) {
                Console.WriteLine("output is " + output);
            }
        }       
    }
}