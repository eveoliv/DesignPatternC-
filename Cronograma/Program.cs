using System;
using System.Linq;
using System.Collections.Generic;

namespace Cronograma
{
    class Program
    {
        static void Main(string[] args)
        {

            var listaFeriados = new List<DateTime>
            {
                 new DateTime(2021,4,21)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,20),
                new DateTime(2021,4,21),
                new DateTime(2021,4,22)               
            };

            
            var dataEnvio = new DateTime(2021, 4, 23);
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasUteisParaEnvio =  Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            Console.WriteLine($"\nData Envio: {dataEnvio} | EhDiaUtil = {validaEnvio}\n");                       

            foreach (var item in diasUteisParaEnvio)
            {                               
                Console.WriteLine($"Dias Liberados para envio: { item }");                
            }
        }      
    }
}
