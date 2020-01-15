using System;

namespace EquipmentAssignmentExtend {

    public class Mobile : Equipment {
        private int _numberOfWheels;
        
        // it is a constructor for making maintenacece cost and distancecost initialize as 0
        public Mobile() {
            maintenanceCost = 0;
            distanceMoved = 0;
        }

        /*
         *This function override getdata function of equipment class and tkaes the input
         * It takes noofwheels and inputdistance as input 
         */
        public override void UpdateDistance() {
            Console.WriteLine("Enter wheel");
            _numberOfWheels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter distance to be moved");
            inputDistance = Convert.ToInt32(Console.ReadLine());

            this.distanceMoved+=inputDistance;
            this.maintenanceCost = _numberOfWheels * distanceMoved;
        }

        // this function is used to get maintainance cost and totaldistance moved
        public override void ShowUpdatedDistance() {
            Console.WriteLine("Total Distance Moved :  " + this.distanceMoved);
            Console.WriteLine("Total  Maintenance Cost :  " + this.maintenanceCost);
        }
    }        
}

