using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class FinalizaPedido : IComando
    {
        private Pedido pedido;
        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }
        public void Executa()
        {
            Console.WriteLine($"Finalizando pedido do cliente { pedido.Cliente }");
            pedido.Finaliza();
        }
    }
}
