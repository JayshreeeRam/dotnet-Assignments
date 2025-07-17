using System.Text.Json;

namespace Serilization_Deserilization
{
    internal class Program
    {
        static string filePath = $"D:\\Swabhav\\dotnet Assignments\\Serilization&Deserilization\\Serilization&Deserilization\\Person.json";
        static void Main(string[] args)
        {
            if (File.Exists(filePath))
            {
                //Deserialize
                string json = File.ReadAllText(filePath);
                List<Person> person = JsonSerializer.Deserialize<List<Person>>(json);

                Console.WriteLine("Deserialized person: ");
                foreach (var p in person)
                {
                    Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Email: {p.Email}");
                }
                Console.WriteLine($"Total Persons: {person.Count}");
            }

            else
            {
                //Serialize
                List<Person> person = new List<Person>
                {
                    new Person { Id = 1, Name= "ABC", Email = "abc@gmail.com" },
                    new Person { Id = 2, Name= "XYZ", Email = "xyz@gmail.com" },
                    new Person { Id = 3, Name= "PQR", Email = "pqr@gmail.com" },
                    new Person { Id = 4, Name= "DEF", Email = "def@gmail.com" },
                    new Person { Id = 5, Name= "STQ", Email = "stq@gmail.com" }
                };

                string json = JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
                Console.WriteLine("5 Person objects serialized to person.json");
            }



        }
    }
}
