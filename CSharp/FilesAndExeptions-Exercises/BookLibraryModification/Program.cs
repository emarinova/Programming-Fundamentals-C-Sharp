using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace BookLibraryModification
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
            string[] input = File.ReadAllLines("D:\\Programing\\Tech Module\\CSharp\\FilesAndExeptions-Exercises\\BookLibraryModification\\input.txt");

            for (int i = 1; i < input.Length - 1; i++)
            {
                string[] bookInfo = input[i].Split().ToArray();
                library.Books.Add(new Book
                {
                    Title = bookInfo[0],
                    Author = bookInfo[1],
                    Publisher = bookInfo[2],
                    ReleaseDate = DateTime.ParseExact(bookInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBNnumber = bookInfo[4],
                    Price = double.Parse(bookInfo[5])
                });
            }
            DateTime givenDate = DateTime.ParseExact(input[input.Length-1], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            library.Books = library.Books.OrderBy(b => b.ReleaseDate).ThenBy(b => b.Title).ToList();
            List<string> output = new List<string>();
            foreach (var book in library.Books)
            {
                if (book.ReleaseDate > givenDate)
                {
                    output.Add($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}");
                }
                    //Console.WriteLine("{0} -> {1}", book.Title, book.ReleaseDate.ToString("dd.MM.yyyy"));
            }
            File.WriteAllLines("D:\\Programing\\Tech Module\\CSharp\\FilesAndExeptions-Exercises\\BookLibraryModification\\output.txt", output);
        }
    }
}
