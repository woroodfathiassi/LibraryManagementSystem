using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Manager : Person
    {
        public void OnBookBorrowed(string title)
        {
            Console.WriteLine($"Manager {Name} with ID({ID}) notified: Book {title} has been borrowed.");
        }

        public void OnBookReturned(string title)
        {
            Console.WriteLine($"Manager {Name} with ID({ID}) notified: Book {title} has been returned.");
        }
    }
}
