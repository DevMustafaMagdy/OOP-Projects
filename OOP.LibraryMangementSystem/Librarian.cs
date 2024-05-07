using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.LibraryManagementSystem
{
    internal class Librarian : User
    {
        public int EmployeeNumber { get; set; }

        public Librarian(string name)
        {
            Name = name;
        }

        public void AddBook(Book newBook, Library library)
        {
            library.Add(newBook);
        }
        public void RemoveBook(int bookNumber, Library library)
        {
            library.Remove(bookNumber);
        }
    }
}
