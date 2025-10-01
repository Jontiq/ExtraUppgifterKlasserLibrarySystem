using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraUppgifterKlasser
{
    internal class Library
    {
        //Props
        public List<Book> Books = new List<Book> { };

        //Konstruktor

        //Methods
        //Adds book object to library list.
        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"\"{book.Title}\" has been added to the library.");
        }

        public void RemoveBook(string isbn)
        {
            for(int i = 0; i < Books.Count; i++)
            {
                if (Books[i].ISBN == isbn)
                {
                    Console.WriteLine($"\"Books with ISBN \"{isbn}\" has been removed from the library.");
                    Books.RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine($"No book with ISBN \"{isbn}\" was found in the library");
        }

        public void DisplayAvailableBooks()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("Currently no books in library.");
            }
            else
            {
                Console.WriteLine("------ Current books in library ------");
                for (int i = 0; i < Books.Count; i++)
                {
                    if (Books[i].IsBorrowed == false)
                    {
                        Console.WriteLine($"{Books[i].Title}, by {Books[i].Author}.");
                    }
                }
            }

        }

    }
}
