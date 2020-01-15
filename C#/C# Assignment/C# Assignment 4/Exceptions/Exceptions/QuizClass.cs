using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions {

    /*
     * class is used to check whether user input in the correct format
     * this has two function one is getdata and second is showdata
     */
    class QuizClass {

        int negativeNumber;
        int evenNumber;
        int oddNumber;
        int primeNumber;
        int zeroNumber;
        int tempNumber;

        // this is getdata function to take input
        public   int  GetData(int inputNumber) {
            //switch help in taking input
            switch (inputNumber) {
                case 1:
 evenGo:            Console.WriteLine("Enter a even Number");
                    try {
                        evenNumber = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception e) {
                        Console.WriteLine("Invalid input");
                    }
                    
                    try {
                        if(evenNumber%2!=0) {
                            throw new EvenNumberException("Invalid even number");
                        }
                    } catch (EvenNumberException e) {
                        Console.WriteLine(e.Message);
                        goto evenGo;                    
                    }

                    tempNumber = evenNumber;
                    break;
                case 2:
 oddGo:             Console.WriteLine("Enter a odd Number");
                    try {
                        oddNumber = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception e) {
                        Console.WriteLine("Invalid input");
                    }
                   
                    try {
                        if (oddNumber % 2 == 0) {
                            throw new OddNumberException("Invalid  odd number");
                        }
                    } catch (OddNumberException e) {
                        Console.WriteLine(e.Message);
                        goto oddGo;
                    }
                    tempNumber = oddNumber;
                    break;
                case 3:

 primeGo:           Console.WriteLine("Enter a prime Number");
                    try {
                        primeNumber = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception e) {
                        Console.WriteLine("Invalid input");
                    }
                    
                    try {
                        for (int number = 2; number <= primeNumber / 2; number++) {
                            if (primeNumber % number == 0) {
                                throw new PrimeNumberException("Invalid  prime number");
                            }
                        }
                    } catch (PrimeNumberException e) {
                        Console.WriteLine(e.Message);
                        goto primeGo;
                    }
                    tempNumber = primeNumber;
                    break;

                case 4:

zeroGo:             Console.WriteLine("Enter a zero Number");
                    try {
                        zeroNumber = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception e) {
                        Console.WriteLine("Invalid input");
                    }
                    
                   try {
                        if (zeroNumber != 0) {
                            throw new ZeroNumberException("Invalid  zero number");
                        }
                    } catch (ZeroNumberException e) {
                        Console.WriteLine(e.Message);
                        goto zeroGo;
                    }
                    tempNumber = zeroNumber;
                    break;
                case 5:
negativeGo:         Console.WriteLine("Enter negative  Number");
                    try {
                        negativeNumber = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception e) {
                        Console.WriteLine("Invalid input");
                    }
                    
                    try {
                        if (negativeNumber> 0) {
                            throw new NegativeNumberException("Invalid  negative number");
                        }
                    } catch (NegativeNumberException e) {
                        Console.WriteLine(e.Message);
                        goto negativeGo;
                    }
                    tempNumber = negativeNumber;
                    break;
            }
            return tempNumber;
        }

        // showdatafunction to get the output of user
        public void ShowData(int outputData) {
            Console.WriteLine("Output Number is :  " + outputData);
        }
    }
}