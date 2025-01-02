using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class BookNotAvailableException : Exception
    {
        public BookNotAvailableException(string message) : base(message) { }
    }
}
