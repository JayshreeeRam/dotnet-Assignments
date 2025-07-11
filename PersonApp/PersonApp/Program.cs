namespace PersonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(20, "Manish", 22);
            person.Bodytype();

            Person person1 = new Person(41, "Om", 41, 6, 90);
            person1.Bodytype();

            ChainingDemo ch = new ChainingDemo();
        }
    }
}