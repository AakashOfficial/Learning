using System;
using System.Collections.Generic;
using System.Linq;

namespace DuckExtend {

    class PerformOperation {
        int type;
        List<Duck> list = new List<Duck>();

        // objects through dynamic slicing
        Duck rubberDuck = new RubberBird();
        Duck mallardDuck = new MallardBird();
        Duck readheadDuck = new RedHead();

        // method to add a duck
        public void AddDuck()
        {
            Console.WriteLine("\nYou have selected : Add Duck\n");

            // use of var keyword for ease
            var rubberBird = Birdtype.Rubber;
            var mallardBird = Birdtype.Mallard;
            var redheadBird = Birdtype.RedHead;

            Console.WriteLine("Press 1 for Mallard Duck, 2 for Redhead Duck and 3 for Rubber Duck");

            type = Convert.ToInt32(Console.ReadLine());

            if(type == (int)rubberBird) {
                Console.WriteLine("You have selected : Rubber Duck");
                rubberDuck.GetDetail();
                list.Add(rubberDuck);
                Console.WriteLine("Rubber Duck added");
            } else if(type == (int)mallardBird) {
                Console.WriteLine("You have selected : Mallard Duck");
                mallardDuck.GetDetail();
                list.Add(mallardDuck);
                Console.WriteLine("Mallard Duck added");
            } else if(type == (int)redheadBird) {
                Console.WriteLine("You have selected : Redhead Duck");
                readheadDuck.GetDetail();
                list.Add(readheadDuck);
                Console.WriteLine("Redhead Duck added");
            }

        }

        // method to remove a duck
        public void RemoveDuck() {
            Console.WriteLine("\nYou have selected : Remove Duck\n");
            Console.WriteLine("Enter the name of duck which you want to remove");
            string duckToRemove = Console.ReadLine();
            list.RemoveAll(x => x.duckName == duckToRemove);
            Console.WriteLine("Duck removed");
        }

        // method to remove all ducks
        public void RemoveAllDucks() {
            Console.WriteLine("\nYou have selected : Remove all ducks\n");
            list.RemoveAll(x => (x.Equals(Birdtype.Rubber) && x.Equals(Birdtype.Mallard) && x.Equals(Birdtype.RedHead)));
            Console.WriteLine("All ducks removed");
        }

        // method to sort all ducks in increasing order of their weights
        public void SortDuckWeightInc() {
            Console.WriteLine("\nYou have selected : Sort Ducks by Weight\n");
            var sortByDuckWeight = list.OrderBy(x => x.duckWeight);
            foreach (var i in sortByDuckWeight)
                Console.WriteLine("Name : " + i.duckName + "    Weight : " + i.duckWeight);
            Console.WriteLine();
        }

        // method to sort all ducks in increasing order of number of wings
        public void SortDuckWingsInc() {
            Console.WriteLine("\nYou have selected : Sort Ducks by Wings\n");
            var sortDuckWings = list.OrderBy(x => x.numberOfWings);
            foreach (var i in sortDuckWings)
                Console.WriteLine("Name : " + i.duckName + "    Wings : " + i.numberOfWings);
            Console.WriteLine();
        }

        // method to list all ducks
        public void ListAllDucks() {
            Console.WriteLine("\nYou have selected : List all ducks\n");
            foreach (var i in list)
                Console.WriteLine(i.duckName);
            Console.WriteLine();
        }
    }
}