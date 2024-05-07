using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.LibraryManagementSystem
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}");
        }
    }
}
