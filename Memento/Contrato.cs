using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Contrato
    {
        public DateTime Data { get; private set; }
        public string Cliente { get; private set; }
        public TipoContrato Tipo { get; set; }

        public Contrato(DateTime data, string cliente, TipoContrato tipo)
        {
            Data = data;
            Cliente = cliente;
            Tipo = tipo;
        }

        public void Avanca()
        {
            if (Tipo == TipoContrato.Novo)
            {
                Tipo = TipoContrato.EmAndamento;
            }
            else if (Tipo == TipoContrato.EmAndamento)
            {
                Tipo = TipoContrato.Acertado;
            }
            else if (Tipo == TipoContrato.Acertado)
            {
                Tipo = TipoContrato.Cocluido;
            }
        }

        public EstadoDoContrato SalvaEstado()
        {
            return new EstadoDoContrato(new Contrato(Data, Cliente, Tipo));
        }
    }
}
