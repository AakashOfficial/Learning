using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentAssignmentExtend {
    class Immobile : Equipment {

        private int _equipmentWeight;

        // it is a constructor for making maintenacece cost and distancecost initialize as 0
        public Immobile() {
            maintenanceCost = 0;
            distanceMoved = 0;
        }

        /*
         *This function override getdata function of equipment class and tkaes the input
         * It takes equipmnetweight and inputdistance as input */
        public override void UpdateDistance() {
            Console.WriteLine("Enter Weight");
            _equipmentWeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter distance to be moved");
            inputDistance = Convert.ToInt32(Console.ReadLine());

            this.distanceMoved += inputDistance;
            this.maintenanceCost = distanceMoved * _equipmentWeight;
        }

        /*
         * this function is used to get maintainance cost and totalweight moved
         * it is a parameter through which the distance of equipment evaluated
         */
        public override void ShowUpdatedDistance() {
            Console.WriteLine("Total Distance Moved :  " + this.distanceMoved);
            Console.WriteLine("Total  Maintenance Cost :  " + this.maintenanceCost);
        }
    }
}
