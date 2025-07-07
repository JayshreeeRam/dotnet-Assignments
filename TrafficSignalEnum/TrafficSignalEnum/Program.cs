namespace TrafficSignalEnum

    {
        enum TrafficLight
        {
            RED,
            YELLOW,
            GREEN
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Traffic Light Signal (RED, YELLOW, GREEN): ");
                string input = Console.ReadLine().ToUpper();

                if (Enum.TryParse(input, out TrafficLight signal))
                {
                    PrintAction(signal);
                }
                else
                {
                    Console.WriteLine("Invalid traffic light signal.");
                }
            }

            static void PrintAction(TrafficLight signal)
            {
                switch (signal)
                {
                    case TrafficLight.RED:
                        Console.WriteLine("Signal: RED --> Stop");
                        break;
                    case TrafficLight.YELLOW:
                        Console.WriteLine("Signal: YELLOW --> Get Ready");
                        break;
                    case TrafficLight.GREEN:
                        Console.WriteLine("Signal: GREEN --> Go");
                        break;
                    default:
                        Console.WriteLine("Unknown signal.");
                        break;
                }
            }
        }
    }

