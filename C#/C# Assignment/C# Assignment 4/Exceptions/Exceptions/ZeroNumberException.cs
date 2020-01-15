using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions {

    class ZeroNumberException : Exception {

        // this class inherit exception class and help me for creating custom exception
        public ZeroNumberException(string message) : base(message)
        {

        }
    }
}