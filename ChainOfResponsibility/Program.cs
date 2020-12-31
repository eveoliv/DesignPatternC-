using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(600.0);
            orcamento.AdicionaItem(new Item("caneta", 200));
            orcamento.AdicionaItem(new Item("lapis", 200));
            orcamento.AdicionaItem(new Item("borracha", 100));
            orcamento.AdicionaItem(new Item("caderno", 100));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);
            Console.ReadKey();
        }
    }
}
