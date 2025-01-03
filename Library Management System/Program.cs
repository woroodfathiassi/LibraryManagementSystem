using Library_Management_System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("worood assi");

        var librarySystem = new LibrarySystem();

        var manager1 = new Manager { ID = 1, Name = "Manager1" };
        var manager2 = new Manager { ID = 2, Name = "Manager2" };

        librarySystem.BookBorrowed += manager1.OnBookBorrowed;
        librarySystem.BookBorrowed += manager2.OnBookBorrowed;
        librarySystem.BookReturned += manager1.OnBookReturned;
        librarySystem.BookReturned += manager2.OnBookReturned;

        librarySystem.AddBook(new Book { Title = "C# Basics", Author = "Ahmad", ISBN = "123", IsAvailable = true });
        librarySystem.AddBook(new Book { Title = "Advanced C#", Author = "Ali", ISBN = "456", IsAvailable = true });
        librarySystem.AddBook(new Book { Title = "Data Structures", Author = "Jad", ISBN = "789", IsAvailable = true });
        librarySystem.AddBook(new Book { Title = "Algorithms", Author = "Noor", ISBN = "Algorithms", IsAvailable = true });

        librarySystem.AddMember(new Member { ID = 1, Name = "Ahmad", MembershipType = MembershipType.student, BorrowingِAmount = BorrowingLimit.student });
        librarySystem.AddMember(new Member { ID = 2, Name = "Rami", MembershipType = MembershipType.faculty, BorrowingِAmount = BorrowingLimit.faculty });
        librarySystem.AddMember(new Member { ID = 3, Name = "Marah", MembershipType = MembershipType.student, BorrowingِAmount = BorrowingLimit.student });

        try
        {
            librarySystem.BorrowBook(1, "123");
            librarySystem.BorrowBook(2, "456"); 
            librarySystem.BorrowBook(2, "789"); 

            librarySystem.BorrowBook(3, "123"); 
        }
        catch (BookNotAvailableException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        try
        {
            librarySystem.BorrowBook(1, "101112"); 
            librarySystem.BorrowBook(1, "789");   
        }
        catch (MembershipLimitExceededException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        try
        {
            librarySystem.BorrowBook(99, "123");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        librarySystem.ReturnBook(1, "123"); 
        librarySystem.ReturnBook(2, "456"); 

        try
        {
            librarySystem.BorrowBook(3, "123");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }    
}