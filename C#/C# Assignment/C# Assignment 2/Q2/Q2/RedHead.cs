using System;

namespace DuckAssignment {

    // RedHead implemement interface and override the fly and quack method of DuckFunction interface
    class RedHead : IDuck {

        public void fly() {
            Console.WriteLine("RedHead Birl Fly slow");
        }

        public void Quack() {
            Console.WriteLine("RedHead Bird Quad Mild");
        }
    }
}