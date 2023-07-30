namespace OOP_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(); ;
            Console.WriteLine(cat.MakeSound());
            Dog dog = new Dog(); 
            Console.WriteLine(dog.MakeSound());
        }
    }
}