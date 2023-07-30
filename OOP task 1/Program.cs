namespace OOP_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle( 4, 5 );
            Console.WriteLine(rectangle.CalculateArea());
            Shape circle = new Circle(1);
            Console.WriteLine(circle.CalculateArea());

        }
    }
}