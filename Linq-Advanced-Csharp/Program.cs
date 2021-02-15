using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Advanced_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>() {
            new Product(){CategoryId=5,ProductName="maydanoz"},
            new Product(){ProductName="mısır unu"}
            };
            Console.WriteLine(products[0].ProductName);
            Console.Read();

        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
