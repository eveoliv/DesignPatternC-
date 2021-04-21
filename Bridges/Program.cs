using System;

namespace Bridges
{
    class Program
    {
        static void Main(string[] args)
        {
            var mensagem = new MensagemCliente("Everton");
            var enviador = new EnviaPorEmail();
            mensagem.Enviador = enviador;
            mensagem.Envia();

        }
    }
}
