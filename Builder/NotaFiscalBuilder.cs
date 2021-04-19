using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
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

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, TodosItens, Observacoes);
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
