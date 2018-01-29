namespace SimulateBank
{
    partial class FormularioMenuCliente
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
            this.Grupo1 = new System.Windows.Forms.GroupBox();
            this.EtiquetaID = new System.Windows.Forms.Label();
            this.EtiquetaNombre = new System.Windows.Forms.Label();
            this.BotonTransaccion = new System.Windows.Forms.Button();
            this.BotonRetiro = new System.Windows.Forms.Button();
            this.BotonConsulta = new System.Windows.Forms.Button();
            this.Etiqueta1 = new System.Windows.Forms.Label();
            this.BotonSalir = new System.Windows.Forms.Button();
            this.BotonDatosPersonales = new System.Windows.Forms.Button();
            this.Grupo1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grupo1
            // 
            this.Grupo1.Controls.Add(this.EtiquetaID);
            this.Grupo1.Controls.Add(this.EtiquetaNombre);
            this.Grupo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo1.Location = new System.Drawing.Point(12, 12);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Size = new System.Drawing.Size(384, 92);
            this.Grupo1.TabIndex = 0;
            this.Grupo1.TabStop = false;
            this.Grupo1.Text = "Información";
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
            // BotonTransaccion
            // 
            this.BotonTransaccion.Location = new System.Drawing.Point(12, 156);
            this.BotonTransaccion.Name = "BotonTransaccion";
            this.BotonTransaccion.Size = new System.Drawing.Size(189, 45);
            this.BotonTransaccion.TabIndex = 1;
            this.BotonTransaccion.Text = "Transacción.";
            this.BotonTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonTransaccion.UseVisualStyleBackColor = true;
            this.BotonTransaccion.Click += new System.EventHandler(this.BotonTransaccion_Click);
            // 
            // BotonRetiro
            // 
            this.BotonRetiro.Location = new System.Drawing.Point(207, 156);
            this.BotonRetiro.Name = "BotonRetiro";
            this.BotonRetiro.Size = new System.Drawing.Size(189, 45);
            this.BotonRetiro.TabIndex = 2;
            this.BotonRetiro.Text = "Retirar dinero.";
            this.BotonRetiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonRetiro.UseVisualStyleBackColor = true;
            this.BotonRetiro.Click += new System.EventHandler(this.BotonRetiro_Click);
            // 
            // BotonConsulta
            // 
            this.BotonConsulta.Location = new System.Drawing.Point(402, 156);
            this.BotonConsulta.Name = "BotonConsulta";
            this.BotonConsulta.Size = new System.Drawing.Size(189, 45);
            this.BotonConsulta.TabIndex = 3;
            this.BotonConsulta.Text = "Consultar saldo.";
            this.BotonConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonConsulta.UseVisualStyleBackColor = true;
            this.BotonConsulta.Click += new System.EventHandler(this.BotonConsulta_Click);
            // 
            // Etiqueta1
            // 
            this.Etiqueta1.AutoSize = true;
            this.Etiqueta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta1.Location = new System.Drawing.Point(9, 123);
            this.Etiqueta1.Name = "Etiqueta1";
            this.Etiqueta1.Size = new System.Drawing.Size(329, 24);
            this.Etiqueta1.TabIndex = 4;
            this.Etiqueta1.Text = "Apreciado cliente ¿Que desea hacer?";
            // 
            // BotonSalir
            // 
            this.BotonSalir.Location = new System.Drawing.Point(474, 12);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(118, 45);
            this.BotonSalir.TabIndex = 5;
            this.BotonSalir.Text = "Cerrar sesión.";
            this.BotonSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonSalir.UseVisualStyleBackColor = true;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // BotonDatosPersonales
            // 
            this.BotonDatosPersonales.Location = new System.Drawing.Point(12, 215);
            this.BotonDatosPersonales.Name = "BotonDatosPersonales";
            this.BotonDatosPersonales.Size = new System.Drawing.Size(189, 45);
            this.BotonDatosPersonales.TabIndex = 6;
            this.BotonDatosPersonales.Text = "Modificar datos personales.";
            this.BotonDatosPersonales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonDatosPersonales.UseVisualStyleBackColor = true;
            this.BotonDatosPersonales.Click += new System.EventHandler(this.BotonDatosPersonales_Click);
            // 
            // FormularioMenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 272);
            this.Controls.Add(this.BotonDatosPersonales);
            this.Controls.Add(this.BotonSalir);
            this.Controls.Add(this.Etiqueta1);
            this.Controls.Add(this.BotonConsulta);
            this.Controls.Add(this.BotonRetiro);
            this.Controls.Add(this.BotonTransaccion);
            this.Controls.Add(this.Grupo1);
            this.Name = "FormularioMenuCliente";
            this.Text = "Cliente";
            this.Grupo1.ResumeLayout(false);
            this.Grupo1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupo1;
        private System.Windows.Forms.Label EtiquetaID;
        private System.Windows.Forms.Label EtiquetaNombre;
        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.Button BotonTransaccion;
        private System.Windows.Forms.Button BotonRetiro;
        private System.Windows.Forms.Button BotonConsulta;
        private System.Windows.Forms.Button BotonSalir;
        private System.Windows.Forms.Button BotonDatosPersonales;
    }
}