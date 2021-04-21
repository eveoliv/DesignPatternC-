using System;
using System.Collections.Generic;
using System.Text;

namespace Bridges
{
    class EnviaPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por Email");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
