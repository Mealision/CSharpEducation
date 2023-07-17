namespace PracticeTask24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John", "Doe", 25, Gender.male);
            person1.Greet(); 

            Person person2 = new Person("Jane", "Smith", 30, Gender.female);
            person2.Greet();  

            Console.WriteLine(Person.Count);  
        }
    }
}