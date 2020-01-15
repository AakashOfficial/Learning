using System;

namespace DuckExtend {

    // class duck is esed to tske name of duck and type of duck
    public enum Birdtype {
        Mallard = 1,
        RedHead = 2,
        Rubber = 3
    }

    class Duck {
        public string duckName;
        public int duckWeight;
        public int numberOfWings;
        public Birdtype Bt;

        // getdetail function used to get detail of duck
        public void GetDetail() {
            Console.WriteLine("Enter the name of Duck  ");
            duckName = Console.ReadLine();
            Console.WriteLine("Enter the Weight of Duck '" + duckName + "'");
            duckWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Wing of Duck '" + duckName + "'");
            numberOfWings = Convert.ToInt32(Console.ReadLine());
        }

        // it is used to shpw the detail of duck
        public void ShowDetails() {
            Console.WriteLine("Name of Duck  " + duckName);
            Console.WriteLine("Weight of duck '" + duckName + "'" + duckWeight);
            Console.WriteLine("Wing of duck  '" + duckName + "'" + numberOfWings);
        }
    }
}