namespace pryRodriguezStreamLeer
{
    partial class Stream
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGrabar = new System.Windows.Forms.TextBox();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGrabar
            // 
            this.txtGrabar.Location = new System.Drawing.Point(37, 51);
            this.txtGrabar.Name = "txtGrabar";
            this.txtGrabar.Size = new System.Drawing.Size(274, 22);
            this.txtGrabar.TabIndex = 0;
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(37, 134);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(274, 235);
            this.rtbTexto.TabIndex = 1;
            this.rtbTexto.Text = "";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(37, 453);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(274, 22);
            this.txtDato.TabIndex = 2;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(448, 51);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(116, 38);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(448, 134);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(116, 38);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(448, 445);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 38);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(448, 549);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 38);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Stream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 615);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.txtGrabar);
            this.Name = "Stream";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGrabar;
        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
    }
}

