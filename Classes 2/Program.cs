namespace Classes_2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Student student = new Student(24, "Bob", 2);
      Console.WriteLine($"Name:{student.Name}\n" +
        $"Age:{student.Age}\n" +
        $"Average Score:{student.AverageScore}");
    }
  }
}