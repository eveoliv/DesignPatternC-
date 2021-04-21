
namespace Interpreter
{
    public class Soma : IExpressao
    {
        private IExpressao direita;
        private IExpressao esquerda;

        public Soma(IExpressao direita, IExpressao esquerda)
        {
            this.direita = direita;
            this.esquerda = esquerda;
        }

        public int Avalia()
        {
            int valorEsquerda = esquerda.Avalia();
            int valorDireita = direita.Avalia();
            return valorEsquerda - valorDireita;
        }
    }
}
