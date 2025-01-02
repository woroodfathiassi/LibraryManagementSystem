using Library_Management_System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("worood assi");

        //var librarySystem = new LibrarySystem();

        //// Adding Managers
        //var manager1 = new Manager { ID = 1, Name = "Manager1" };
        //var manager2 = new Manager { ID = 2, Name = "Manager2" };

        //librarySystem.BookBorrowed += manager1.OnBookBorrowed;
        //librarySystem.BookBorrowed += manager2.OnBookBorrowed;
        //librarySystem.BookReturned += manager1.OnBookReturned;
        //librarySystem.BookReturned += manager2.OnBookReturned;

        //// Adding Books
        //librarySystem.AddBook(new Book { Title = "C# Basics", Author = "John Doe", ISBN = "123" });
        //librarySystem.AddBook(new Book { Title = "Advanced C#", Author = "Jane Doe", ISBN = "456" });
        //librarySystem.AddBook(new Book { Title = "Data Structures", Author = "Alice", ISBN = "789" });
        //librarySystem.AddBook(new Book { Title = "Algorithms", Author = "Bob", ISBN = "101112" });

        //// Adding Members
        //librarySystem.AddMember(new Member { ID = 1, Name = "Ahmad", MembershipType = MembershipType.student, BorrowingِAmount = BorrowingLimit.student });
        //librarySystem.AddMember(new Member { ID = 2, Name = "Rami", MembershipType = MembershipType.faculty, BorrowingِAmount = BorrowingLimit.student });
        //librarySystem.AddMember(new Member { ID = 3, Name = "Marah", MembershipType = MembershipType.student, BorrowingِAmount = BorrowingLimit.student });

        //// Borrowing and Returning Books
        //try
        //{
        //    librarySystem.BorrowBook(1, "123"); // Ahmad borrows C# Basics
        //    librarySystem.BorrowBook(2, "456"); // Rami borrows Advanced C#
        //    librarySystem.BorrowBook(2, "789"); // Rami borrows Data Structures

        //    librarySystem.BorrowBook(3, "123"); // Marah tries to borrow C# Basics (fails)
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        //try
        //{
        //    librarySystem.BorrowBook(1, "101112"); // Ahmad borrows Algorithms
        //    librarySystem.BorrowBook(1, "789"); // Ahmad tries to borrow Data Structures (fails)
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        //try
        //{
        //    librarySystem.BorrowBook(99, "123"); // Non-existent member tries to borrow a book
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        //// Returning Books
        //librarySystem.ReturnBook(1, "123"); // Ahmad returns C# Basics
        //librarySystem.ReturnBook(2, "456"); // Rami returns Advanced C#

        //// Reattempt Borrowing
        //try
        //{
        //    librarySystem.BorrowBook(3, "123"); // Marah borrows C# Basics successfully
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
    }
}