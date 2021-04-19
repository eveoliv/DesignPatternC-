using System;

namespace TemplateMethod
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
