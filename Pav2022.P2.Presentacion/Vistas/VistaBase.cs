using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Presentadores;

namespace Pav2022.P2.Presentacion.Vistas
{
    /// <summary>
    /// Implementación base de la interfaz <see cref="IVista"/> para formularios de Windows.
    /// Esta clase sirve para ser heredada.
    /// <para>
    /// Se recomienda el uso de la versión genérica de la clase <see cref="VistaBaseGenerica{T}"/>
    /// con asociación fuertemente tipada al presentador.
    /// </para>
    /// </summary>
    public class VistaBase : Form, IVista
    {
        /// <summary>
        /// Propiedad para acceder al presentador desde la vista. Implementaciónd de <see cref="IVista.Presentador"/>
        /// </summary>
        public virtual IPresentador Presentador { get; set; }

        /// <summary>
        /// Implementación de <see cref="IVista.Mostrar(IVista)"/>
        /// </summary>
        public void Mostrar(IVista padre = null)
        {
            if (padre != null)
            {
                MdiParent = (Form)padre;
            }
            Show();
        }

        /// <summary>
        /// Implementación de <see cref="IVista.MostrarComoDialogo"/>
        /// </summary>
        public void MostrarComoDialogo()
        {
            ShowDialog();
        }

        /// <summary>
        /// Muestra un MessageBox con el mensaje y titulo especificado
        /// </summary>
        /// <param name="mensaje">Mensaje del MessageBox</param>
        /// <param name="titulo">TiTulo del MessageBox</param>
        public void MostrarMensaje(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo);
        }

        /// <summary>
        /// Método especial para validar que se ingresen solo números en 
        /// un cuadro de texto.
        /// </summary>
        /// <param name="sender">Cuadro de texto a validar</param>
        protected void SoloNumeros(TextBox sender)
        {
            var text = sender.Text;
            var pos = sender.SelectionStart;

            Regex rgx = new Regex("[^0-9]");

            text = rgx.Replace(text, "");

            sender.Text = text;

            sender.Select(Math.Max(pos, 0), 0);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // VistaBase
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "VistaBase";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ResumeLayout(false);

        }
    }
}
