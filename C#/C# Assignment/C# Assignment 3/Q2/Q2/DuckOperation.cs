using System;
using System.Collections.Generic;

namespace DuckExtend {

    class DuckOperation {

        PerformOperation performOperation = new PerformOperation();

        public void DoDuckOperation(int choice) {

            switch (choice) {
                case 1: performOperation.AddDuck();
                    break;

                case 2: performOperation.RemoveDuck();
                    break;

                case 3: performOperation.RemoveAllDucks();
                    break;

                case 4: performOperation.SortDuckWeightInc();
                    break;

                case 5: performOperation.SortDuckWingsInc();
                    break;

                case 6: performOperation.ListAllDucks();
                    break;

                default: Console.WriteLine("Wrong Input");
                    break;
            }
        }
    }
}
