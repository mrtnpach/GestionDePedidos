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
    public partial class CrearProductoVista : CrearProductolVistaConPresentador, ICrearProductoVista
    {
        public CrearProductoVista()
        {
            InitializeComponent();
            ConfigurarBindingSource();
        }

        #region Eventos
        private void cargarButton_Click(object sender, EventArgs e)
        {
            if (InvokeRequired) BeginInvoke((Action)(() => OnCargarClick()));
            else OnCargarClick();
        }
        #endregion Eventos

        #region Binding
        private void ConfigurarBindingSource()
        {
            codigoText.DataBindings.Add(new Binding("Text", productoBSource, "Codigo"));
            descripcionText.DataBindings.Add(new Binding("Text", productoBSource, "Descripcion"));
            precioText.DataBindings.Add(new Binding("Text", productoBSource, "Precio", true, DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
            tiempoText.DataBindings.Add(new Binding("Text", productoBSource, "TiempoDePreparacion"));
        }
        #endregion Binding

        public void CargarProductoSource()
        {
            productoBSource.DataSource = Presentador.ProductoSource;
            productoBSource.ResetBindings(true);
        }

        private void OnCargarClick()
        {
            Presentador.CargarProducto();
        }
    }

    public class CrearProductolVistaConPresentador : VistaBaseGenerica<CrearProductoPresentador> { }
}
