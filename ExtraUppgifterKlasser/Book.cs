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
    }
}
