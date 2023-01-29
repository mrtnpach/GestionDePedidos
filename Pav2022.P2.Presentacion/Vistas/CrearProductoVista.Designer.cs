
namespace Pav2022.P2.Presentacion.Vistas
{
    partial class CrearProductoVista
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.cargarButton = new System.Windows.Forms.Button();
            this.panelDetalle = new System.Windows.Forms.TableLayoutPanel();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.precioLabel = new System.Windows.Forms.Label();
            this.tiempoLabel = new System.Windows.Forms.Label();
            this.codigoText = new System.Windows.Forms.TextBox();
            this.descripcionText = new System.Windows.Forms.TextBox();
            this.precioText = new System.Windows.Forms.TextBox();
            this.tiempoText = new System.Windows.Forms.TextBox();
            this.productoBSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelPrincipal.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.ColumnCount = 1;
            this.panelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPrincipal.Controls.Add(this.tituloLabel, 0, 0);
            this.panelPrincipal.Controls.Add(this.cargarButton, 0, 2);
            this.panelPrincipal.Controls.Add(this.panelDetalle, 0, 1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(10, 10);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.RowCount = 3;
            this.panelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelPrincipal.Size = new System.Drawing.Size(812, 483);
            this.panelPrincipal.TabIndex = 0;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.BackColor = System.Drawing.Color.LightSalmon;
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tituloLabel.Location = new System.Drawing.Point(3, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(806, 50);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "NUEVO PRODUCTO";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cargarButton
            // 
            this.cargarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cargarButton.BackColor = System.Drawing.Color.Coral;
            this.cargarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cargarButton.ForeColor = System.Drawing.Color.White;
            this.cargarButton.Location = new System.Drawing.Point(715, 443);
            this.cargarButton.Name = "cargarButton";
            this.cargarButton.Size = new System.Drawing.Size(94, 29);
            this.cargarButton.TabIndex = 1;
            this.cargarButton.Text = "Cargar";
            this.cargarButton.UseVisualStyleBackColor = false;
            this.cargarButton.Click += new System.EventHandler(this.cargarButton_Click);
            // 
            // panelDetalle
            // 
            this.panelDetalle.ColumnCount = 2;
            this.panelDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.panelDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDetalle.Controls.Add(this.numeroLabel, 0, 0);
            this.panelDetalle.Controls.Add(this.descripcionLabel, 0, 1);
            this.panelDetalle.Controls.Add(this.precioLabel, 0, 2);
            this.panelDetalle.Controls.Add(this.tiempoLabel, 0, 3);
            this.panelDetalle.Controls.Add(this.codigoText, 1, 0);
            this.panelDetalle.Controls.Add(this.descripcionText, 1, 1);
            this.panelDetalle.Controls.Add(this.precioText, 1, 2);
            this.panelDetalle.Controls.Add(this.tiempoText, 1, 3);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalle.Location = new System.Drawing.Point(3, 53);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.RowCount = 4;
            this.panelDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelDetalle.Size = new System.Drawing.Size(806, 377);
            this.panelDetalle.TabIndex = 2;
            // 
            // numeroLabel
            // 
            this.numeroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numeroLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numeroLabel.Location = new System.Drawing.Point(3, 34);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(244, 25);
            this.numeroLabel.TabIndex = 0;
            this.numeroLabel.Text = "Codigo:";
            this.numeroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descripcionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.descripcionLabel.Location = new System.Drawing.Point(3, 128);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(244, 25);
            this.descripcionLabel.TabIndex = 1;
            this.descripcionLabel.Text = "Descripcion:";
            this.descripcionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // precioLabel
            // 
            this.precioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.precioLabel.AutoSize = true;
            this.precioLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.precioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.precioLabel.Location = new System.Drawing.Point(3, 222);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(244, 25);
            this.precioLabel.TabIndex = 2;
            this.precioLabel.Text = "Precio:";
            this.precioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tiempoLabel
            // 
            this.tiempoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tiempoLabel.AutoSize = true;
            this.tiempoLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tiempoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tiempoLabel.Location = new System.Drawing.Point(3, 317);
            this.tiempoLabel.Name = "tiempoLabel";
            this.tiempoLabel.Size = new System.Drawing.Size(244, 25);
            this.tiempoLabel.TabIndex = 3;
            this.tiempoLabel.Text = "Tiempo de preparacion:";
            this.tiempoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // codigoText
            // 
            this.codigoText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.codigoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codigoText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codigoText.ForeColor = System.Drawing.Color.White;
            this.codigoText.Location = new System.Drawing.Point(253, 35);
            this.codigoText.Name = "codigoText";
            this.codigoText.Size = new System.Drawing.Size(550, 24);
            this.codigoText.TabIndex = 4;
            // 
            // descripcionText
            // 
            this.descripcionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.descripcionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descripcionText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descripcionText.ForeColor = System.Drawing.Color.White;
            this.descripcionText.Location = new System.Drawing.Point(253, 129);
            this.descripcionText.Name = "descripcionText";
            this.descripcionText.Size = new System.Drawing.Size(550, 24);
            this.descripcionText.TabIndex = 5;
            // 
            // precioText
            // 
            this.precioText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.precioText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.precioText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precioText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.precioText.ForeColor = System.Drawing.Color.White;
            this.precioText.Location = new System.Drawing.Point(253, 223);
            this.precioText.Name = "precioText";
            this.precioText.Size = new System.Drawing.Size(550, 24);
            this.precioText.TabIndex = 6;
            // 
            // tiempoText
            // 
            this.tiempoText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tiempoText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tiempoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tiempoText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tiempoText.ForeColor = System.Drawing.Color.White;
            this.tiempoText.Location = new System.Drawing.Point(253, 317);
            this.tiempoText.Name = "tiempoText";
            this.tiempoText.Size = new System.Drawing.Size(550, 24);
            this.tiempoText.TabIndex = 7;
            // 
            // CrearProductoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.panelPrincipal);
            this.MaximumSize = new System.Drawing.Size(850, 550);
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "CrearProductoVista";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearProductoVista";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelPrincipal;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button cargarButton;
        private System.Windows.Forms.TableLayoutPanel panelDetalle;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.Label precioLabel;
        private System.Windows.Forms.Label tiempoLabel;
        private System.Windows.Forms.TextBox codigoText;
        private System.Windows.Forms.TextBox descripcionText;
        private System.Windows.Forms.TextBox precioText;
        private System.Windows.Forms.TextBox tiempoText;
        private System.Windows.Forms.BindingSource productoBSource;
    }
}