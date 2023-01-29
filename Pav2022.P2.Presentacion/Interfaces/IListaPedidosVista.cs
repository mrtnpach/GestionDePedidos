using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2022.P2.Presentacion.Interfaces
{
    public interface IListaPedidosVista : IVista
    {
        void MostrarPedidoPendiente(int id, int numero, int tiempo, decimal monto);
        void QuitarPedidoPendiente(int id);
        void MostrarPedidoListo(int id, int numero, int tiempo, decimal monto);
    }
}
