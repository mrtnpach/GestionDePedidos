using Pav2022.P2.Dominio.Contratos;
using Pav2022.P2.Dominio.Entidades;
using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Tareas;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Pav2022.P2.Presentacion.Presentadores
{
    public class TomarPedidoPresentador : PresentadorBase<PedidosTarea, ITomarPedidoVista>
    {
        public Pedido PedidoActual { get; private set; }
        public Producto ProductoSeleccionado { get; private set; }

        // El uso de dos repositorios distintos con contextos unicos es lo 
        // que causa en parte el problema del update del producto en la linea
        private IRepositorio<Pedido> _repoPedidos;
        private IRepositorio<Producto> _repoProductos;
        private List<Producto> _productos;

        public TomarPedidoPresentador
            (
                ITomarPedidoVista vista,
                IRepositorio<Pedido> repoPedidos, IRepositorio<Producto> repoProductos
            )
            : base(vista)
        {
            _repoPedidos = repoPedidos;
            _repoProductos = repoProductos;
            _productos = _repoProductos.GetTodos().ToList();
            ConfigurarPedido();
        }

        public override PedidosTarea Tarea 
        {
            get => base.Tarea;
            set
            {
                base.Tarea = value;
                base.Tarea.NuevoPedido = null;
            } 
        }

        private void ConfigurarPedido()
        {
            int numeroActual = ObtenerNumeroDePedido();
            PedidoActual = new Pedido(numeroActual);
            Vista.ConfigurarBinding();
        }

        private int ObtenerNumeroDePedido()
        {
            var pedidos = _repoPedidos.GetTodos().ToList();
            int numeroActual = (pedidos.Count == 0) ? 1 : pedidos.Last().Numero + 1;
            return numeroActual;
        }

        public void BuscarProducto(string codigoString)
        {
            int codigo;
            bool codigoValido = int.TryParse(codigoString, out codigo);

            if(codigoValido)
            {
                ProductoSeleccionado = _productos.Find(p => p.Codigo == codigo);
            }

            if(codigoValido && ProductoSeleccionado != null)
            {
                Vista.MostrarDetalleDeProducto(
                    ProductoSeleccionado.Descripcion, 
                    ProductoSeleccionado.Precio, 
                    ProductoSeleccionado.TiempoDePreparacion);
                Vista.HabilitarNuevaLinea();
            }           
            else
            {
                Vista.DeshabilitarNuevaLinea();
            }
        }

        public void AgregarLinea(string cantidadString)
        {
            int cantidad;
            bool esEntero = int.TryParse(cantidadString, out cantidad);
            if(cantidad > 0 && esEntero)
            {
                // Evita que se agregue el producto como nuevo
                // Solo funciona desde el repositorio de pedidos
                // (Arreglado en IoCContenedorUnity)
                //_repoPedidos.Refrescar(ProductoSeleccionado);

                PedidoActual.AgregarLinea(ProductoSeleccionado, cantidad);
                ActualizarLineas();
            }
            else
            {
                Vista.MostrarMensaje("Cantidad invalida.", "Atencion");
            }
        }

        private void ActualizarLineas()
        {
            Vista.EliminarLineas();
            foreach(LineaPedido linea in PedidoActual.Lineas)
            {
                Vista.MostrarNuevaLinea(linea.Cantidad, linea.Producto.Descripcion, linea.SubTotal);
            }
        }

        public void ConfirmarPedido()
        {
            try
            {
                int numeroActual = ObtenerNumeroDePedido();
                PedidoActual.ConfirmarPedido(numeroActual);

                _repoPedidos.Agregar(PedidoActual);
                _repoPedidos.UnidadDeTrabajo.Confirmar();

                Tarea.NuevoPedido = PedidoActual;

                Vista.MostrarMensaje(
                    $"Pedido {PedidoActual.Numero} iniciado.\nTiempo estimado: {PedidoActual.TiempoTotal} minutos",
                    "Pedido Iniciado");
                Vista.Cerrar();
            }
            catch(Exception e)
            {
                Vista.MostrarMensaje(e.Message, "Atencion");
            }         
        }

        public void ReiniciarPedido()
        {
            if(Vista.ConfirmarReinicioDePedido())
            {               
                PedidoActual.EliminarLineas();
                ActualizarLineas();
            }
        }
    }
}
