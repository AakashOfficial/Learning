using System;

namespace DuckAssignment {

    // MallardBird implemement interface and override the fly and quack method of DuckFunction interface
    class MallardBird : DuckFunction {

        public void fly() {
            Console.WriteLine("Mallard Birl Fly Very Fast");
        }

        public void Quack() {
            Console.WriteLine("Mallard Bird Quack Louder");
        }
    }
}