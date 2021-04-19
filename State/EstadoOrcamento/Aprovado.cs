using System;
using System.Collections.Generic;
using System.Text;

namespace State.EstadoOrcamento
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= (orcamento.Valor * 0.02);
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
