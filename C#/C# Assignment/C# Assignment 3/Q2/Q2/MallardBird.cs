using System;

namespace DuckExtend {

    // MallardBird implemement interface anf give body to fly and  quack
    class MallardBird : Duck, IDuckFeat {
        // Fly Function
        public void fly() {
            Console.WriteLine("Mallard Birl Fly Very Fast ");
        }

        // Quack Function
        public void Quack() {
            Console.WriteLine("Mallard Bird Quack Louder ");
        }
    }
}
