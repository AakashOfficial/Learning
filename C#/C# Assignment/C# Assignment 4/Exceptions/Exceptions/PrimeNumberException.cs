using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions {
    
    class PrimeNumberException : Exception {

        // this class inherit exception class and help me for creating custom exception
        public PrimeNumberException(string message) : base(message)
        {

        }
    }
}