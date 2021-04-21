
namespace Interpreter
{
    public class Subtracao : IExpressao
    {
        private IExpressao direita;
        private IExpressao esquerda;

        public Subtracao(IExpressao direita, IExpressao esquerda)
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
