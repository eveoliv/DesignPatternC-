
using System;

namespace Observer
{
    public class ISS : IImposto
    {
        public ISS(IImposto outroImposto) : base(outroImposto) { }
        public ISS() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }      
    }
}
