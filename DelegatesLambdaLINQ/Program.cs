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

            //list.ForEach(p => { p.Price += p.Price * 0.1; }); --- Pode ser feito desse jeito ou no exemplo abaixo.

            list.ForEach(UpdatePrice);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
