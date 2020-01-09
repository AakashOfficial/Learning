using System;

namespace EquipmentAssignmentExtend {

    class EquipmentMain {

        static void Main(string[] args) {
           
            // varible used to calculate no of equipment
            int mobileCount = 0;
            int immobileCount = 0;
            int selectEquipment;
            string temp;

            // object through dynameic slicing
            Equipment equipment1 = new Mobile();
            Equipment equipment2 = new Immobile();

            //to check whether used does not input wrong input
            do {
                var equipmentTypeValue1 = equipmentType.Mobile;
                var equipmentTypeValue2 = equipmentType.Immobile;
                Console.WriteLine("Enter Type of Equipment");
                while (true) // check whether input is correct
                {
                    Console.WriteLine("Press 1 fo Mobile and 2 for ImMobile");
                    selectEquipment = Convert.ToInt32(Console.ReadLine());
                    if (selectEquipment == (int)equipmentTypeValue1) {
                        equipment1.GetInput();
                        equipment1.GetData();
                        equipment1.UpdateDistance(equipment1.inputDistance);
                        equipment1.ShowOutput();
                        mobileCount++;
                        break;
                    }else if (selectEquipment == (int)equipmentTypeValue2) {
                        equipment2.GetInput();
                        equipment2.GetData();
                        equipment2.UpdateDistance(equipment2.inputDistance);
                        equipment2.ShowOutput();
                        immobileCount++;
                        break;
                    } else {
                        Console.WriteLine("Enter Again");
                        continue;
                    }
                }

                Console.WriteLine("Total No of Mobile equipment " + mobileCount);
                Console.WriteLine("Total No of imMobile equipment " + immobileCount);
                Console.WriteLine("Do you wnat to continue [y/n]");
                temp = Console.ReadLine();
            } while (temp == "y");

        }
    }
}
