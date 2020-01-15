using System;
using System.Collections.Generic;
using System.Linq;

namespace LamdaAndDelegate {

    class LamdaMainClass {

        static void Main(string[] args) {
            string check;
            int inputCheck;
            OperationCall OperCall = new OperationCall();
            do {
                Console.WriteLine("Press 1 for find odd from list of 100 elements");
                Console.WriteLine("Press 2 for find even list of 100 elements");
                Console.WriteLine("Press 3 for find prime list of 100 elements");
                Console.WriteLine("Press 4 for find prime using lambda expression list of 100 elements");
                Console.WriteLine("Press 5 for find element greater than fivelist of 100 elements ");
                Console.WriteLine("Press 6 for find element smaller than fivelist of 100 elements ");
                Console.WriteLine("Press 7 for find 3 * k list of 100 elements");
                Console.WriteLine("Press 8 for find 3k+1 list of 100 elements");
                inputCheck = Convert.ToInt32(Console.ReadLine());
                OperCall.OperationCheck(inputCheck);
                Console.WriteLine("do you want to perform more operation [y/n]");
                check = Console.ReadLine();
            } while(check=="y");
        }
    }
}