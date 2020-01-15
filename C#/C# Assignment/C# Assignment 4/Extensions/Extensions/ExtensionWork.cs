using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions {

    // this is a extension class which define isNegative funtion
    class ExtensionWork {

       //to check whether number is negative
        public void IsNegative(int negativeNumber) {
            if(negativeNumber<0) {
                Console.WriteLine("It is a negative number");
            } else {
                Console.WriteLine("It is not a negative number");
            }
        }
    }
}