using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCalculos
{
    class Calculo
    {
        #region Propriedades

        public double ValorA { get; set; }
        public double ValorB { get; set; }

        #endregion Propriedades

        #region Metodos

        public double Somar()
        {
            double soma = ValorA + ValorB;
            return soma;
        }

        public double Subtrair()
        {
            double subtracao = ValorA - ValorB;
            return subtracao;

        }

        public double Multiplicar()
        {
            double multiplicacao = ValorA * ValorB;
            return multiplicacao;
        }

        public double Dividir()
        {
            double divisao = ValorA / ValorB;
            return divisao;
        }
        #endregion Metodos
    }
}
