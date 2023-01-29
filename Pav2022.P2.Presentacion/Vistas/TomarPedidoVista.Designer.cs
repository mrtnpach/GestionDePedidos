
namespace Pav2022.P2.Presentacion.Vistas
{
    partial class TomarPedidoVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelPedido = new System.Windows.Forms.TableLayoutPanel();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.panelLinea = new System.Windows.Forms.TableLayoutPanel();
            this.panelBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.busquedaText = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.agregarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.agregarButton = new System.Windows.Forms.Button();
            this.cantidadText = new System.Windows.Forms.TextBox();
            this.panelDetalle = new System.Windows.Forms.TableLayoutPanel();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.precioLabel = new System.Windows.Forms.Label();
            this.tiempoLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.confirmarButton = new System.Windows.Forms.Button();
            this.reiniciarButton = new System.Windows.Forms.Button();
            this.panelDatos = new System.Windows.Forms.TableLayoutPanel();
            this.montoLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.lineasGrid = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoBSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelPrincipal.SuspendLayout();
            this.panelPedido.SuspendLayout();
            this.panelLinea.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.agregarPanel.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineasGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.ColumnCount = 2;
            this.panelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.55804F));
            this.panelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.44196F));
            this.panelPrincipal.Controls.Add(this.panelPedido, 0, 0);
            this.panelPrincipal.Controls.Add(this.lineasGrid, 1, 0);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(10, 10);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.RowCount = 1;
            this.panelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPrincipal.Size = new System.Drawing.Size(1162, 633);
            this.panelPrincipal.TabIndex = 1;
            // 
            // panelPedido
            // 
            this.panelPedido.ColumnCount = 1;
            this.panelPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPedido.Controls.Add(this.tituloLabel, 0, 0);
            this.panelPedido.Controls.Add(this.panelLinea, 0, 1);
            this.panelPedido.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.panelPedido.Controls.Add(this.panelDatos, 0, 2);
            this.panelPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPedido.Location = new System.Drawing.Point(3, 3);
            this.panelPedido.Name = "panelPedido";
            this.panelPedido.RowCount = 4;
            this.panelPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.panelPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.panelPedido.Size = new System.Drawing.Size(581, 627);
            this.panelPedido.TabIndex = 0;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.BackColor = System.Drawing.Color.LightSalmon;
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloLabel.Location = new System.Drawing.Point(3, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(575, 50);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "NUEVO PEDIDO";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLinea
            // 
            this.panelLinea.ColumnCount = 1;
            this.panelLinea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelLinea.Controls.Add(this.panelBusqueda, 0, 0);
            this.panelLinea.Controls.Add(this.agregarPanel, 0, 2);
            this.panelLinea.Controls.Add(this.panelDetalle, 0, 1);
            this.panelLinea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLinea.Location = new System.Drawing.Point(3, 53);
            this.panelLinea.Name = "panelLinea";
            this.panelLinea.RowCount = 3;
            this.panelLinea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.panelLinea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelLinea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.panelLinea.Size = new System.Drawing.Size(575, 431);
            this.panelLinea.TabIndex = 2;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.Bisque;
            this.panelBusqueda.ColumnCount = 2;
            this.panelBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.panelBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelBusqueda.Controls.Add(this.busquedaText, 1, 0);
            this.panelBusqueda.Controls.Add(this.codigoLabel, 0, 0);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBusqueda.Location = new System.Drawing.Point(3, 3);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.RowCount = 1;
            this.panelBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.panelBusqueda.Size = new System.Drawing.Size(569, 69);
            this.panelBusqueda.TabIndex = 1;
            // 
            // busquedaText
            // 
            this.busquedaText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.busquedaText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.busquedaText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.busquedaText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.busquedaText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.busquedaText.Location = new System.Drawing.Point(103, 27);
            this.busquedaText.Name = "busquedaText";
            this.busquedaText.Size = new System.Drawing.Size(463, 24);
            this.busquedaText.TabIndex = 0;
            this.busquedaText.TextChanged += new System.EventHandler(this.busquedaText_TextChanged);
            // 
            // codigoLabel
            // 
            this.codigoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codigoLabel.Location = new System.Drawing.Point(3, 27);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(94, 25);
            this.codigoLabel.TabIndex = 0;
            this.codigoLabel.Text = "Codigo:";
            this.codigoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // agregarPanel
            // 
            this.agregarPanel.BackColor = System.Drawing.Color.Bisque;
            this.agregarPanel.ColumnCount = 3;
            this.agregarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.agregarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.agregarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.agregarPanel.Controls.Add(this.cantidadLabel, 0, 0);
            this.agregarPanel.Controls.Add(this.agregarButton, 2, 0);
            this.agregarPanel.Controls.Add(this.cantidadText, 1, 0);
            this.agregarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agregarPanel.Location = new System.Drawing.Point(3, 359);
            this.agregarPanel.Name = "agregarPanel";
            this.agregarPanel.RowCount = 1;
            this.agregarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.agregarPanel.Size = new System.Drawing.Size(569, 69);
            this.agregarPanel.TabIndex = 2;
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cantidadLabel.Location = new System.Drawing.Point(3, 22);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(94, 25);
            this.cantidadLabel.TabIndex = 0;
            this.cantidadLabel.Text = "Cantidad:";
            this.cantidadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // agregarButton
            // 
            this.agregarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.agregarButton.BackColor = System.Drawing.Color.Coral;
            this.agregarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.agregarButton.ForeColor = System.Drawing.Color.White;
            this.agregarButton.Location = new System.Drawing.Point(472, 20);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(94, 29);
            this.agregarButton.TabIndex = 1;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = false;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // cantidadText
            // 
            this.cantidadText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cantidadText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.cantidadText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cantidadText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cantidadText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cantidadText.Location = new System.Drawing.Point(103, 23);
            this.cantidadText.Name = "cantidadText";
            this.cantidadText.Size = new System.Drawing.Size(125, 23);
            this.cantidadText.TabIndex = 2;
            // 
            // panelDetalle
            // 
            this.panelDetalle.ColumnCount = 1;
            this.panelDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDetalle.Controls.Add(this.descripcionLabel, 0, 0);
            this.panelDetalle.Controls.Add(this.precioLabel, 0, 1);
            this.panelDetalle.Controls.Add(this.tiempoLabel, 0, 2);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalle.Location = new System.Drawing.Point(3, 78);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.RowCount = 3;
            this.panelDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelDetalle.Size = new System.Drawing.Size(569, 275);
            this.panelDetalle.TabIndex = 3;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descripcionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.descripcionLabel.Location = new System.Drawing.Point(3, 0);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(126, 28);
            this.descripcionLabel.TabIndex = 0;
            this.descripcionLabel.Text = "[Descripcion]";
            // 
            // precioLabel
            // 
            this.precioLabel.AutoSize = true;
            this.precioLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.precioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.precioLabel.Location = new System.Drawing.Point(3, 175);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(78, 28);
            this.precioLabel.TabIndex = 1;
            this.precioLabel.Text = "[Precio]";
            // 
            // tiempoLabel
            // 
            this.tiempoLabel.AutoSize = true;
            this.tiempoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tiempoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tiempoLabel.Location = new System.Drawing.Point(3, 225);
            this.tiempoLabel.Name = "tiempoLabel";
            this.tiempoLabel.Size = new System.Drawing.Size(90, 28);
            this.tiempoLabel.TabIndex = 2;
            this.tiempoLabel.Text = "[Tiempo]";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.confirmarButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.reiniciarButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 565);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 59);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // confirmarButton
            // 
            this.confirmarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.confirmarButton.BackColor = System.Drawing.Color.Coral;
            this.confirmarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmarButton.ForeColor = System.Drawing.Color.White;
            this.confirmarButton.Location = new System.Drawing.Point(478, 15);
            this.confirmarButton.Name = "confirmarButton";
            this.confirmarButton.Size = new System.Drawing.Size(94, 29);
            this.confirmarButton.TabIndex = 1;
            this.confirmarButton.Text = "Confirmar";
            this.confirmarButton.UseVisualStyleBackColor = false;
            this.confirmarButton.Click += new System.EventHandler(this.confirmarButton_Click);
            // 
            // reiniciarButton
            // 
            this.reiniciarButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.reiniciarButton.BackColor = System.Drawing.Color.Coral;
            this.reiniciarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reiniciarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reiniciarButton.ForeColor = System.Drawing.Color.White;
            this.reiniciarButton.Location = new System.Drawing.Point(3, 15);
            this.reiniciarButton.Name = "reiniciarButton";
            this.reiniciarButton.Size = new System.Drawing.Size(94, 29);
            this.reiniciarButton.TabIndex = 2;
            this.reiniciarButton.Text = "Reiniciar";
            this.reiniciarButton.UseVisualStyleBackColor = false;
            this.reiniciarButton.Click += new System.EventHandler(this.reiniciarButton_Click);
            // 
            // panelDatos
            // 
            this.panelDatos.ColumnCount = 2;
            this.panelDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDatos.Controls.Add(this.montoLabel, 1, 0);
            this.panelDatos.Controls.Add(this.totalLabel, 0, 0);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatos.Location = new System.Drawing.Point(3, 490);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.RowCount = 1;
            this.panelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDatos.Size = new System.Drawing.Size(575, 69);
            this.panelDatos.TabIndex = 4;
            // 
            // montoLabel
            // 
            this.montoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.montoLabel.AutoSize = true;
            this.montoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.montoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.montoLabel.Location = new System.Drawing.Point(290, 20);
            this.montoLabel.Name = "montoLabel";
            this.montoLabel.Size = new System.Drawing.Size(282, 28);
            this.montoLabel.TabIndex = 0;
            this.montoLabel.Text = "[MontoTotal]";
            this.montoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.totalLabel.Location = new System.Drawing.Point(3, 22);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(281, 25);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "Total:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lineasGrid
            // 
            this.lineasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lineasGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Producto,
            this.SubTotal});
            this.lineasGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineasGrid.Location = new System.Drawing.Point(590, 3);
            this.lineasGrid.Name = "lineasGrid";
            this.lineasGrid.RowHeadersWidth = 51;
            this.lineasGrid.RowTemplate.Height = 29;
            this.lineasGrid.Size = new System.Drawing.Size(569, 627);
            this.lineasGrid.TabIndex = 1;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad.HeaderText = "Cant.";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 71;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SubTotal.HeaderText = "Subtotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 94;
            // 
            // TomarPedidoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panelPrincipal);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(950, 590);
            this.Name = "TomarPedidoVista";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TomarPedidoVista";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPedido.ResumeLayout(false);
            this.panelPedido.PerformLayout();
            this.panelLinea.ResumeLayout(false);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.agregarPanel.ResumeLayout(false);
            this.agregarPanel.PerformLayout();
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineasGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelPrincipal;
        private System.Windows.Forms.TableLayoutPanel panelPedido;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button confirmarButton;
        private System.Windows.Forms.TableLayoutPanel panelLinea;
        private System.Windows.Forms.TableLayoutPanel panelBusqueda;
        private System.Windows.Forms.TextBox busquedaText;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TableLayoutPanel agregarPanel;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.TextBox cantidadText;
        private System.Windows.Forms.DataGridView lineasGrid;
        private System.Windows.Forms.TableLayoutPanel panelDetalle;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.Label precioLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button reiniciarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.TableLayoutPanel panelDatos;
        private System.Windows.Forms.BindingSource pedidoBSource;
        private System.Windows.Forms.Label montoLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tiempoLabel;
    }
}