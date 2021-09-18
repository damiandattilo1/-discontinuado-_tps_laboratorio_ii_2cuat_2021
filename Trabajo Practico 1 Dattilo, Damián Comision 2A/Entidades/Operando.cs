using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;



        /// <summary>
        /// Constructor sin parametros
        /// </summary>

        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor que recibe una variable double y la asigna al atributo numero en esta instancia
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero) :this (numero.ToString())
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que recibe un string y lo asigna al atributo numero en esta instancia
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Carga un valor ya validado en el atributo numero
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = Operando.ValidarOperando(value);
            }
        }
    
        /// <summary>
        /// Valida que un string contenga un caracter numerico
        /// </summary>
        /// <param name="strNumero"></param> el string a validar
        /// <returns></returns> 0 si el string no contiene un caracter numerico, o el contenido del string convertido en double si el string contiene un caracter numerico
        private static double ValidarOperando(string strNumero)
        {
            double numero;
            if (!double.TryParse(strNumero, out numero))
            {
                return 0;
            }
            else
            {
                return numero;
            }
        }

        /// <summary>
        /// Convierte un numero binario a decimal, previa validacion
        /// </summary>
        /// <param name="binario"></param> El numero a convertir, en formato string
        /// <returns></returns> El numero en formato decimal convertido a string, o, "Valor no valido" si el numero en la variable no es valido
        public static string BinarioDecimal(string binario)
        {
            int resultado = 0;
            int potencia = 1;
            string retorno;

            if(esBinario(binario))
            {
                for (int i = (binario.Length) - 1; i >= 0; i--)
                {
                    if (binario[i] == '1')
                    {
                        resultado += potencia;
                    }

                    potencia *= 2;
                }
                retorno = resultado.ToString();
            }
            else
            {
                retorno = "Valor no valido";
            }

            return retorno;
        }

       

        /// <summary>
        /// Averigua si un numero es binario
        /// </summary>
        /// <param name="binario"></param> El numero en string
        /// <returns></returns> false si no es binario, true si es binario
        private static bool esBinario(string binario)
        {
            bool retorno = true;

            for (int i = 0; i < binario.Length; i++)
            {

                if (binario[i] != '0' && binario[i] != '1')
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="n1"></param> objeto 1
        /// <param name="n2"></param> objeto 2
        /// <returns></returns> la resta de los atributos numero de los dos objetos
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// sobrecarga del operador *
        /// </summary>
        /// <param name="n1"></param> objeto 1
        /// <param name="n2"></param> objeto 2
        /// <returns></returns> la multiplicacion de los atributos numero de los dos objetos
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador /
        /// </summary>
        /// <param name="n1"></param> objeto 1
        /// <param name="n2"></param> objeto 2
        /// <returns></returns> la division de los atributos numero de los dos objetos
        public static double operator /(Operando n1, Operando n2)
        {
            double retorno;

            if (n2.numero == 0)
            {
                retorno = double.MinValue;
            }
            else
            {
                retorno = n1.numero / n2.numero;
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="n1"></param> objeto 1
        /// <param name="n2"></param> objeto 2
        /// <returns></returns> la suma de los atributos numero de los dos objetos
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Convierte un numero de decimal a binario
        /// </summary>
        /// <param name="numero"></param> El numero a convertir en variable double
        /// <returns></returns> El numero convertido a binario en variable string
        public static string DecimalBinario(double numero)
        {
            string retorno = "";
            int numeroInt = (int)numero;
            bool significativo = false;

            if (numeroInt != 0)
            {
                for (int potencia = (int.MaxValue / 2) + 1; potencia >= 1; potencia /= 2)
                {
                    if (potencia <= numeroInt)
                    {
                        numeroInt -= potencia;
                        retorno += "1";
                        significativo = true;
                    }
                    else if (significativo == true)
                    {
                        retorno += "0";
                    }
                }

            }
            else
            {
                retorno = "0";
            }

            return retorno;
        }

        /// <summary>
        /// Convierte un numero de decimal a binario
        /// </summary>
        /// <param name="numero"></param> El numero a convertir en variable string
        /// <returns></returns> El numero convertido a decimal, en una variable string
        public static string DecimalBinario(string numero)
        {
            double numeroDouble;
            string retorno;
            if(!double.TryParse(numero, out numeroDouble))
            {
                retorno = "Valor invalido";
            }
            else
            {
                retorno = Operando.DecimalBinario(numeroDouble);
            }

            return retorno;
        }
    }
}
