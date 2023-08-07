namespace Classes_4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Book book = new Book();
      Console.WriteLine($"Name:{book.name}\nAuthor:{book.author}");
      Book book1 = new Book("War and Peace", "Lev Tolstoy");
      Console.WriteLine($"Name:{book1.name}\nAuthor:{book1.author}");
    }
  }
}