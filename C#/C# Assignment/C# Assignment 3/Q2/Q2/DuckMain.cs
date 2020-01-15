using System;
using System.Collections.Generic;
using System.Linq;

namespace DuckExtend {

    // program to print type of duck and their all details using oops concept
    class DuckMain {

        // main method
        static void Main(string[] args) {
                int choice;
                string check;

                DuckOperation duckOpr = new DuckOperation();
                do
                {
                    Console.WriteLine("1. Add a duck");
                    Console.WriteLine("2. Remove a duck");
                    Console.WriteLine("3. Remove all ducks");
                    Console.WriteLine("4. Sort ducks in increasing order of their weights");
                    Console.WriteLine("5. Sort ducks in increasing order of number of wings");
                    Console.WriteLine("6. List all ducks\n");

                    Console.WriteLine("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    duckOpr.DoDuckOperation(choice);

                    Console.WriteLine("Do you want to continue - y/n");
                    check = Console.ReadLine();
                } while (check == "y");
            }
        }
    }