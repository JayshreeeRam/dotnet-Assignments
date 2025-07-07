namespace Loops
{
    internal class Program
    {
        public static void forLoop()
        {
           
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void foreachLoop()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void whileLoop()
        {
            int i = 0;
            while (i < 5)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.WriteLine();
        }
        public static void stringLoop()
        {
            string[] names = { "Alice", "Bob", "Charlie" };
            foreach (string name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }

        public static void intArrayLoop()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number+ " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-------Loops-------");
            Console.WriteLine("-------For Loop-------");
            forLoop();
            Console.WriteLine("-------For Each Loop-------");
            foreachLoop();
            Console.WriteLine("-------While Loop-------");
            whileLoop();
            Console.WriteLine("-------String Loop-------");
            stringLoop();

        }
    }
}
