using Observer.Observadores;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador
                .ParaEmpresa("Alura Cursos")
                .ComCnpj("12.345.678/0001-25")
                .ComIten(new ItemDaNota("Caderno", 100.00))
                .ComIten(new ItemDaNota("Livro", 200.00))
                .NaDataAtual()
                .ComObservacoes("Uma observacao qualquer");
            //Fluent interface

            criador.AdicionaAcao(new EnviadorDeEmail());
            criador.AdicionaAcao(new NotaFiscalDAL());
            criador.AdicionaAcao(new EnviadorDeSms());

            NotaFiscal nf = criador.Constroi();
            Console.WriteLine($"Valor Bruto: {nf.ValorBruto}");
            Console.WriteLine($"Impostos: {nf.Impostos}");

            Console.ReadKey();

        }
    }
}
