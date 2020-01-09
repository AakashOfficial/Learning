using System;

namespace EquipmentAssignmentExtend {

    class EquipmentMain {

        static void Main(string[] args) {
            int requiredoperation;
            EquipmentOperation ti = new EquipmentOperation();

            char yes = 'Y';
            //to check whether used does not input wrong input
            do {
                Console.WriteLine("1.Create an equipment-Mobile and Immobile");
                Console.WriteLine("2.Delete an equipment");
                Console.WriteLine("3.Move an equipment");
                Console.WriteLine("4.List of all equipment");
                Console.WriteLine("5.Show detail of equipment");
                Console.WriteLine("6 list all mobile equipment");
                Console.WriteLine("7.List all immobile equipment");
                Console.WriteLine("8.List all equipment that have not been moved till now");
                Console.WriteLine("9.Delete all equipment");
                Console.WriteLine("10 delete all mobile equipment");
                Console.WriteLine("11 delete all Immobile equipment");
                
                Console.WriteLine();
                Console.WriteLine("select your choice");
                requiredoperation = Convert.ToInt32(Console.ReadLine());
                ti.EquipmentOperation1(requiredoperation);
                // equipmentoperation.EquipmentOperation1(requiredoperation);
                Console.WriteLine("Want to Continue to do more operations?Enter Y for yes/N for No");
                yes = Char.Parse(Console.ReadLine());
            } while (yes != 'N');

        }
    }
}