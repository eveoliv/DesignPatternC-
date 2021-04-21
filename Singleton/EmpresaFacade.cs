using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Facade
{
    public class EmpresaFacade
    {
        public Cliente BuscaCliente(String cpf)
        {
            return new ClienteDao().BuscaPorCpf(cpf);
        }

        public Fatura CriaFatura(Cliente cliente, double valor)
        {
            Fatura fatura = new Fatura(cliente, valor);
            return fatura;
        }

        public Cobranca GeraCobranca(Fatura fatura)
        {
            Cobranca cobranca = new Cobranca(Tipo.Boleto, fatura);
            cobranca.Emite();
            return cobranca;
        }

        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Dispara();
            return contato;
        }
    }
}
