namespace OOP_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature(20);
            Console.WriteLine(temperature.Farenheit(temperature));
            Farenheit farenheit = new Farenheit(33);
            Console.WriteLine(temperature.Celcius(farenheit));
        }
    }
}