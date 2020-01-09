using System;

namespace DuckAssignment {

    // Rubberbird implemement interface and override the fly and quack method of DuckFunction interface
    class RubberBird : IDuck {

        public void fly() {
            Console.WriteLine("Rubber Bird Don,t Fly");
        }

        public void Quack() {
            Console.WriteLine("Rubber bird Don,t Quack");
        }
    }
}
