using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class LibrarySystem
    {
        private Repository<Book> books = new Repository<Book>();
        private Repository<Member> members = new Repository<Member>();

        private Dictionary<int, List<string>> borrowedBooks = new Dictionary<int, List<string>>();

        public event Action<string> BookBorrowed;
        public event Action<string> BookReturned;

        public void AddBook(Book book)
        {
            books.AddItem(book);
        }

        public void AddMember(Member member)
        {
            members.AddItem(member);
            borrowedBooks[member.ID] = new List<string>();
        }

        public void BorrowBook(int memberId, string isbn)
        {
            Book book = books.RetrieveAll().FirstOrDefault(b => b.ISBN.Equals(isbn));
            if (book == null || !book.IsAvailable)
                throw new BookNotAvailableException($"Book with ISBN {isbn} is not available.");

            Member member = members.RetrieveAll().FirstOrDefault(x => x.ID == memberId);
            if (member == null)
                throw new Exception($"Member with ID {memberId} is not a member!");


            if (member.MembershipType.Equals("student") && (int)member.BorrowingِAmount > borrowedBooks[memberId].Count ||
                member.MembershipType.Equals("faculty") && (int)member.BorrowingِAmount > borrowedBooks[memberId].Count)
                throw new MembershipLimitExceededException($"Member with ID {memberId} has exceeded borrowing limit.");

            book.IsAvailable = false;
            borrowedBooks[memberId].Add(isbn);
            BookBorrowed?.Invoke(book.Title);
        }

        public void ReturnBook(int memberId, string isbn)
        {
            Book book = books.RetrieveAll().FirstOrDefault(b => b.ISBN.Equals(isbn));
            if (book == null || !book.IsAvailable)
                throw new BookNotAvailableException($"Book with ISBN {isbn} is not available.");

            Member member = members.RetrieveAll().FirstOrDefault(x => x.ID == memberId);
            if (member == null)
                throw new Exception($"Member with ID {memberId} is not a member!");

            book.IsAvailable = true;
            borrowedBooks[memberId].Remove(isbn);
            BookReturned?.Invoke(book.Title);
        }

    }
}
