namespace OOP.LibraryManagementSystem
{
    internal class Library
    {
        private List<Book> Books = new List<Book>();

        private List<Book> BorrowedBooks = new List<Book>();

        // Display Books
        public void Display()
        {
            Console.WriteLine("Choose display books (D) / display borrowed books(B)");
            var input = Console.ReadLine().ToUpper()[0];
            if (input == 'D')
            {
                if (Books.Count == 0)
                {
                    Console.WriteLine("Books list is empty!");
                    return;
                }
                Console.WriteLine("Books List:");
                for (var i = 0; i < Books.Count; i++)
                {
                    Console.Write($"Book {i + 1} -> ");
                    Books[i].Display();
                }
            }
            else if (input == 'B')
            {
                if (BorrowedBooks.Count == 0)
                {
                    Console.WriteLine("Borrowed Books list is empty!");
                    return;
                }
                Console.WriteLine("Borrowed Books List:");
                for (var i = 0; i < BorrowedBooks.Count; i++)
                {
                    Console.Write($"Book {i + 1} -> ");
                    BorrowedBooks[i].Display();
                }
            }
        }
        // Adding Books
        public void Add(Book book)
        {
            Books.Add(book);
            Console.WriteLine("Book Added Successfully");
        }
        // Removing Books
        public void Remove(int bookNumber)
        {
            if (bookNumber - 1 < Books.Count)
            {
                Books.Remove(Books[bookNumber - 1]);
                Console.WriteLine("Book Removed Successfully");
            }
            else
            {
                Console.WriteLine("Book is not exist");
            }
        }
        // Borrowing Books
        public void BorrowBook(int bookNumber)
        {
            if (bookNumber - 1 < Books.Count)
            {
                BorrowedBooks.Add(Books[bookNumber - 1]);
                Console.WriteLine("Book Borrowed Successfully");
            }
            else
            {
                Console.WriteLine("Book is not exist");
            }
        }
    }
}
