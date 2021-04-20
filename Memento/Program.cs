using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            HistoricoDoContrato historico = new HistoricoDoContrato();

            Contrato c = new Contrato(DateTime.Now, "Everton", TipoContrato.Novo);
            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            Console.WriteLine(c.Tipo);

            Console.WriteLine(historico.Pega(0).Contrato.Tipo);
            
        }
    }
}
