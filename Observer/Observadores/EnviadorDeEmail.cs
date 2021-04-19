using System;

namespace Observer.Observadores
{
    public class EnviadorDeEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviando Nota Fiscal por email...");
        }
    }
}
