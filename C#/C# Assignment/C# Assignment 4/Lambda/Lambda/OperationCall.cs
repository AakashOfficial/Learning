using System;
using System.Collections.Generic;

namespace LamdaAndDelegate {

    class OperationCall {

        public void OperationCheck(int inputCheck) {
            
            List<int> element = new List<int>();
            for(int number=1;number<=100;number++) {
                element.Add(number);
            }
            Operationperform operaPerform = new Operationperform();

            switch (inputCheck) {
                case 1:
                    operaPerform.FindOdd(element);
                    break;

                case 2:
                    operaPerform.FindEven(element);
                    break;

                case 3:
                    operaPerform.FindPrime(delegate(List<int> elements) {
                        int flag;
                        foreach(var output in elements) {
                            flag = 0;
                            if (output>2) {
                                for (int i=2;i<=output/2;i++) {
                                    if(output%i==0) {
                                        flag = 1;
                                        break;
                                    }
                                }
                                if(flag==0) {
                                    Console.WriteLine("Prime nuumber is {0}",output);
                                }
                            }
                            flag = 0;
                        }
                    }
                    , element);
                    break;

                case 4:
                    operaPerform.FindPrimeTwo(element);
                    break;

                case 5:
                    operaPerform.FindGreaterThanFive(element);
                    break;

                case 6:
                    operaPerform.FindSmallerThanFive(element);
                    break;

                case 7:
                    operaPerform.ThreeK(element);
                    break;
                            
                case 8:
                    operaPerform.FindThreekPlusOne(element);
                    break;
            }
        }
    }
}