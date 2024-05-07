namespace OOP.LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the library system");
            Library library = new Library();

            while (true)
            {
                Console.Write("Are you librarian or regular user (L/R): ");

                char userType = Console.ReadLine().ToUpper()[0];
                if (userType == 'L')
                {
                    Console.Write("Welcome librarian, Enter your name: ");

                    var librarianName = Console.ReadLine();
                    Librarian librarian = new Librarian(librarianName);

                    Console.WriteLine($"Welcome {librarian.Name}");
                    while (true)
                    {
                        Console.WriteLine("Please choose to Add book (A) / Remove book (R) / Display book (D) / Back (Any Character)");

                        var librarianChoice = Console.ReadLine().ToUpper()[0];


                        if (librarianChoice == 'A')
                        {
                            Console.WriteLine("Please enter book details");
                            Console.Write("Title: ");
                            var bookTitle = Console.ReadLine();
                            Console.Write("Author: ");
                            var bookAuthor = Console.ReadLine();
                            Console.Write("Year: ");
                            var bookYear = int.Parse(Console.ReadLine());

                            Book book = new Book
                            {
                                Title = bookTitle,
                                Author = bookAuthor,
                                Year = bookYear
                            };

                            librarian.AddBook(book, library);
                        }
                        else if (librarianChoice == 'R')
                        {
                            Console.WriteLine("Enter the number of book you want to delete");
                            var bookNumber = int.Parse(Console.ReadLine());
                            librarian.RemoveBook(bookNumber, library);
                        }
                        else if (librarianChoice == 'D')
                        {
                            librarian.DisplayBooks(library);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else if (userType == 'R')
                {
                    Console.Write("Welcome User, Enter your name: ");
                    var userName = Console.ReadLine();
                    LibraryUser user = new LibraryUser(userName);
                    Console.WriteLine($"Welcome {user.Name}");

                    while (true)
                    {
                        Console.WriteLine("Please choose to Display books (D) / Borrow book (B) / Back (Any Character)");
                        var userChoice = Console.ReadLine().ToUpper()[0];
                        if (userChoice == 'D')
                        {
                            user.DisplayBooks(library);
                        }
                        else if (userChoice == 'B')
                        {
                            Console.WriteLine("Enter number of book you want to borrow");
                            var bookNumber = int.Parse(Console.ReadLine());
                            user.BorrowBook(bookNumber, library);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                    Console.WriteLine("Please enter correct value (L or R)");
            }
        }
    }
}
