using System;
class Fibonacci
{
    public static void Main(string[] Args)
    {

        Console.WriteLine("Enter the number of terms in the Fibonacci sequence:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 1) { Console.WriteLine(n); return; }
        int[] arr = new int[n + 1];
        arr[0] = 0;
        arr[1] = 1;
        Console.Write(arr[1] + " ");
        for (int i = 2; i <= n; ++i)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
            Console.Write(arr[i] +" ");
        }
    }
}