using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Carro carro = new Carro();

            carro.Id = 1;
            carro.Nome = "Gol";
            carro.Cor = "Branco";*/

            Carro carro = new Carro()
            {
                Id = 1,
                Nome = "Gol",
                Cor = "Branco"
            };

            Imprimir(carro);

            Console.ReadKey();

        }

        private static void Imprimir(Carro carro)
        {
            Console.WriteLine(carro.Imprimir());
        }
    }
}
