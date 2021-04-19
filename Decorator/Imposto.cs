
namespace Decorator
{
    public abstract class IImposto
    {
        public IImposto OutroImposto { get; set; }
       
        public IImposto(IImposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public IImposto()
        {
            OutroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;
            
            return OutroImposto.Calcula(orcamento);
        }
    }
}
