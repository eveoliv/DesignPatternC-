using System;
using System.Collections.Generic;
using System.Text;

namespace Cronograma
{
    public static class DiaEnvio
    {
        public static bool ValidaDiaDoEnvio(DateTime dataEnvio, List<DateTime> feriados)
        {
            if (dataEnvio.DayOfWeek == DayOfWeek.Saturday || dataEnvio.DayOfWeek == DayOfWeek.Sunday || (feriados.Contains(dataEnvio)))
                return false;

            return true;
        }
    }
}
