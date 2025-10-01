namespace ExtraUppgifterKlasser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Title", "Author", "928374", false);

            book1.Borrow();
            book1.Borrow();
        }
    }
}
