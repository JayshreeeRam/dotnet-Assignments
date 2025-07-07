namespace FunctionAndArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                const int studentCount = 5;
                double[] fees = new double[studentCount];

                for (int i = 0; i < studentCount; i++)
                {
                    fees[i] = GetValidFee(i + 1);
                }

                double[] feesWithDiscount = ApplyDiscount(fees);

                Console.WriteLine("\nThe fees with discount are:");
                for (int i = 0; i < studentCount; i++)
                {
                    Console.WriteLine($"Student {i + 1} : {feesWithDiscount[i]:F2}");
                }
            }

            static double GetValidFee(int studentNumber)
            {
                double fee;
                while (true)
                {
                    Console.Write($"Enter fees for Student {studentNumber} : ");
                    if (double.TryParse(Console.ReadLine(), out fee))
                    {
                        if (fee >= 5000 && fee <= 10000)
                        {
                            return fee;
                        }
                    }
                    Console.WriteLine("Error! Fees must be in the range 5000 to 10000");
                }
            }

            static double[] ApplyDiscount(double[] fees)
            {
                double[] discountedFees = new double[fees.Length];
                for (int i = 0; i < fees.Length; i++)
                {
                    if (fees[i] > 7000)
                    {
                        discountedFees[i] = fees[i] * 0.05; 
                    }
                    else
                    {
                        discountedFees[i] = fees[i];
                    }
                }
                return discountedFees;
            }
        }
    }

