using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentAssignmentExtend {
    class EquipmentOperation {
        OperationPerformed Operationperformed = new OperationPerformed();
       
        public void EquipmentOperation1(int requiredoperation) { 

            switch (requiredoperation) {

                case 1:
                    Operationperformed.CreateEquipment();
                    break;
                case 2:
                    Operationperformed.RemoveEquipment();
                    break;
                case 3:
                    Operationperformed.MoveEquipment();
                    break;
                case 4:
                    Operationperformed.ListEquipment();
                    break;
                case 5:
                    Operationperformed.Equipmentdetail();
                    break;
                case 6:
                    Operationperformed.ListMobile();
                    break;
                case 7:
                    Operationperformed.ListImmobile();
                    break;
                case 9:
                    Operationperformed.DeleteAllEquipment();
                    break;
                case 10:
                    Operationperformed.DeleteImmobile();
                    break;
                case 11:
                    Operationperformed.DeleteMobile();
                    break;

                default:
                    Console.WriteLine("Enter correct option");
                    break;

            }

        }

    }
}
