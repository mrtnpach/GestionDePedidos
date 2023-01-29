using Pav2022.P2.Dominio.Contratos;
using Pav2022.P2.Dominio.Delegados;
using Pav2022.P2.Dominio.Entidades;
using Pav2022.P2.Dominio.Enumeraciones;
using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Tareas;
using System.Linq;

namespace Pav2022.P2.Presentacion.Presentadores
{
    public class ListaPedidosPresentador : PresentadorBase<PedidosTarea, IListaPedidosVista>
    {
        private IRepositorio<Pedido> _repo;

        public ListaPedidosPresentador(IListaPedidosVista vista, IRepositorio<Pedido> repo)
            : base(vista)
        {
            _repo = repo;
            CargarTodosLosPedidos();
            MonitorDePedidos.Instancia.PedidoListo += OnPedidoListo;
        }

        public void IniciarTomaDePedido()
        {
            Tarea.NavegarA<TomarPedidoPresentador>(esMdiHijo: false, esDialogo: true);
            if(Tarea.NuevoPedido != null)
            {
                Tarea.NuevoPedido?.IniciarPreparacion();
                AgregarInfoPendiente(Tarea.NuevoPedido.Id);
            }
        }

        private void AgregarInfoPendiente(int id)
        {
            Pedido pedido = _repo.Get(id);
            if(pedido != null)
            {
                Vista.MostrarPedidoPendiente(pedido.Id, pedido.Numero, pedido.TiempoTotal, pedido.MontoTotal);
            }
        }

        private void AgregarInfoListo(int id)
        {
            Pedido pedido = _repo.Get(id);
            if (pedido != null)
            {
                Vista.MostrarPedidoListo(pedido.Id, pedido.Numero, pedido.TiempoTotal, pedido.MontoTotal);
            }
        }

        private void CargarTodosLosPedidos()
        {
            var porEstado = _repo.GetTodos().GroupBy(p => p.Estado);
            foreach (var grupo in porEstado)
            {
                if (grupo.Key == EstadoPedido.Pendiente)
                {
                    foreach (var pedido in grupo)
                        AgregarInfoPendiente(pedido.Id);
                }
                else if (grupo.Key == EstadoPedido.Listo)
                {
                    foreach (var pedido in grupo)
                        AgregarInfoListo(pedido.Id);
                }
            }
        }

        // Handler para los pedidos listos
        private void OnPedidoListo(PedidoListoEventArgs e)
        {
            Pedido pedidoListo = _repo.Get(e.IdPedido);
            // La solucion al update del pedido en el container soliciona esto.
            //pedidoListo.SetListo();     // El pedido deberia setearse Listo solo.
            _repo.Modificar(pedidoListo);
            _repo.UnidadDeTrabajo.Confirmar();
            Vista.QuitarPedidoPendiente(pedidoListo.Id);
            AgregarInfoListo(pedidoListo.Id);
        }

        public void MarcarComoEntregado(int id)
        {
            Pedido pedido = _repo.Get(id);
            pedido.Entregar();
            _repo.Modificar(pedido);
            _repo.UnidadDeTrabajo.Confirmar();
        }

        public void DesuscribirAPedidos()
        {
            MonitorDePedidos.Instancia.PedidoListo -= OnPedidoListo;
        }
    }
}
