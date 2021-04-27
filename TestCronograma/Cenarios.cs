using Xunit;
using System;
using Cronograma;
using System.Collections.Generic;

namespace TestCronograma
{
    public class Cenarios
    {
        [Fact]
        public void CronogramaNoMesmoDiaDoFeriado_HumDiaDeSaldo()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,21)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,21)
            };

            var dataEnvio = new DateTime(2021, 4, 22);

            //Act
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada = new DateTime(2021, 4, 22);

            Assert.Equal(dataEsperada, diasPossiveis[0]);
            Assert.True(validaEnvio);

        }

        [Fact]
        public void CronogramaNoMesmoDiaDoFeriado_Bloqueia()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,21)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,21)
            };

            var dataEnvio = new DateTime(2021, 4, 21);

            //Act
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada = new DateTime(2021, 4, 22);

            Assert.False(validaEnvio);
            Assert.Equal(dataEsperada, diasPossiveis[0]);

        }

        [Fact]
        public void CronogramaNosMesmosDiaDosFeriados_DoisDiasDeSaldo_Saldo1()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,20),
                new DateTime(2021,4,21)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,20),
                new DateTime(2021,4,21)
            };

            var dataEnvio = new DateTime(2021, 4, 22);

            //Act
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 22);

            Assert.True(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
        }

        [Fact]
        public void CronogramaNosMesmosDiaDosFeriados_DoisDiasDeSaldo_Saldo2()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,20),
                new DateTime(2021,4,21)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,20),
                new DateTime(2021,4,21)
            };

            var dataEnvio = new DateTime(2021, 4, 23);

            //Act
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 22);
            var dataEsperada2 = new DateTime(2021, 4, 23);

            Assert.True(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
            Assert.Equal(dataEsperada2, diasPossiveis[1]);
        }

        [Fact]
        public void CronogramaNoMesmoDiasDoFeriadoMaisHumFeriadoDepois_HumDiaDeSaldo()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                 new DateTime(2021,4,20),
                 new DateTime(2021,4,21)
            };

            var datasCronograma = new List<DateTime>
            {
                 new DateTime(2021,4,20)
            };

            var dataEnvio = new DateTime(2021, 4, 22);

            //Act
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 22);

            Assert.True(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
        }

        [Fact]
        public void CronogramasNosMesmosDiasDosFeriados_TresDiasDeSaldo()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,19),
                new DateTime(2021,4,20),
                new DateTime(2021,4,21)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,19),
                new DateTime(2021,4,20),
                new DateTime(2021,4,21)
            };

            var dataEnvio = new DateTime(2021, 4, 26);

            //Act
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 22);
            var dataEsperada2 = new DateTime(2021, 4, 23);
            var dataEsperada3 = new DateTime(2021, 4, 26);

            Assert.True(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
            Assert.Equal(dataEsperada2, diasPossiveis[1]);
            Assert.Equal(dataEsperada3, diasPossiveis[2]);
        }

        [Fact]
        public void CronogramaNosMesmosDiasDosFeriadosEFimDeSemanaNaSequencia_TresDiasDeSaldo()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,21),
                new DateTime(2021,4,22),
                new DateTime(2021,4,23)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,21),
                new DateTime(2021,4,22),
                new DateTime(2021,4,23)
            };

            var dataEnvio = new DateTime(2021, 4, 28);

            //Act
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 26);
            var dataEsperada2 = new DateTime(2021, 4, 27);
            var dataEsperada3 = new DateTime(2021, 4, 28);

            Assert.True(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
            Assert.Equal(dataEsperada2, diasPossiveis[1]);
            Assert.Equal(dataEsperada3, diasPossiveis[2]);
        }

        [Fact]
        public void DiasCronogramaAntesDoFeriado_SemSaldo()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,20),
                new DateTime(2021,4,21)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,19)
            };

            var dataEnvio = new DateTime(2021, 4, 22);

            //Act
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert->Retorna a propria data
            var dataEsperada1 = new DateTime(2021, 4, 19);

            Assert.True(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
        }

        [Fact]
        public void CronogramaNoDiaDoFeriado_HumDiaDeSaldo()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,21)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,21)
            };

            var dataEnvio = new DateTime(2021, 4, 21);

            //Act
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 22);

            Assert.False(validaEnvio);//Envio no feriado nao permitido->false
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
        }

        [Fact]
        public void CronogramaNaSextaFeriado_HumDeSemSaldo()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,23)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,23)
            };

            var dataEnvio = new DateTime(2021, 4, 26);

            //Act
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 26);

            Assert.True(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
        }

        [Fact]
        public void CronogramaCaiNoSabado_Bloqueia_HumDiaDeSaldo()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,21)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,24)
            };

            var dataEnvio = new DateTime(2021, 4, 24);

            //Act
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 26);

            Assert.False(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
        }

        [Fact]
        public void CronogramaCaiNoDomingo_Bloqueia_HumDiaDeSaldo()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,21)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,25)
            };

            var dataEnvio = new DateTime(2021, 4, 25);

            //Act
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 26);

            Assert.False(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
        }

        [Fact]
        public void CoronogramaEmFeriadosIntercaladosNaSemana_HumDiasDeSaldo()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,19),
                new DateTime(2021,4,21)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,19),
                new DateTime(2021,4,20),
            };

            var dataEnvio = new DateTime(2021, 4, 22);

            //Act 
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 22);

            Assert.True(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[1]);
        }

        [Fact]
        public void CoronogramaNoSabadoEFeriadoNaSegunda_Bloqueia_HumDiaDeSaldo()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,26),
                new DateTime(2021,4,27)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,24)
            };

            var dataEnvio = new DateTime(2021, 4, 28);

            //Act            
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 28);

            Assert.True(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
        }

        [Fact]
        public void CoronogramaNoDomingoEFeriadoNaSegunda_HumDiaDeSaldo()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,26)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,25)
            };

            var dataEnvio = new DateTime(2021, 4, 27);

            //Act            
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 27);

            Assert.True(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
        }

        [Fact]
        public void CoronogramaNoSabadoEFeriadoNaSegundaETerca_DoisDiaDeSaldo()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,26),
                new DateTime(2021,4,27)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,24)
            };

            var dataEnvio = new DateTime(2021, 4, 28);

            //Act            
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 28);

            Assert.True(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
        }

        [Fact]
        public void CoronogramaNosDiasDosFeriados_TresDiaDeSaldo()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,22),
                new DateTime(2021,4,23),
                new DateTime(2021,4,26),
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,22),
                new DateTime(2021,4,23),
                new DateTime(2021,4,26),
            };

            var dataEnvio = new DateTime(2021, 4, 29);

            //Act            
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 27);
            var dataEsperada2 = new DateTime(2021, 4, 28);
            var dataEsperada3 = new DateTime(2021, 4, 29);

            Assert.True(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
            Assert.Equal(dataEsperada2, diasPossiveis[1]);
            Assert.Equal(dataEsperada3, diasPossiveis[2]);
        }

        [Fact]
        public void CoronogramaFimDeSemana_DoisDiaDeSaldo()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,24),
                new DateTime(2021,4,25)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,24),
                new DateTime(2021,4,25)
            };

            var dataEnvio = new DateTime(2021, 4, 27);

            //Act            
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 26);
            var dataEsperada2 = new DateTime(2021, 4, 27);

            Assert.True(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
            Assert.Equal(dataEsperada2, diasPossiveis[1]);
        }

        [Fact]
        public void CoronogramaAposDataLimite_Bloqueia()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,21)                
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,19)                
            };

            var dataEnvio = new DateTime(2021, 4, 23);

            //Act            
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 19);            

            Assert.True(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);           
        }

        [Fact]
        public void CoronogramaComFeriado__HumDiaDeSaldo()
        {
            //Arranje
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

            //Act            
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 20);//Cronograma normal
            var dataEsperada2 = new DateTime(2021, 4, 22);//Cronograma normal
            var dataEsperada3 = new DateTime(2021, 4, 23);//Saldo do dia 21

            Assert.True(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
            Assert.Equal(dataEsperada2, diasPossiveis[1]);
            Assert.Equal(dataEsperada3, diasPossiveis[2]);
        }

        [Fact]
        public void CoronogramaEntreFeriados_Bloqueia()
        {
            //Arranje
            var listaFeriados = new List<DateTime>
            {
                new DateTime(2021,4,19),
                new DateTime(2021,4,20),
                new DateTime(2021,4,21),
                new DateTime(2021,4,23)
            };

            var datasCronograma = new List<DateTime>
            {
                new DateTime(2021,4,22)
            };

            var dataEnvio = new DateTime(2021, 4, 26);

            //Act            
            var validaEnvio = DiaEnvio.ValidaDiaDoEnvio(dataEnvio, listaFeriados);
            var diasPossiveis = Feriado.RelacionaCronogramaEFeriado(listaFeriados, datasCronograma, dataEnvio);

            //Assert
            var dataEsperada1 = new DateTime(2021, 4, 20);//Cronograma normal      

            Assert.True(validaEnvio);
            Assert.Equal(dataEsperada1, diasPossiveis[0]);
        }
    }
}
