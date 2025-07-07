using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal GetPriceAfterDiscount()
        {
            return Price - (Price * DiscountPercentage / 100);
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}rs, Discount: {DiscountPercentage}%, Price After Discount: {GetPriceAfterDiscount()}rs";
        }

    }
}


