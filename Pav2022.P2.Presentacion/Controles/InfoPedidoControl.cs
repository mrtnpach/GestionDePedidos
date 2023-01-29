using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pav2022.P2.Presentacion.Controles
{
    public partial class InfoPedidoControl : UserControl
    {
        public event EventHandler<int> EntregadoClicked;
        public readonly int PedidoId;

        public InfoPedidoControl(int id, int numero, int tiempo, decimal monto, bool estaListo)
        {
            InitializeComponent();
            PedidoId = id;
            ConfigurarDatos(numero, tiempo, monto);
            ConfigurarAspecto(estaListo);
        }

        private void ConfigurarAspecto(bool estaListo)
        {
            if (!estaListo)
            {
                entregadoButton.Visible = false;
                BackColor = Color.FromArgb(70, 70, 70);
            }
        }

        private void ConfigurarDatos(int numero, int tiempo, decimal monto)
        {
            numeroLabel.Text = $"Pedido: {numero}";
            tiempoLabel.Text = $"Tiempo: {tiempo} min.";
            montoLabel.Text = $"Total: ${monto}";
        }

        private void entregadoButton_Click(object sender, EventArgs e)
        {
            EntregadoClicked?.Invoke(this, PedidoId);
            Parent.Controls.Remove(this);
            Dispose();
        }
    }
}
