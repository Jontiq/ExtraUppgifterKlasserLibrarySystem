using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraUppgifterKlasser
{
    internal class Book
    {
        //Props
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsBorrowed { get; set; }

        //Konstruktor
        public Book (string Title, string Author, string ISBN, bool IsBorrowed)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
            this.IsBorrowed = IsBorrowed;
        }

        //Methods
        //Allowes the user to borrow book
        public void Borrow()
        {
            if (IsBorrowed == false)
            {
                IsBorrowed = true;
                Console.WriteLine($"\"{Title}\" has now been borrowed.");
            }
            else
            {
                Console.WriteLine($"Sorry, \"{Title}\" is already borrowed.");
            }
        }

        //Allowes user to return rented book.
        public void ReturnBook()
        {
            if (IsBorrowed == true)
            {
                IsBorrowed = false;
                Console.WriteLine($"\"{Title}\" has been returned.");
            }
            else
            {
                Console.WriteLine($"Unable to return \"{Title}\", book has not been borrowed.");
            }
        }
    }
}
