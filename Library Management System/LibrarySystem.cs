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
            var book = books.RetrieveAll().FirstOrDefault(b => b.ISBN == isbn);
            if (book == null || !book.IsAvailable)
                throw new BookNotAvailableException($"Book with ISBN {isbn} is not available.");

            var member = members.RetrieveAll().FirstOrDefault(m => m.ID == memberId);
            if (member == null)
                throw new Exception($"Member with ID {memberId} does not exist.");

            if (borrowedBooks[memberId].Count >= (int)member.BorrowingِAmount)
                throw new MembershipLimitExceededException($"Member with ID {memberId} has exceeded the borrowing limit.");

            book.IsAvailable = false;
            borrowedBooks[memberId].Add(isbn);
            BookBorrowed?.Invoke(book.Title);
        }

        public void ReturnBook(int memberId, string isbn)
        {
            var book = books.RetrieveAll().FirstOrDefault(b => b.ISBN == isbn);
            if (book == null)
                throw new Exception($"Book with ISBN {isbn} does not exist.");

            if (!borrowedBooks.ContainsKey(memberId) || !borrowedBooks[memberId].Contains(isbn))
                throw new Exception($"Member with ID {memberId} has not borrowed this book.");

            book.IsAvailable = true;
            borrowedBooks[memberId].Remove(isbn);
            BookReturned?.Invoke(book.Title);
        }

        public Book SearchBooksByTitle(string title)
        {
            Book book = books.RetrieveAll().Select(b => b.Title.Equals(title) ? b : null).FirstOrDefault();
            return book == null ? null : book; 
        }

        public List<Book> SearchBooksByAuthor(string author)
        {
            return books.RetrieveAll().Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

    }
}
