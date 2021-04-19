using System;
using Observer.Observadores;
using System.Collections.Generic;

namespace Observer
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; set; }
        public DateTime Data { get; private set; }
        public double ValorTotal { get; set; }
        public double Impostos { get; set; }
        public string Observacoes { get; private set; }

        private List<ItemDaNota> TodosItens = new List<ItemDaNota>();

        private IList<IAcaoAposGerarNota> TodasAcoesASeremExecutadas = new List<IAcaoAposGerarNota>();

        public NotaFiscal Constroi()
        {
            NotaFiscal nf =  new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, TodosItens, Observacoes);

            foreach (IAcaoAposGerarNota acao in TodasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        public void AdicionaAcao(IAcaoAposGerarNota novaAcao)
        {
            TodasAcoesASeremExecutadas.Add(novaAcao);
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            Data = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ComIten(ItemDaNota item)
        {
            TodosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }
    }
}
