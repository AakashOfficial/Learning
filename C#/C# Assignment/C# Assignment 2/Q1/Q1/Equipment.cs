using System;

namespace EquipmentAssignment
{
 
    /**
     * it is a abstract Equipment class 
     * which takes equipmentName, inputDistance,public string description,distanceMoved, maintenanceCost 
     * as input and have two function getdata and showdata and one abstract  update distance funtion
     */

    public enum equipmentType {
        Mobile = 1,
        Immobile = 2
    };

    public abstract class Equipment {

        // parameters for Equipment Class
        public string equipmentName;
        public int inputDistance;
        public string description;
        public int distanceMoved;
        public int maintenanceCost;
        public equipmentType eT;

        // Both getdata and updatedistance are abstract function
        public abstract void GetData();
        public abstract void UpdateDistance(int addDistance);

        // this functionUsed To take input of equipment name and equipment distance
        public void GetInput() {
            Console.WriteLine("Enter Name of Equipment");
            equipmentName = Console.ReadLine();
            Console.WriteLine("Enter Description of Equipment " + equipmentName);
            description = Console.ReadLine();
        }

        // this function showoutput shows all the detail like name ,description,distancemoved
        public void ShowOutput() {
            Console.WriteLine("Name of Equipment : " + equipmentName);
            Console.WriteLine("Description of Equipment '" + equipmentName + "' : " + description);
            Console.WriteLine("Total Distance Moved by Equipment '" + equipmentName  + "' : " + this.distanceMoved);
            Console.WriteLine("Total  Maintenance Cost of Equipment '" + equipmentName  + "' : " + this.maintenanceCost);
        }

        internal void UpdateDistance() {
            throw new NotImplementedException();
        }

    }
}