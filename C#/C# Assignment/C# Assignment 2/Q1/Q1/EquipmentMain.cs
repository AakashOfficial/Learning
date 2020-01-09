using System;


namespace EquipmentAssignment {

    class EquipmentMain {

        static void Main(string[] args) {
           
            // varible used to calculate no of equipment
            int mobileCount = 0;
            int immobileCount = 0;
            int selectEquipment;
            string temp;

            // object through dynameic slicing
            Equipment equipmentMobile = new Mobile();
            Equipment equipmentImmobile = new Immobile();

            //to check whether used does not input wrong input
            do {
                var equipmentMobileType = equipmentType.Mobile;
                var equipmentImmobileType = equipmentType.Immobile;
                Console.WriteLine("Enter Type of Equipment");
                while (true) // check whether input is correct
                {
                    Console.WriteLine("Press 1 fo Mobile and 2 for ImMobile");
                    selectEquipment = Convert.ToInt32(Console.ReadLine());
                    if (selectEquipment == (int)equipmentMobileType) {
                        equipmentMobile.GetInput();
                        equipmentMobile.GetData();
                        equipmentMobile.UpdateDistance(equipmentMobile.inputDistance);
                        equipmentMobile.ShowOutput();
                        mobileCount++;
                        break;
                    }else if (selectEquipment == (int)equipmentImmobileType) {
                        equipmentImmobile.GetInput();
                        equipmentImmobile.GetData();
                        equipmentImmobile.UpdateDistance(equipmentImmobile.inputDistance);
                        equipmentImmobile.ShowOutput();
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
