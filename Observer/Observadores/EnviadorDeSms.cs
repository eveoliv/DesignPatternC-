using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Observadores
{
    public class EnviadorDeSms : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviando por SMS...");
        }
    }
}
