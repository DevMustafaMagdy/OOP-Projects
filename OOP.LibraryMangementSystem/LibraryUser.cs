using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.LibraryManagementSystem
{
    internal class LibraryUser : User
    {
        public LibraryCard Card { get; set; }

        public LibraryUser(string name)
        {
            Name = name;
        }
        public void BorrowBook(int bookNumber, Library library)
        {
            library.BorrowBook(bookNumber);
        }
    }
}
