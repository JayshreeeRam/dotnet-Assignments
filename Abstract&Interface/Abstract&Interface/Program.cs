
namespace Abstract_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Thar");
            car.DIsplayBrand();
            car.Start();
            car.Stop();
        }
    }
}
