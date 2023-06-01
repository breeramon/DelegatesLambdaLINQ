using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesLambdaLINQ.Services;
using DelegatesLambdaLINQ.Entities;
using System.Globalization;
using System.IO;

namespace DelegatesLambdaLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file patch: ");
            string path = Console.ReadLine();

            List<Product> products = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    products.Add(new Product(name, price));
                }
            }

            var avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = {0}", avg);

            var names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
