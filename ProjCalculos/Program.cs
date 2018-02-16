using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCalculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo calculo = new Calculo();

            int permite = 0;

            do
            {
                Console.WriteLine("Informe o valor A:");
                try
                {
                    calculo.ValorA = Convert.ToDouble(Console.ReadLine());
                    permite = 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Caracater invalido!");
                }
            } while (permite ==0);


            do
            {
                Console.WriteLine("Informe o valor B:");
                try
                {
                    calculo.ValorB = Convert.ToDouble(Console.ReadLine());
                    permite = 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Caracater invalido!");
                    permite = 0;
                }
            } while (permite == 0);


            Testes(calculo);

            Console.ReadKey();

        }

        private static void Testes (Calculo calculo)
        {
            Console.WriteLine("\nSoma: " + calculo.Somar());
            Console.WriteLine("Subtracao: " + calculo.Subtrair());
            Console.WriteLine("Multiplicao: " + calculo.Multiplicar());

            if (calculo.ValorB == 0)
            {
                Console.WriteLine("Divisao: Não existe divisao por zero!!!");
            }
            else
            {
                Console.WriteLine("Divisao: " + calculo.Dividir());
            }            

        }
    }
}
