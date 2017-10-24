using System;
using System.Collections.Generic;
using System.Globalization;
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
                    ReleaseDate = DateTime.ParseExact(inputLine[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                IdNum = int.Parse(inputLine[4]),
                    Price = double.Parse(inputLine[5])
                };

                library.Books.Add(temporaryBook);

            }

            DateTime startDate = DateTime.ParseExact(Console.ReadLine(),"dd.MM.yyyy",CultureInfo.InvariantCulture);

            foreach (var book in library.Books
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(k => k.Title)
                )
            {
                
                if(book.ReleaseDate > startDate)
                {
                    Console.WriteLine("{0} -> {1}",book.Title, book.ReleaseDate.ToString("dd.MM.yyyy"));
                    
                }
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
