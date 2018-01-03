using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BookLibrary
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBNnumber { get; set; }
        public double Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Library library = new Library { Name = "notImportant", Books = books };
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i<n; i++)
            {
                string[] bookInfo = Console.ReadLine().Split().ToArray();
                library.Books.Add(new Book { Title = bookInfo[0], Author = bookInfo[1], Publisher = bookInfo[2],
                    ReleaseDate = DateTime.ParseExact(bookInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture), ISBNnumber = bookInfo[4], Price = double.Parse(bookInfo[5]) } );
            }

            var filtered = library.Books.Select(b => new { Author = b.Author, TotalEarnings = library.Books.Where(b1 => b1.Author.Equals(b.Author)).Sum(b1 => b1.Price) }).Distinct().
                OrderByDescending(b => b.TotalEarnings).ThenBy(b => b.Author).ToList();

            foreach (var book in filtered)
            {
                Console.WriteLine("{0:f2} -> {1:f2}", book.Author, book.TotalEarnings);
            }
        }
    }
}
