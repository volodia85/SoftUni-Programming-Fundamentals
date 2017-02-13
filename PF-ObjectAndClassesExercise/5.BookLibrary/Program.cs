using System;
using System.Collections.Generic;
using System.Linq;


namespace _5.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookCount = int.Parse(Console.ReadLine());

            Library Library = new Library();

            List<Book> books = new List<Book>();

            for (int i = 0; i < bookCount; i++)
            {
                books.Add(Readbooks());
            }
            Library.books = books;

            Dictionary<string, List<Book>> booksByAuthor = CreateBooksByAuthor(Library);

            foreach (var authorEntry in booksByAuthor.OrderByDescending(b => b.Value.Select(a => a.price).Sum()).ThenBy(a => a.Key))

            {
                decimal priceTotal = authorEntry.Value.Select(x => x.price).Sum();
                Console.WriteLine($"{authorEntry.Key} -> {priceTotal:f2}");
            }
        }

        private static Dictionary<string, List<Book>> CreateBooksByAuthor(Library Library)
        {
            Dictionary<string, List<Book>> booksByAuthor = new Dictionary<string, List<Book>>();
            foreach (var book in Library.books)
            {
                if (!booksByAuthor.ContainsKey(book.author))
                {
                    booksByAuthor.Add(book.author, new List<Book>());
                }
                booksByAuthor[book.author].Add(book);
            }
            return booksByAuthor;
        }

        private static Book Readbooks()
        {
            Book book = new Book();

            string[] input = Console.ReadLine().Split();
            book.title = input[0];
            book.author = input[1];
            book.publisher = input[2];
            book.releaseDate = DateTime.Parse(input[3]);
            book.ISBN = int.Parse(input[4]);
            book.price = decimal.Parse(input[5]);

            return book;
        }
    }

    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public DateTime releaseDate { get; set; }
        public int ISBN { get; set; }
        public decimal price { get; set; }
    }

    class Library
    {
        public string name { get; set; }
        public List<Book> books { get; set; }
    }
}

