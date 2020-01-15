using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions {

    // this class inherit exception class and help me for creating custom exception
    class NegativeNumberException :Exception {
        public NegativeNumberException(string message) : base(message)
        {

        }
    }
}