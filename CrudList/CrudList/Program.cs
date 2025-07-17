namespace CrudList
{
    internal class Program
    {
        
            static List<Student> students = new List<Student>();
            static void Main(string[] args)
            {
                ShowMenu();
            }

            static void ShowMenu()
            {
                int choice = 0;

                do
                {
                    Console.WriteLine("\n--------------------------------Student Management System------------------------------");
                    Console.WriteLine("1. Add Student");
                    Console.WriteLine("2. View Students");
                    Console.WriteLine("3. Update Student");
                    Console.WriteLine("4. Delete Student");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter Choice: ");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: AddStudent(); break;
                        case 2: ViewStudent(); break;
                        case 3: UpdateStudent(); break;
                        case 4: DeleteStudent(); break;
                        case 5: Console.WriteLine("Exiting....."); break;
                        default: Console.WriteLine("Enter valid choice"); break;
                    }

                } while (choice != 5);
            }
            static void AddStudent()
            {
                Student s = new Student();
                Console.WriteLine("\nEnter Roll Number of Student");
                s.RollNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name of the Student");
                s.Name = Console.ReadLine();
                Console.WriteLine("Enter Marks of Student");
                s.Marks = double.Parse(Console.ReadLine());

                students.Add(s);
                Console.WriteLine("\nStudent has been added successfully");
            }

            static void ViewStudent()
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("\nNo Student Found");
                    return;
                }
                Console.WriteLine("\nStudent List:");
                foreach (Student s in students)
                {
                    s.Display();
                }
            }

            static void UpdateStudent()
            {
                Console.WriteLine("\nEnter Roll Number of Student");
                int RollNo = int.Parse(Console.ReadLine());

                Student student = students.Find(s => s.RollNo == RollNo);

                if (student != null)
                {
                    Console.WriteLine("Enter New Name of the Student");
                    student.Name = Console.ReadLine();
                    Console.WriteLine("\nEnter New Marks of Student");
                    student.Marks = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nStudent record has been updated successfully");
                }
                else
                {
                    Console.WriteLine("\nStudent not found");
                }
            }

            static void DeleteStudent()
            {
                Console.WriteLine("\nEnter Roll Number of Student");
                int RollNo = int.Parse(Console.ReadLine());

                Student student = students.Find(s => s.RollNo == RollNo);

                if (student != null)
                {
                    students.Remove(student);

                    Console.WriteLine("\nStudent record has been deleted successfully");
                }
                else
                {
                    Console.WriteLine("\nStudent not found");
                }
            }
        }
    }


