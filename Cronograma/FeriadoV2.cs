using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cronograma
{
    public class FeriadoV2
    {

        public static List<DateTime> RelacionaCronogramaEFeriado(List<DateTime> listaFeriados, List<DateTime> datasCronograma)
        {                    
            var feriadosEncontrados = new List<DateTime>();
            for (int i = 0; i < 7; i++)
            {
                var buscaFeriado = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - i);
                var ifxFeriados = (from f in listaFeriados where f.Equals(buscaFeriado) select f).ToList();

                foreach (var f in ifxFeriados)
                {
                    feriadosEncontrados.Add(f);
                }
            }           

            var datasPossiveis = new List<DateTime>();
            var diaUtil = new DiaUtil();
            datasCronograma.Any(data => diaUtil.RetornarDiaUtil(data, listaFeriados, datasPossiveis).Contains(DateTime.Now.Date));

            return datasPossiveis;
        }
    }
}

