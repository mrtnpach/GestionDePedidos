using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pav2022.P2.Presentacion.Vistas
{
    public partial class TomarPedidoVista : TomarPedidoVistaConPresentador, ITomarPedidoVista
    {
        public TomarPedidoVista()
        {
            InitializeComponent();
            DeshabilitarNuevaLinea();
        }

        #region Eventos
        private void busquedaText_TextChanged(object sender, EventArgs e)
        {
            Presentador.BuscarProducto(busquedaText.Text);
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            Presentador.AgregarLinea(cantidadText.Text);
        }

        private void confirmarButton_Click(object sender, EventArgs e)
        {
            Presentador.ConfirmarPedido();
        }

        private void reiniciarButton_Click(object sender, EventArgs e)
        {
            Presentador.ReiniciarPedido();
        }
        #endregion Eventos

        #region Binding
        public void ConfigurarBinding()
        {
            pedidoBSource.DataSource = Presentador.PedidoActual;
            montoLabel.DataBindings.Add("Text", pedidoBSource, "MontoTotal", true, DataSourceUpdateMode.Never, null, "C2");
        }
        #endregion Binding

        public void MostrarDetalleDeProducto(string descripcion, decimal precio, int tiempo)
        {
            descripcionLabel.Text = descripcion;
            precioLabel.Text = $"Precio: ${precio}";
            tiempoLabel.Text = $"Tiempo de preparacion: {tiempo} minutos";
        }
       
        public void HabilitarNuevaLinea()
        {
            agregarButton.Enabled = true;
        }

        public void DeshabilitarNuevaLinea()
        {
            descripcionLabel.Text = string.Empty;
            precioLabel.Text = string.Empty;
            tiempoLabel.Text = string.Empty;
            agregarButton.Enabled = false;
        }

        public void MostrarNuevaLinea(int cantidad, string descripcion, decimal precio)
        {
            lineasGrid.Rows.Add(cantidad, descripcion, precio);
            pedidoBSource.ResetBindings(true);
        }

        public void EliminarLineas()
        {
            lineasGrid.Rows.Clear();
            pedidoBSource.ResetBindings(true);
        }
      
        public bool ConfirmarReinicioDePedido()
        {
            var resultado = MessageBox.Show(
                "Esta accion va a quitar todas las lineas del pedido. Desea continuar?",
                "Reiniciar pedido",
                MessageBoxButtons.YesNo);
            return resultado == DialogResult.Yes;
        }
      
        public void Cerrar()
        {
            Close();
        }
    }

    public class TomarPedidoVistaConPresentador : VistaBaseGenerica<TomarPedidoPresentador> { }
}
