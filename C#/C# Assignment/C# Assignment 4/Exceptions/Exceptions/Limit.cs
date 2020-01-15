using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions {

    class Limit : Exception {
        public Limit(string message): base (message)
        {

        }
    }
}