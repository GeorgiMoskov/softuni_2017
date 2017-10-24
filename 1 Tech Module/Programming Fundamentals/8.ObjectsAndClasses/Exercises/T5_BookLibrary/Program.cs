using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_BookLibraryModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int iEnd = int.Parse(Console.ReadLine());
            Library library = new Library();
            library.Name = "Library 1";

            for (int i = 0; i < iEnd; i++)
            {
                string[] inputLine = Console.ReadLine().Split();

                Book temporaryBook = new Book
                {
                    Title = inputLine[0],
                    Author = inputLine[1],
                    Publisher = inputLine[2],
                    ReleaseDate = DateTime.Parse(inputLine[3]),
                    IdNum = int.Parse(inputLine[4]),
                    Price = double.Parse(inputLine[5])
                };

            library.Books.Add(temporaryBook);

            }
            foreach (var book in library.Books
                .GroupBy(x => x.Author)
                .OrderByDescending(x => x.Sum(p => p.Price))
                .ThenBy(k => k.Key)
                )
            {
                Console.WriteLine($"{book.Key} -> {book.Sum(p => p.Price):f2}");
            }


        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int IdNum { get; set; }
        public double Price { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books = new List<Book>();
    }
}
