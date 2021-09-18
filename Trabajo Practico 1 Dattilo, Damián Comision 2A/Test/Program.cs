using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Operando n1 = new Operando("5");
            Operando n2 = new Operando(5);

            double resultado = Calculadora.Operar(n1, n2, '*');

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
