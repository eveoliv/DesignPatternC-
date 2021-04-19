using System;

namespace Builder.EstadoOrcamento
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra.");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já esta em estado de aprovação.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação não pode ser reprovado.");
        }
    }
}
