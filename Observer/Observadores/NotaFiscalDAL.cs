using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Observadores
{
    public class NotaFiscalDAL : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Salvando Nota Fiscal no banco...");
        }
    }
}