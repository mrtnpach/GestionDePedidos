
namespace Pav2022.P2.Presentacion.Vistas
{
    partial class ListaPedidosVista
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
            this.panelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelListas = new System.Windows.Forms.TableLayoutPanel();
            this.pendientesLabel = new System.Windows.Forms.Label();
            this.listosLabel = new System.Windows.Forms.Label();
            this.pendientesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.listosPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tomarPedidoButton = new System.Windows.Forms.ToolStripButton();
            this.panelPrincipal.SuspendLayout();
            this.panelListas.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.ColumnCount = 1;
            this.panelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPrincipal.Controls.Add(this.panelListas, 0, 1);
            this.panelPrincipal.Controls.Add(this.toolStrip, 0, 0);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(10, 10);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.RowCount = 2;
            this.panelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.panelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPrincipal.Size = new System.Drawing.Size(1262, 683);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelListas
            // 
            this.panelListas.ColumnCount = 2;
            this.panelListas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelListas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelListas.Controls.Add(this.pendientesLabel, 0, 0);
            this.panelListas.Controls.Add(this.listosLabel, 1, 0);
            this.panelListas.Controls.Add(this.pendientesPanel, 0, 1);
            this.panelListas.Controls.Add(this.listosPanel, 1, 1);
            this.panelListas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListas.Location = new System.Drawing.Point(3, 63);
            this.panelListas.Name = "panelListas";
            this.panelListas.RowCount = 2;
            this.panelListas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelListas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelListas.Size = new System.Drawing.Size(1256, 617);
            this.panelListas.TabIndex = 0;
            // 
            // pendientesLabel
            // 
            this.pendientesLabel.AutoSize = true;
            this.pendientesLabel.BackColor = System.Drawing.Color.LightSalmon;
            this.pendientesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pendientesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pendientesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pendientesLabel.Location = new System.Drawing.Point(3, 0);
            this.pendientesLabel.Name = "pendientesLabel";
            this.pendientesLabel.Size = new System.Drawing.Size(622, 50);
            this.pendientesLabel.TabIndex = 0;
            this.pendientesLabel.Text = "PEDIDOS PENDIENTES";
            this.pendientesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listosLabel
            // 
            this.listosLabel.AutoSize = true;
            this.listosLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.listosLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listosLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listosLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listosLabel.Location = new System.Drawing.Point(631, 0);
            this.listosLabel.Name = "listosLabel";
            this.listosLabel.Size = new System.Drawing.Size(622, 50);
            this.listosLabel.TabIndex = 1;
            this.listosLabel.Text = "PEDIDOS LISTOS";
            this.listosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pendientesPanel
            // 
            this.pendientesPanel.AutoScroll = true;
            this.pendientesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pendientesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pendientesPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pendientesPanel.Location = new System.Drawing.Point(3, 53);
            this.pendientesPanel.Name = "pendientesPanel";
            this.pendientesPanel.Size = new System.Drawing.Size(622, 561);
            this.pendientesPanel.TabIndex = 2;
            // 
            // listosPanel
            // 
            this.listosPanel.AutoScroll = true;
            this.listosPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listosPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listosPanel.Location = new System.Drawing.Point(631, 53);
            this.listosPanel.Name = "listosPanel";
            this.listosPanel.Size = new System.Drawing.Size(622, 561);
            this.listosPanel.TabIndex = 3;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Bisque;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tomarPedidoButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1262, 60);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "Menu";
            // 
            // tomarPedidoButton
            // 
            this.tomarPedidoButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tomarPedidoButton.BackColor = System.Drawing.Color.PeachPuff;
            this.tomarPedidoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tomarPedidoButton.Image = global::Pav2022.P2.Presentacion.Properties.Resources.plus;
            this.tomarPedidoButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tomarPedidoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tomarPedidoButton.Name = "tomarPedidoButton";
            this.tomarPedidoButton.Size = new System.Drawing.Size(29, 57);
            this.tomarPedidoButton.Text = "Tomar Pedido";
            this.tomarPedidoButton.Click += new System.EventHandler(this.tomarPedidoButton_Click);
            // 
            // ListaPedidosVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.panelPrincipal);
            this.MinimumSize = new System.Drawing.Size(1300, 750);
            this.Name = "ListaPedidosVista";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListaPedidosVista";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListaPedidosVista_FormClosed);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelListas.ResumeLayout(false);
            this.panelListas.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelPrincipal;
        private System.Windows.Forms.TableLayoutPanel panelListas;
        private System.Windows.Forms.Label pendientesLabel;
        private System.Windows.Forms.Label listosLabel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tomarPedidoButton;
        private System.Windows.Forms.FlowLayoutPanel pendientesPanel;
        private System.Windows.Forms.FlowLayoutPanel listosPanel;
    }
}