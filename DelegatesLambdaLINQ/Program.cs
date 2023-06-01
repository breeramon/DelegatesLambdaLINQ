using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, salary));
                }
            }
            Console.Write("Enter salary: ");
            double numero = double.Parse(Console.ReadLine());

            Console.WriteLine("Email of people whose salary is more than {0}:", numero);
            var names = employees.Where(p => p.Salary > numero).OrderBy(p => p.Name).Select(p => p.Email);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            var sum = employees.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine("Sum of salary of people whose name stars with 'M': {0}", sum);
        }
    }
}
