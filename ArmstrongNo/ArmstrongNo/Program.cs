using System;
class Armstrong
{
    public static void Main(string[] Arg)
    {

        int n = 153;
        int temp = n;
        int og = n;
        int size = 0;
        while (temp > 0)
        {
            size++;
            temp /= 10;
        }

        double sum = 0;
        while (og > 0)
        {
            int digit = og % 10;
            sum += Math.Pow(digit, size);
            og /= 10;
        }

        if (sum == n) { Console.WriteLine("Yes"); }
        else
        {
            Console.WriteLine("NO");
        }

    }

}
