using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions {

    // this class inherit exception class and help me for creating custom exception
    class EvenNumberException : Exception {
        public EvenNumberException(string message): base(message)
        {

        }
    }
}