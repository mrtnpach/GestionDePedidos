
namespace Pav2022.P2.Presentacion.Controles
{
    partial class InfoPedidoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numeroLabel = new System.Windows.Forms.Label();
            this.montoLabel = new System.Windows.Forms.Label();
            this.tiempoLabel = new System.Windows.Forms.Label();
            this.entregadoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeroLabel
            // 
            this.numeroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numeroLabel.ForeColor = System.Drawing.Color.White;
            this.numeroLabel.Location = new System.Drawing.Point(13, 11);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(101, 28);
            this.numeroLabel.TabIndex = 0;
            this.numeroLabel.Text = "[Numero]";
            // 
            // montoLabel
            // 
            this.montoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.montoLabel.AutoSize = true;
            this.montoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.montoLabel.ForeColor = System.Drawing.Color.White;
            this.montoLabel.Location = new System.Drawing.Point(56, 52);
            this.montoLabel.Name = "montoLabel";
            this.montoLabel.Size = new System.Drawing.Size(84, 28);
            this.montoLabel.TabIndex = 1;
            this.montoLabel.Text = "[Monto]";
            // 
            // tiempoLabel
            // 
            this.tiempoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tiempoLabel.AutoSize = true;
            this.tiempoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tiempoLabel.ForeColor = System.Drawing.Color.White;
            this.tiempoLabel.Location = new System.Drawing.Point(56, 90);
            this.tiempoLabel.Name = "tiempoLabel";
            this.tiempoLabel.Size = new System.Drawing.Size(90, 28);
            this.tiempoLabel.TabIndex = 2;
            this.tiempoLabel.Text = "[Tiempo]";
            // 
            // entregadoButton
            // 
            this.entregadoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.entregadoButton.BackColor = System.Drawing.Color.Coral;
            this.entregadoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.entregadoButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entregadoButton.ForeColor = System.Drawing.Color.White;
            this.entregadoButton.Location = new System.Drawing.Point(533, 104);
            this.entregadoButton.Name = "entregadoButton";
            this.entregadoButton.Size = new System.Drawing.Size(113, 35);
            this.entregadoButton.TabIndex = 3;
            this.entregadoButton.Text = "Entregado";
            this.entregadoButton.UseVisualStyleBackColor = false;
            this.entregadoButton.Click += new System.EventHandler(this.entregadoButton_Click);
            // 
            // InfoPedidoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.entregadoButton);
            this.Controls.Add(this.tiempoLabel);
            this.Controls.Add(this.montoLabel);
            this.Controls.Add(this.numeroLabel);
            this.Name = "InfoPedidoControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(659, 152);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.Label montoLabel;
        private System.Windows.Forms.Label tiempoLabel;
        private System.Windows.Forms.Button entregadoButton;
    }
}
