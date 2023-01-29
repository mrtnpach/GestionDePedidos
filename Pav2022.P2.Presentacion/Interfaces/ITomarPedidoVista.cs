using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2022.P2.Presentacion.Interfaces
{
    public interface ITomarPedidoVista : IVista
    {
        void ConfigurarBinding();
        void MostrarDetalleDeProducto(string descripcion, decimal precio, int tiempo);
        void MostrarNuevaLinea(int cantidad, string descripcion, decimal precio);
        void EliminarLineas();
        void HabilitarNuevaLinea();
        void DeshabilitarNuevaLinea();
        bool ConfirmarReinicioDePedido();
        void Cerrar();
    }
}
