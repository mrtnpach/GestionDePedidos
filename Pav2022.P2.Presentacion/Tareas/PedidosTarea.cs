using Pav2022.P2.Dominio.Entidades;
using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Presentadores;

namespace Pav2022.P2.Presentacion.Tareas
{
    public class PedidosTarea : TareaBase
    {
        public Pedido NuevoPedido { get; set; }

        public override void Iniciar(IVista mdiPadre = null)
        {
            MdiPadre = mdiPadre;
            NavegarA<ListaPedidosPresentador>(esMdiHijo: true, esDialogo: false);
        }
    }
}
