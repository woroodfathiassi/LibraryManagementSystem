using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal static class MyExtensions
    {
        public static List<Book> AvailableBooks(this Repository<Book> bookRepository)
        {
            return bookRepository.RetrieveAll().Where(b => b.IsAvailable).ToList();
        }

        public static List<string> GetAllBorrowedBooks(this int memberId, Dictionary<int, List<string>> borrowedBooksb)
        {
            if (borrowedBooksb.ContainsKey(memberId))
            {
                return borrowedBooksb[memberId];
            }
            return new List<string>();
        }
    }
}
