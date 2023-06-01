using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace DelegatesLambdaLINQ.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string email, double price)
        {
            Name = name;
            Email = email;
            Salary = price;
        }

        public override string ToString()
        {
            return Name + ", " + Email + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
