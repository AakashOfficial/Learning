using System;
namespace DuckExtend {
    // RedHeard implemement interface anf give body to fly and  quack
    class RedHead :Duck, IDuckFeat {
        // Fly Function
        public void fly() {
            Console.WriteLine("RedHead Birl Fly slow ");
        }

        // Quack Function
        public void Quack() {
            Console.WriteLine("RedHead Bird Quad Mild ");
        }
    }
}
