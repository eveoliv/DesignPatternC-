
namespace Visitor
{
    public class Subtracao : IExpressao
    {
        public IExpressao Direita { get; set; }
        public IExpressao Esquerda { get; set; }
        public Subtracao(IExpressao direita, IExpressao esquerda)
        {
            this.Direita = direita;
            this.Esquerda = esquerda;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda - valorDireita;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeSubtracao(this);
        }
    }
}
