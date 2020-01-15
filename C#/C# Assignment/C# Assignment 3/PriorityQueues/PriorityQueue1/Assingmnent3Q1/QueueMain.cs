using System;
using System.Collections.Generic;

namespace PriorityQueue {

    class QueuemMain {

        // it is main method in which we call all function of pritority queue
        static void Main(string[] args) {

            int priorityElement;
            int key;
            int value;
            int takeInput;
            string continueCheck;
            PriorityQueue<int> processQueue = new PriorityQueue<int>();
            PriorityQueue<int> processQueue1 = new PriorityQueue<int>( new Dictionary<int,List<int>>());

            do {
                Console.WriteLine("press 1 to insert a element in priorit queue");
                Console.WriteLine("press 2 to remove a element in priorit queue");
                Console.WriteLine("press 3 to check whether  a element is in priorit queue or not");
                Console.WriteLine("press 4 to know the peek  element in priorit queue");
                //to perform which operation of queue
                takeInput = Convert.ToInt32(Console.ReadLine());
                switch (takeInput) {
                    //to insert element in queue
                    case 1:
                        Console.WriteLine("Enter the number of element you want to insert in a  priority queue");
                        priorityElement = Convert.ToInt32(Console.ReadLine());
                        for (int number = 0; number < priorityElement; number++) {
                            Console.WriteLine("Enter the item you want to insert");
                            key = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the priority of the element");
                            value = Convert.ToInt32(Console.ReadLine());
                            processQueue.Enqueue(key, value);
                        }
                        processQueue.Print();
                        break;
                    //to remove fro queue
                    case 2:
                        try {
                            processQueue.Dequeue();
                            processQueue.Print();
                        } catch (Exception e) {
                            Console.WriteLine("Cannot remove more element because of " + e.Message);
                        }

                        break;
                    //to check whether element is present or not
                    case 3:
                        Console.WriteLine("Enter the element you want to search");
                        priorityElement = Convert.ToInt32(Console.ReadLine());
                        bool present = processQueue.Contains(priorityElement);
                        if (present == true) {
                            Console.WriteLine("Element present");
                        } else {
                            Console.WriteLine("Element not present");
                        }
                        break;
                    //to check which element is present on the top of queue
                    case 4:
                        try {
                            Console.WriteLine("Element at the top is  " + processQueue.Peek());
                        } catch (Exception e) {
                            Console.WriteLine("Cannot find peek elemennt due to " + e.Message);
                        }
                            break;
                    default:
                        Console.WriteLine("Enter Again");
                        break;
                }
                Console.WriteLine("Do you wan to perfrom more operation [y/n]");
                continueCheck = Console.ReadLine();
            } while (continueCheck == "y");
        }
    }
}
