using System;

namespace DuckAssignment {

    // enum declaration of various birds
    public enum Birdtype {
        Mallard = 1,
        RedHead = 2,
        Rubber = 3
    }

    // class duck is used to take name and type of duck
    class Duck
    {
        string duckName;
        int duckWeight;
        public Birdtype bT;

        // getdetail function used to get detail of duck
        public void GetDetail() {
            Console.WriteLine("Enter the name of Duck");
            duckName = Console.ReadLine();
            Console.WriteLine("Enter the Weight of Duck");
            duckWeight = Convert.ToInt32(Console.ReadLine());
        }

        // it is used to shpw the detail of duck
        public void ShowDetails() {
            Console.WriteLine("Name of Duck : " + duckName);
            Console.WriteLine("Weight of duck : " + duckWeight);
        }
    }
}