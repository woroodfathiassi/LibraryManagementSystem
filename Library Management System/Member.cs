using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System { 

    public enum BorrowingLimit
    {
        student = 3,
        faculty = 5
    }

    public enum MembershipType
    {
        student,
        faculty
    }


    internal class Member : Person
    {
        public MembershipType MembershipType { get; set; } // student, Faculty
        public BorrowingLimit BorrowingِAmount { get; set; } // Students can borrow up to 3 books, Faculty can borrow up to 5 books
    }
}
