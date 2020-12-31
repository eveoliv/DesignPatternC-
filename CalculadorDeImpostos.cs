using System;
using System.Text;
using System.Collections.Generic;

namespace Strategy
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double calculo = imposto.Calcula(orcamento);
            Console.WriteLine(calculo);
        }
    }
}
