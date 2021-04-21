using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao conta = new Soma(esquerda, direita);
         
            Console.WriteLine(conta.Avalia());
            
            conta.Aceita(new Impressora());
        }
    }
}
