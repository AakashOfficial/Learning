﻿using System;

namespace EquipmentAssignment {

    public class Mobile : Equipment {
        private int _numberOfWheels;

        // it is a constructor for making maintenacece cost and distancecost as 0
        public Mobile() {
            maintenanceCost = 0;
            distanceMoved = 0;
        }

        /**
         * This function override getdata function of equipment class and tkaes the input
         * It takes noofwheels and inputdistance as input 
         */
        public override void GetData() {

            Console.WriteLine("Enter wheel ");
            _numberOfWheels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter distance to be moved");
            inputDistance = Convert.ToInt32(Console.ReadLine());

        }

        /**
         * this function is used to get maintainance cost and totaldistance moved
         * @param addDistance;
         * it is a parameter through which the distance of equipment evaluated
         */
        public override void UpdateDistance(int addDistance) {
            this.distanceMoved += addDistance;
            this.maintenanceCost = _numberOfWheels * distanceMoved;
        }
    }
}