using System;
using System.Collections.Generic;
using System.Linq;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            var feriados = new List<DateTime>
            {
                new DateTime(2021, 4, 19),
                new DateTime(2021, 4, 20),
                new DateTime(2021, 4, 21)

            };

            var cronograma = new List<DateTime>     
            {
                new DateTime(2021, 4, 19),
                new DateTime(2021, 4, 20)
            };

            List<DateTime> dataLibera = VerificaSaldoFeriado(feriados, cronograma);

            foreach (var dias in dataLibera)
            {
                Console.WriteLine($"Dia para envio: { dias }");
            }

            if (dataLibera.Count() == 0)
            {
                Console.WriteLine("Nao existe data para liberacao...");
            }
        }

        private static List<DateTime> VerificaSaldoFeriado(List<DateTime> feriados, List<DateTime> cronograma)
        {
            var dataLibera = new List<DateTime>();
            var maxDataFeriado = (from f in feriados select f).Max();
            var maxDataCronograma = (from f in cronograma select f).Max();

            //Ultima data do cronograma eh feriado saldo + 1
            if (maxDataFeriado == maxDataCronograma)
            {
                dataLibera.Add(maxDataCronograma.AddDays(1));
            }

            //Penultima data cronograma eh feriado saldo + 2
            if (maxDataFeriado == maxDataCronograma.AddDays(1))
            {
                dataLibera.Add(maxDataCronograma.AddDays(2));
            }

            //AntePenultima data do cronograma eh feriado saldo + 3
            if (maxDataFeriado == maxDataCronograma.AddDays(2))
            {
                dataLibera.Add(maxDataCronograma.AddDays(3));
            }

            //Data cronograma maior que feriado libera data atual
            if (maxDataFeriado < maxDataCronograma)
            {
                //Data cronograma >= hoje
                if (maxDataCronograma >= DateTime.Today )
                {
                    dataLibera.Add(DateTime.Now);
                }
            }

            return dataLibera;
        }
    }
}
