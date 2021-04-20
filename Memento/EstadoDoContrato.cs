using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class EstadoDoContrato
    {
        public Contrato Contrato { get; private set; }
        
        public EstadoDoContrato(Contrato contrato)
        {
            Contrato = contrato;
        }



    }
}
