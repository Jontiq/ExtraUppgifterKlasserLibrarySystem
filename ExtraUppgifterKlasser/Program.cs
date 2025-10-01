namespace ExtraUppgifterKlasser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();
            Book book1 = new Book("The Hobbit", "J.R.R. Tolkien", "111111", false);
            Book book2 = new Book("1984", "George Orwell", "222222", false);
            Book book3 = new Book("Pippi Långstrump", "Astrid Lindgren", "333333", false);

            lib.AddBook(book1);
            lib.AddBook(book2);
            lib.AddBook(book3);

            book1.Borrow();

            lib.DisplayAvailableBooks();

            book1.ReturnBook();

            lib.DisplayAvailableBooks();
        }
    }
}
