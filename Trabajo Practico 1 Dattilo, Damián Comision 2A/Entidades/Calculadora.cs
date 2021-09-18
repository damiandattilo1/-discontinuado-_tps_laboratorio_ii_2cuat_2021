using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        /// <summary>
        /// Realiza una operacion entre dos objetos Numero
        /// </summary>
        /// <param name="num1"></param> objeto 1
        /// <param name="num2"></param> objeto 2
        /// <param name="operador"></param> el operador para la operacion
        /// <returns></returns> el resultado en variable double


        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double retorno = 0;

            if (Calculadora.ValidarOperador(operador) == '+')
            {
                retorno = num1 + num2;
            }
            else if (Calculadora.ValidarOperador(operador) == '-')
            {
                retorno = num1 - num2;
            }
            else if (Calculadora.ValidarOperador(operador) == '/')
            {
                retorno = num1 / num2;
            }
            else if (Calculadora.ValidarOperador(operador) == '*')
            {
                retorno = num1 * num2;
            }

            return retorno;

        }


        /// <summary>
        /// Valida que el char recibido contenga un operador valido
        /// </summary>
        /// <param name="operador"></param> variable char con el operador
        /// <returns></returns> el operador validado, o el operador + si el operador no era valido
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }
            else
            {
                return '+';
            }
        }
    }
}
