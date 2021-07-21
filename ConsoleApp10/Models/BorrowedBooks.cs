using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Models
{
    public class BorrowedBooks
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int ClientId { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool Returned { get; set; }
    }
}
