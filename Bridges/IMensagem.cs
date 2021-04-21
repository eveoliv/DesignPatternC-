using System;
using System.Collections.Generic;
using System.Text;

namespace Bridges
{
    interface IMensagem
    {
        IEnviador Enviador { get; set; }

        void Envia();

        string Formata();
    }
}
