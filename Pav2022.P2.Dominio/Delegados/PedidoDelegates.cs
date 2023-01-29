using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2022.P2.Dominio.Delegados
{
    public delegate void PedidoListoDelegate(PedidoListoEventArgs e);

    public class PedidoListoEventArgs
    {
        public PedidoListoEventArgs(int id, int numero)
        {
            IdPedido = id;
            NumeroPedido = numero;
        }

        public readonly int IdPedido;
        public readonly int NumeroPedido;
    }
}
