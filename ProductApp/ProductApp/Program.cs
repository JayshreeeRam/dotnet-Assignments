namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Product App---------");

            Product product1 = new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 1500,
                DiscountPercentage = 10
            };

            Product product2 = new Product
            {
                Id = 2,
                Name = "Smartphone",
                Price = 800,
                DiscountPercentage = 15
            };

            Console.WriteLine(product1.ToString());
            Console.WriteLine(product2.ToString());
        }
    }
}

//Create a ProductApp with Model class Product with
//id, name, price and disocount percentage. 
//Create a method to return the cost after discount.
//In test class (Program) create two different proucts
// and display all details including actual price and price after
//discount