using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Cronograma
{
    public class Feriado
    {
        public static List<DateTime> RelacionaCronogramaEFeriado(List<DateTime> listaFeriados, List<DateTime> datasCronograma, DateTime dataEnvio)
        {
            var datasFeriados = new List<DateTime>();

            //var maxDataCronograma = (from c in datasCronograma select c).Max();

            var feriadosEncontrados = new List<DateTime>();
            for (int i = 0; i < 10; i++)
            {
                //var buscaFeriado = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - i);
                var buscaFeriado = dataEnvio.AddDays(-i);
                var ifxFeriados = (from f in listaFeriados where f.Equals(buscaFeriado) select f).ToList();

                foreach (var f in ifxFeriados)
                {
                    //feriadosEncontrados.Add(f);
                    Console.WriteLine($"Feriado adicionado: {f}");
                    datasFeriados.Add(f);
                }
            }

            //foreach (var f in feriadosEncontrados)
            //{
            //    if (datasCronograma.Contains(f))
            //    {
            //        datasFeriados.Add(f);
            //        for (int i = 0; i < feriadosEncontrados.Count(); i++)
            //        {
            //            if (feriadosEncontrados.Contains(maxDataCronograma.AddDays(i)))
            //            {
            //                datasFeriados.Add(f.AddDays(i));
            //            }
            //        }
            //    }
            //}

            var datasPossiveis = new List<DateTime>();
            var diaUtil = new DiaUtil();
            datasCronograma.Any(data => diaUtil.RetornarDiaUtil(data, datasFeriados, datasPossiveis).Contains(dataEnvio));
            //datasCronograma.Any(data => diaUtil.RetornarDiaUtil(data, datasFeriados, datasPossiveis).Contains(DateTime.Now.Date));
            return datasPossiveis;
        }
    }
}
