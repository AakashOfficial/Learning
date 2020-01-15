using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions {

    class OddNumberException : Exception {

        // this class inherit exception class and help me for creating custom exception
        public OddNumberException(string message) : base(message)
        {

        }
    }
}