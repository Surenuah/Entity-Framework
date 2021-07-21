using ConsoleApp10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AuthorBooks> authorBooks = new List<AuthorBooks>()
            {
                new AuthorBooks() { AuthorId = 1, BookId = 1 },
                new AuthorBooks() { AuthorId = 2, BookId = 2 },
                new AuthorBooks() { AuthorId = 3, BookId = 3}
            };

            List<Authors> authors = new List<Authors>()
            {
                new Authors() { AuthorId = 1, AuthorName = "Ergali Nuriden" },
                new Authors() { AuthorId = 2, AuthorName = "Dias Akbergen" },
                new Authors() { AuthorId = 3, AuthorName = "Kanat Zhumabekov" }
            };

            List<Books> books = new List<Books>()
            {
                new Books() { AuthorId = 1, BookId = 1, Description = "", Title = "" },
                new Books() { AuthorId = 2, BookId = 2, Description = "", Title = "" },
                new Books() { AuthorId = 3, BookId = 3, Description = "", Title = "" }
            };

            List<BorrowedBooks> borrowedBooks = new List<BorrowedBooks>()
            {
                new BorrowedBooks() { BookId = 1, BorrowedDate = DateTime.Now, ClientId = 1, ExpiryDate = DateTime.UtcNow, Id = 1, Returned = false },
                new BorrowedBooks() { BookId = 2, BorrowedDate = DateTime.Now, ClientId = 2, ExpiryDate = DateTime.UtcNow, Id = 2, Returned = true },
                new BorrowedBooks() { BookId = 3, BorrowedDate = DateTime.Now, ClientId = 3, ExpiryDate = DateTime.UtcNow, Id = 3, Returned = false }
            };

            List<Clients> clients = new List<Clients>()
            {
                new Clients() { ClientId = 1, IsOwe = true },
                new Clients() { ClientId = 2, IsOwe = false },
                new Clients() { ClientId = 3, IsOwe = true }
            };
        }
    }
}
