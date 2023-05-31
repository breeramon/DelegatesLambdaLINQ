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
            //Especificando o data source = fonte de dados
            int[] numbers = new int[] { 1, 2, 3, 4, 5, };

            //Definindo o query expression = expressão de consulta
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            //Executando o query = consulta
            foreach (int numero in result)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
