using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EquipmentAssignmentExtend {

    class OperationPerformed {

        // Parameters Used in the class
        int selectEquipment;
        string temp;
        List<Equipment> equipmentList = new List<Equipment>();

        // object through dynameic slicing
        Equipment equipment1 = new Mobile();
        Equipment equipment2 = new Immobile();

        //function used to create equipment
        public void CreateEquipment() {
            //to check whether used does not input wrong input
            do {
                var equipmentMobile = equipmentType.Mobile;
                var equipmentImmobile = equipmentType.Immobile;
                Console.WriteLine("Enter Type of Equipment");
                // check whether input is correct
                while (true) {
                    Console.WriteLine("Press 1 fo Mobile and 2 fo ImMobile");

                    selectEquipment = Convert.ToInt32(Console.ReadLine());
                    if (selectEquipment == (int)equipmentMobile) {
                        equipment1.GetInput();
                        equipmentList.Add(equipment1);
                        break;
                    }else if (selectEquipment == (int)equipmentImmobile) {
                        equipment2.GetInput();
                        equipmentList.Add(equipment2);
                        break;
                    } else {
                        Console.WriteLine("Enter Again");
                        continue;
                    }
                }
                Console.WriteLine("Do you wnat to continue [y/n]");
                temp = Console.ReadLine();
            } while (temp == "y");
        }

        // this function is used to remove the element
        public void RemoveEquipment() {
            Console.WriteLine("Enter equipment name which you want to delete-");
            String Equipmentname = Console.ReadLine();
            equipmentList = equipmentList.Except(equipmentList.Where(x => x.equipmentName == Equipmentname)).ToList();
            Console.WriteLine("element removed");
        }

        // this function is used to move the element
        public void MoveEquipment() {
            //to check whether used does not input wrong input
            do {
                var equipmentMobile = equipmentType.Mobile;
                var equipmentImmobile = equipmentType.Immobile;
                Console.WriteLine("Enter Type of Equipment");
                // check whether input is correct
                while (true) {
                    Console.WriteLine("Press 1 fo Mobile and 2 fo ImMobile");
                    selectEquipment = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter equipment name which you want to move the equipment-");
                    string Equipmentname = Console.ReadLine();
                    if (selectEquipment == (int)equipmentMobile) {
                        bool output = equipmentList.Any(x=>x.equipmentName==Equipmentname);
                       // Console.WriteLine
                        if (output==false) {
                            Console.WriteLine("element not present");
                        } else {
                            equipment1.UpdateDistance();
                        }
                        equipmentList.Remove(equipment1);
                        equipmentList.Add(equipment1);
                        break;
                    }
                    if (selectEquipment == (int)equipmentImmobile) {
                        bool output = equipmentList.Any(x => x.equipmentName == Equipmentname);
                        
                        if (output==false) {
                            Console.WriteLine("element not present");
                        } else {
                            equipment2.UpdateDistance();
                        }
                        equipmentList.Remove(equipment2);
                        equipmentList.Add(equipment2);
                    } else {
                        Console.WriteLine("Enter Again");
                        continue;
                    }
                }
                Console.WriteLine("Do you wnat to continue [y/n]");
                temp = Console.ReadLine();
            } while (temp == "y");
        }

        // this function is used to know the basic detail
        public void ListEquipment() {
            foreach(Equipment e in equipmentList) {
                Console.WriteLine("Name is " + e.equipmentName + "  " + "\nDecription is " + e.description);
            }
        }
        
        //this function is used to know the detail of equipment         
        public void   Equipmentdetail() {
            Console.WriteLine("Enter equipment name which you want to show detail");
            String Equipmentname = Console.ReadLine();
            var output = equipmentList.Where(num => num.equipmentName==Equipmentname);
            foreach (var s in output) {
                s.ShowOutput();
                s.ShowUpdatedDistance();
            }
        }

        // this function is used to show all mobile element
        public void ListMobile() {
            var output = equipmentList.Except(equipmentList.Select(num=>equipment2));
            foreach(var s in output) {
                Console.WriteLine("Name is "+s.equipmentName + "  " +"\nDecription is " +s.description);
            }
        }

        // this element is used to show all immmobile element
        public void ListImmobile() {
            var output = equipmentList.Except(equipmentList.Select(num => equipment1));
            foreach (var s in output) {
                Console.WriteLine("Name is " + s.equipmentName + "  " + "\nDecription is " + s.description);
            }
        }

        // this element is used to delete all element
        public void DeleteAllEquipment() {
            equipmentList.RemoveAll(x=>(x.et== equipmentType.Immobile&& x.et == equipmentType.Immobile ));
            Console.WriteLine("All element are deleted");
        }

        // it is used to delete all immobile equipment
        public void DeleteImmobile() {
            equipmentList.RemoveAll(x => x.et == equipmentType.Immobile);
            Console.WriteLine("All imMobile  ar deleted");
        }

        // this is used to remove all mobilw equipment
        public void DeleteMobile() {
            equipmentList.RemoveAll(x => x.et == equipmentType.Mobile);
            Console.WriteLine("All ImMobile  are deleted");
        }
    }
}
