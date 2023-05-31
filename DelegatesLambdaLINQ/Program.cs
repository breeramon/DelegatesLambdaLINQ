using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesLambdaLINQ.Services;
using DelegatesLambdaLINQ.Entities;
using System.Globalization;

namespace DelegatesLambdaLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Uso sem a expressão lambda no list.RemoveAll()
            list.RemoveAll(ProductTest);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            //Uso com a expressão lambda no list.RemoveAll()
            list.RemoveAll(p2 => p2.Price <= 100);
            foreach (Product p2 in list)
            {
                Console.WriteLine(p2);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100;
        }
    }
}
