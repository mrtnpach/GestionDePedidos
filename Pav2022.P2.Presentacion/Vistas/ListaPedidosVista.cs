using Pav2022.P2.Presentacion.Controles;
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
    public partial class ListaPedidosVista : ListaPedidosVistaConPresentador, IListaPedidosVista
    {
        private List<InfoPedidoControl> _infoPedidos = new List<InfoPedidoControl>();

        public ListaPedidosVista()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        #region Eventos
        private void tomarPedidoButton_Click(object sender, EventArgs e)
        {
            Presentador.IniciarTomaDePedido();
        }

        private void ListaPedidosVista_FormClosed(object sender, FormClosedEventArgs e)
        {
            Presentador.DesuscribirAPedidos();
        }
        #endregion Eventos

        public void MostrarPedidoPendiente(int id, int numero, int tiempo, decimal monto)
        {
            InfoPedidoControl info = new InfoPedidoControl(id, numero, tiempo, monto, estaListo: false);
            _infoPedidos.Add(info);
            pendientesPanel.Controls.Add(info);
        }

        public void QuitarPedidoPendiente(int id)
        {
            InfoPedidoControl info = _infoPedidos.Find(i => i.PedidoId == id);
            QuitarControlInfo(info, pendientesPanel);
        }

        public void MostrarPedidoListo(int id, int numero, int tiempo, decimal monto)
        {
            InfoPedidoControl info = new InfoPedidoControl(id, numero, tiempo, monto, estaListo: true);
            AgregarControlInfo(info, listosPanel);          
            info.EntregadoClicked += PendienteEntregadoClicked;
        }

        // Handler para el boton de entrega
        private void PendienteEntregadoClicked(object sender, int id)
        {
            Presentador.MarcarComoEntregado(id);
            //InfoPedidoControl info = _infoPedidos.Find(i => i.PedidoId == id);
            //_infoPedidos.Remove(info);
        }

        // Agregado de controles. Normalmente genera conflicto entre hilos.
        private void AgregarControlInfo(InfoPedidoControl info, FlowLayoutPanel panel)
        {
            if (InvokeRequired) BeginInvoke((Action)(() => { panel.Controls.Add(info); }));
            else panel.Controls.Add(info);
        }

        private void QuitarControlInfo(InfoPedidoControl info, FlowLayoutPanel panel)
        {
            if (InvokeRequired) BeginInvoke((Action)(() => { panel.Controls.Remove(info); }));
            else panel.Controls.Remove(info);
        }
    }

    public class ListaPedidosVistaConPresentador : VistaBaseGenerica<ListaPedidosPresentador> { }
}
