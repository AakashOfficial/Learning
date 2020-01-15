using System;

namespace DuckExtend {

    // Rubberbird implemement interface anf give body to fly and  quack
    class RubberBird : Duck, IDuckFeat {
        // Fly Function
        public void fly() {
            Console.WriteLine("Rubber Bird Don,t Fly ");
        }

        // Quack Function
        public void Quack() {
            Console.WriteLine("Rubber bird Don,t Quack ");
        }
    }
}
