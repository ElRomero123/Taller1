namespace SimulateBank
{
    partial class FormularioMenuAdministrador
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
            this.Etiqueta1 = new System.Windows.Forms.Label();
            this.BotonGestionClientes = new System.Windows.Forms.Button();
            this.BotonDatosPersonales = new System.Windows.Forms.Button();
            this.BotonSalir = new System.Windows.Forms.Button();
            this.Grupo1 = new System.Windows.Forms.GroupBox();
            this.EtiquetaEmail = new System.Windows.Forms.Label();
            this.EtiquetaID = new System.Windows.Forms.Label();
            this.EtiquetaNombre = new System.Windows.Forms.Label();
            this.Grupo1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Etiqueta1
            // 
            this.Etiqueta1.AutoSize = true;
            this.Etiqueta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta1.Location = new System.Drawing.Point(12, 129);
            this.Etiqueta1.Name = "Etiqueta1";
            this.Etiqueta1.Size = new System.Drawing.Size(387, 24);
            this.Etiqueta1.TabIndex = 10;
            this.Etiqueta1.Text = "Señor administrador. Cual tarea va a realizar?";
            // 
            // BotonGestionClientes
            // 
            this.BotonGestionClientes.Location = new System.Drawing.Point(11, 175);
            this.BotonGestionClientes.Name = "BotonGestionClientes";
            this.BotonGestionClientes.Size = new System.Drawing.Size(189, 45);
            this.BotonGestionClientes.TabIndex = 7;
            this.BotonGestionClientes.Text = "Gestionar clientes.";
            this.BotonGestionClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonGestionClientes.UseVisualStyleBackColor = true;
            this.BotonGestionClientes.Click += new System.EventHandler(this.BotonGestionClientes_Click);
            // 
            // BotonDatosPersonales
            // 
            this.BotonDatosPersonales.Location = new System.Drawing.Point(206, 175);
            this.BotonDatosPersonales.Name = "BotonDatosPersonales";
            this.BotonDatosPersonales.Size = new System.Drawing.Size(189, 45);
            this.BotonDatosPersonales.TabIndex = 8;
            this.BotonDatosPersonales.Text = "Modificar datos personales.";
            this.BotonDatosPersonales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonDatosPersonales.UseVisualStyleBackColor = true;
            this.BotonDatosPersonales.Click += new System.EventHandler(this.BotonDatosPersonales_Click);
            // 
            // BotonSalir
            // 
            this.BotonSalir.Location = new System.Drawing.Point(402, 12);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(118, 45);
            this.BotonSalir.TabIndex = 6;
            this.BotonSalir.Text = "Cerrar sesión.";
            this.BotonSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonSalir.UseVisualStyleBackColor = true;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // Grupo1
            // 
            this.Grupo1.Controls.Add(this.EtiquetaEmail);
            this.Grupo1.Controls.Add(this.EtiquetaID);
            this.Grupo1.Controls.Add(this.EtiquetaNombre);
            this.Grupo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo1.Location = new System.Drawing.Point(11, 12);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Size = new System.Drawing.Size(384, 114);
            this.Grupo1.TabIndex = 11;
            this.Grupo1.TabStop = false;
            this.Grupo1.Text = "Información";
            // 
            // EtiquetaEmail
            // 
            this.EtiquetaEmail.AutoSize = true;
            this.EtiquetaEmail.Location = new System.Drawing.Point(6, 81);
            this.EtiquetaEmail.Name = "EtiquetaEmail";
            this.EtiquetaEmail.Size = new System.Drawing.Size(51, 17);
            this.EtiquetaEmail.TabIndex = 3;
            this.EtiquetaEmail.Text = "E-mail:";
            // 
            // EtiquetaID
            // 
            this.EtiquetaID.AutoSize = true;
            this.EtiquetaID.Location = new System.Drawing.Point(6, 55);
            this.EtiquetaID.Name = "EtiquetaID";
            this.EtiquetaID.Size = new System.Drawing.Size(25, 17);
            this.EtiquetaID.TabIndex = 2;
            this.EtiquetaID.Text = "ID:";
            // 
            // EtiquetaNombre
            // 
            this.EtiquetaNombre.AutoSize = true;
            this.EtiquetaNombre.Location = new System.Drawing.Point(6, 27);
            this.EtiquetaNombre.Name = "EtiquetaNombre";
            this.EtiquetaNombre.Size = new System.Drawing.Size(62, 17);
            this.EtiquetaNombre.TabIndex = 1;
            this.EtiquetaNombre.Text = "Nombre:";
            // 
            // FormularioMenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 232);
            this.Controls.Add(this.Grupo1);
            this.Controls.Add(this.Etiqueta1);
            this.Controls.Add(this.BotonGestionClientes);
            this.Controls.Add(this.BotonDatosPersonales);
            this.Controls.Add(this.BotonSalir);
            this.Name = "FormularioMenuAdministrador";
            this.Text = "Administrador";
            this.Grupo1.ResumeLayout(false);
            this.Grupo1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupo1;
        public System.Windows.Forms.Label EtiquetaEmail;
        public System.Windows.Forms.Label EtiquetaID;
        public System.Windows.Forms.Label EtiquetaNombre;
        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.Button BotonGestionClientes;
        private System.Windows.Forms.Button BotonDatosPersonales;
        private System.Windows.Forms.Button BotonSalir;
    }
}