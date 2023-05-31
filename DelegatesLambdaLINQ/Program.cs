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

            Func<Product, string> func = NameUpper;

            //List<string> result = list.Select(NameUpper).ToList(); --- TBM PODE SER FEITO DESSE JEITO
            //List<string> result = list.Select(p => p.Nme.ToUpper()).ToList(); --- OUTRO MÉTODO QUE TBM PODE SER FEITO, que é colocando a expressão dentro do método select

            List<string> result = list.Select(func).ToList();
            foreach (string p in result)
            {
                Console.WriteLine(p);
            }
        }

        public static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
