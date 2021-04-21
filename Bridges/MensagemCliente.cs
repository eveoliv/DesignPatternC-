using System;
using System.Collections.Generic;
using System.Text;

namespace Bridges
{
    class MensagemCliente :IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }
        public MensagemCliente(string nome)
        {
            this.nome = nome;
        }        

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format($"Enviando a mensagem para o Administrador { nome }");
        }
    }
}
