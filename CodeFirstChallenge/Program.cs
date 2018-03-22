using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LibraryContext())
            {
                Book book = new Book();
                Console.Write("Enter a name for a new book: ");
                var name = Console.ReadLine();
                book.BookTitle = name;

                Console.Write("Enter the name of the publisher of the book: ");
                var publisher = Console.ReadLine();
                book.BookPublisher = publisher;

                db.Books.Add(book);
                db.SaveChanges();

                var query = from b in db.Books orderby b.BookTitle select b;

                Console.WriteLine("All Books in database: ");
                foreach (var title in query)
                    Console.WriteLine(title.BookTitle);

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
