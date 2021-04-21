using System;
using System.Collections.Generic;
using System.Text;

namespace Bridges
{
    interface IEnviador
    {
        void Envia(IMensagem mensagem);
    }
}
