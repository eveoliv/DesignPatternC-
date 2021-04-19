using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {             

            Orcamento reforma = new Orcamento(500.0);
            Console.WriteLine(reforma.Valor);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Aprova();

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Finaliza();
            reforma.AplicaDescontoExtra();
            Console.ReadKey();

        }
    }
}
