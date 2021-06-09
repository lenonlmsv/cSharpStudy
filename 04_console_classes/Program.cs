using System;
using _04_console_classes.classes;


namespace _04_console_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Products list = new Products();
            var product = list.ProductStr;
            product.Code = 1;
            product.Name = "Teste";
            product.Description = "Teste description";
            list.AddProduct(product);

            Console.WriteLine(list.ProductList[0]);
        }
    }
}
