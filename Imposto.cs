using System;
using System.Text;
using System.Collections.Generic;

namespace Strategy
{
    public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}
