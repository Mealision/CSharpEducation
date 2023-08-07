namespace Classes_3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Calculator calculator = new Calculator(2.5, 3);
      Console.WriteLine(calculator.Divide());
      Console.WriteLine(calculator.Add());
      Console.WriteLine(calculator.Subtract());
      Console.WriteLine(calculator.Multiply());
    }
  }
}