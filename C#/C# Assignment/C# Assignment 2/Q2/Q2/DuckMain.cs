using System;

namespace DuckAssignment {

    // main class which tells the bird details by performing different Operations
    class DuckMain {

        static void Main(string[] args) {

            // parameters
            int duckType;
            string temp;
            var mallard = Birdtype.Mallard;
            var redHead = Birdtype.RedHead;
            var rubber = Birdtype.Rubber;
            do // if user input wrong input
            {
                RedHead Rh = new RedHead();
                MallardBird Mb = new MallardBird();
                RubberBird Rb = new RubberBird();
                Duck selectDuck = new Duck();
                Console.WriteLine("Enter Type of Bird");
                while (true) // to select correct word
                {
                    Console.WriteLine("Press 1 for 'RedHead' Bird, 2 for 'Mallard' Bird and 3 for 'Rubber' Bird");
                    duckType = Convert.ToInt32(Console.ReadLine());
                    /// call all the function of mallard class
                    if (duckType == (int)mallard) {
                        selectDuck.GetDetail();
                        selectDuck.ShowDetails();
                        Mb.fly();
                        Mb.Quack();
                        break;
                    }
                    /// call all the function of redhead class
                    if (duckType == (int)redHead) {
                        selectDuck.GetDetail();
                        selectDuck.ShowDetails();
                        Rh.fly();
                        Rh.Quack();
                        break;
                    }

                    // call all the function of  rubber class
                    if (duckType == (int)rubber) {
                        selectDuck.GetDetail();
                        selectDuck.ShowDetails();
                        Rb.fly();
                        Rb.Quack();
                        break;
                    }
                }

                Console.WriteLine("Do you want to continue [y/n]");
                temp = Console.ReadLine();
            } while (temp == "y");
        }
    }
}
