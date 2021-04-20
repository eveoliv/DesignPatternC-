using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class HistoricoDoContrato
    {
        private List<EstadoDoContrato> Estados = new List<EstadoDoContrato>();

        public void Adiciona(EstadoDoContrato estado)
        {
            Estados.Add(estado);
        }

        public EstadoDoContrato Pega(int indice)
        {
            return Estados[indice];

        }
    }
}
