using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido p1 = new Pedido("Cliente1", 100);
            Pedido p2 = new Pedido("Cliente2", 200);

            fila.Adiciona(new PagaPedido(p1));
            fila.Adiciona(new PagaPedido(p2));

            fila.Adiciona(new FinalizaPedido(p1));
            fila.Adiciona(new FinalizaPedido(p2));

            fila.Processa();
        }
    }
}
