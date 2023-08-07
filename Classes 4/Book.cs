using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_4
{
  internal class Book
  {
    public string name;
    public string author;

    public Book(string name, string author)
    {
      this.name = name;
      this.author = author;
    }

    public Book()
    {
      name = "Unnamed book";
      author = "Unknown";
    }
  }
}
