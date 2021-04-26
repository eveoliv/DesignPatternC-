using System;
using System.Text;
using System.Collections.Generic;

namespace Cronograma
{
    public class DiaUtil
    {
        public List<DateTime> RetornarDiaUtil(DateTime data, ICollection<DateTime> feriados, List<DateTime> datasPossiveis)
        {
            if (feriados.Contains(data.Date))
            {
                return RetornarDiaUtil(data.AddDays(1), feriados, datasPossiveis);
            }

            switch (data.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    return RetornarDiaUtil(data.AddDays(+2), feriados, datasPossiveis);
                case DayOfWeek.Sunday:
                    return RetornarDiaUtil(data.AddDays(+1), feriados, datasPossiveis);
                default:
                    {
                        if (datasPossiveis.Contains(data.Date))
                        {
                            return RetornarDiaUtil(data.AddDays(1), feriados, datasPossiveis);
                        }
                        //DiaInicialEnvioLote
                        datasPossiveis.Add(data);
                        return datasPossiveis;
                    }
            }
        }
    }
}