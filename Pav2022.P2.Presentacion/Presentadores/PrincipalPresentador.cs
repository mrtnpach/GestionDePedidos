using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Tareas;

namespace Pav2022.P2.Presentacion.Presentadores
{
    public class PrincipalPresentador: PresentadorBase<TareaBase, IPrincipalVista>
    {
        public PrincipalPresentador(IPrincipalVista vista): base(vista)
        {

        }

        public void IniciarCreacionProducto()
        {
            AdministradorDeTareas.Instance.Iniciar<ProductoTarea>(Vista);
        }

        public void MostrarListaPedidos()
        {
            AdministradorDeTareas.Instance.Iniciar<PedidosTarea>(Vista);
        }
    }
}
