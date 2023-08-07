using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_5
{
  internal class Book
  {
    public string Название { get; set; }
    public string Автор { get; set; }
    public int ГодИздания { get; set; }

    public Книга(string название, string автор, int годИздания)
    {
      Название = название;
      Автор = автор;
      ГодИздания = годИздания;
    }

    public Книга(string название, string автор) : this(название, автор, 0)
    {
    }

    public Книга() : this("Неизвестная книга", "Неизвестный автор", 0)
    {
    }
  }
}
