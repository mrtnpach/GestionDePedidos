using Pav2022.P2.Dominio.Enumeraciones;
using Pav2022.P2.Dominio.Delegados;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Timers;

namespace Pav2022.P2.Dominio.Entidades
{
    public class Pedido : EntidadBase
    {
        public int Numero { get; set; }
        public string Fecha { get; set; }
        public decimal MontoTotal { get; set; }
        public EstadoPedido Estado { get; set; }

        public ICollection<LineaPedido> Lineas { get; set; } = new List<LineaPedido>();

        // Preparacion del pedido
        public int TiempoTotal { get; private set; }
        private Timer _preparacion;
        private event PedidoListoDelegate PedidoListo;  // Considerar si es necesario hacerlo publico
        public bool Iniciado { get; private set; } = false;

        public Pedido()
        {

        }

        public Pedido(int numero)
        {
            Numero = numero;           
            Fecha = DateTime.Now.ToString("d/M/yy");
        }

        public void AgregarLinea(Producto producto, int cantidad)
        {
            LineaPedido linea = Lineas.SingleOrDefault(l => l.Producto.Id == producto.Id);
            if(linea == null)
            {
                linea = new LineaPedido(producto, cantidad);
                Lineas.Add(linea);
            }
            else
            {
                linea.Cantidad += cantidad;
            }
            MontoTotal += producto.Precio * cantidad;
        }
     
        public void ConfirmarPedido(int numeroPedido)
        {
            if (Lineas.Count == 0) throw new Exception("El pedido no tiene lineas.");

            Numero = numeroPedido;
            SetTiempoTotal();
            PedidoListo += MonitorDePedidos.Instancia.Delegado;
            Fecha = DateTime.Now.ToString("d/M/yy");
        }

        private void SetTiempoTotal()
        {
            int sumaTiempos = Lineas.Sum(l => l.TiempoDePreparacion);
            int tiempoMaximo = Lineas.Max(l => l.Producto.TiempoDePreparacion);
            if(sumaTiempos <= 15)
            {
                TiempoTotal = tiempoMaximo;
            }
            else if(sumaTiempos > 15 && sumaTiempos <= 20)
            {
                TiempoTotal = tiempoMaximo + 7;
            }
            else if(sumaTiempos > 20)
            {
                int decenas = (sumaTiempos / 10) - 1;
                TiempoTotal = tiempoMaximo + 5 + decenas * 5;
            }
        }

        public void IniciarPreparacion()
        {
            if(!Iniciado && TiempoTotal > 0)
            {
                Iniciado = true;
                _preparacion = new Timer(TiempoTotal * 1000);
                _preparacion.Elapsed += OnPedidoListo;
                _preparacion.Start();
                Estado = EstadoPedido.Pendiente;
            }
        }

        private void OnPedidoListo(object sender, ElapsedEventArgs e)
        {
            _preparacion.Stop();
            Estado = EstadoPedido.Listo;
            PedidoListoEventArgs args = new PedidoListoEventArgs(Id, Numero);
            PedidoListo?.Invoke(args);
        }

        public void Entregar()
        {
            if(Estado == EstadoPedido.Listo)
            {
                Estado = EstadoPedido.Finalizado;
            }
        }

        public void EliminarLineas()
        {
            if(!Iniciado)
            {
                Lineas.Clear();
                MontoTotal = 0;
            }           
        }
    }
}
