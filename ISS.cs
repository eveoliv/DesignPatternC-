using System;
using System.Text;
using System.Collections.Generic;

namespace Strategy
{
    public class ISS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
