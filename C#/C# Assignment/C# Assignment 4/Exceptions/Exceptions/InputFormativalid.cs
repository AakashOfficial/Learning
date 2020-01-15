using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions {

    // this class inherit exception class and help me for creating custom exception
    class InputFormativalid : Exception {
        public InputFormativalid(string message) : base(message)
        {
            

        }   
    }
}