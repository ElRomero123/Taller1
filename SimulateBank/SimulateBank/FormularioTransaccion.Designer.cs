namespace SimulateBank
{
    partial class FormularioTransaccion
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
            this.ListaCuentaOrigen = new System.Windows.Forms.ComboBox();
            this.Grupo1 = new System.Windows.Forms.GroupBox();
            this.Grupo1A = new System.Windows.Forms.GroupBox();
            this.Etiqueta3 = new System.Windows.Forms.Label();
            this.Etiqueta2 = new System.Windows.Forms.Label();
            this.Etiqueta1 = new System.Windows.Forms.Label();
            this.CampoCantidad = new System.Windows.Forms.TextBox();
            this.Grupo2 = new System.Windows.Forms.GroupBox();
            this.CampoCuentaDestino = new System.Windows.Forms.TextBox();
            this.Grupo2A = new System.Windows.Forms.GroupBox();
            this.Etiqueta6 = new System.Windows.Forms.Label();
            this.Etiqueta5 = new System.Windows.Forms.Label();
            this.Etiqueta4 = new System.Windows.Forms.Label();
            this.Grupo3 = new System.Windows.Forms.GroupBox();
            this.EtiquetaEstado = new System.Windows.Forms.Label();
            this.BotonTransferir = new System.Windows.Forms.Button();
            this.Grupo4 = new System.Windows.Forms.GroupBox();
            this.EtiquetaID = new System.Windows.Forms.Label();
            this.BotonCargar = new System.Windows.Forms.Button();
            this.Grupo1.SuspendLayout();
            this.Grupo1A.SuspendLayout();
            this.Grupo2.SuspendLayout();
            this.Grupo2A.SuspendLayout();
            this.Grupo3.SuspendLayout();
            this.Grupo4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaCuentaOrigen
            // 
            this.ListaCuentaOrigen.FormattingEnabled = true;
            this.ListaCuentaOrigen.Location = new System.Drawing.Point(210, 42);
            this.ListaCuentaOrigen.Name = "ListaCuentaOrigen";
            this.ListaCuentaOrigen.Size = new System.Drawing.Size(188, 24);
            this.ListaCuentaOrigen.TabIndex = 0;
            // 
            // Grupo1
            // 
            this.Grupo1.Controls.Add(this.Grupo1A);
            this.Grupo1.Controls.Add(this.Etiqueta2);
            this.Grupo1.Controls.Add(this.Etiqueta1);
            this.Grupo1.Controls.Add(this.CampoCantidad);
            this.Grupo1.Controls.Add(this.ListaCuentaOrigen);
            this.Grupo1.Location = new System.Drawing.Point(12, 12);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Size = new System.Drawing.Size(463, 228);
            this.Grupo1.TabIndex = 1;
            this.Grupo1.TabStop = false;
            this.Grupo1.Text = "Cuenta origen";
            // 
            // Grupo1A
            // 
            this.Grupo1A.Controls.Add(this.Etiqueta3);
            this.Grupo1A.Location = new System.Drawing.Point(25, 123);
            this.Grupo1A.Name = "Grupo1A";
            this.Grupo1A.Size = new System.Drawing.Size(368, 92);
            this.Grupo1A.TabIndex = 5;
            this.Grupo1A.TabStop = false;
            this.Grupo1A.Text = "Estado";
            // 
            // Etiqueta3
            // 
            this.Etiqueta3.AutoSize = true;
            this.Etiqueta3.Location = new System.Drawing.Point(23, 30);
            this.Etiqueta3.Name = "Etiqueta3";
            this.Etiqueta3.Size = new System.Drawing.Size(48, 17);
            this.Etiqueta3.TabIndex = 3;
            this.Etiqueta3.Text = "Saldo:";
            // 
            // Etiqueta2
            // 
            this.Etiqueta2.AutoSize = true;
            this.Etiqueta2.Location = new System.Drawing.Point(22, 75);
            this.Etiqueta2.Name = "Etiqueta2";
            this.Etiqueta2.Size = new System.Drawing.Size(168, 17);
            this.Etiqueta2.TabIndex = 4;
            this.Etiqueta2.Text = "Cantidad a consignar ($):";
            // 
            // Etiqueta1
            // 
            this.Etiqueta1.AutoSize = true;
            this.Etiqueta1.Location = new System.Drawing.Point(22, 45);
            this.Etiqueta1.Name = "Etiqueta1";
            this.Etiqueta1.Size = new System.Drawing.Size(182, 17);
            this.Etiqueta1.TabIndex = 3;
            this.Etiqueta1.Text = "Seleccionar Cuenta Origen:";
            // 
            // CampoCantidad
            // 
            this.CampoCantidad.Location = new System.Drawing.Point(210, 72);
            this.CampoCantidad.Name = "CampoCantidad";
            this.CampoCantidad.Size = new System.Drawing.Size(188, 22);
            this.CampoCantidad.TabIndex = 1;
            // 
            // Grupo2
            // 
            this.Grupo2.Controls.Add(this.CampoCuentaDestino);
            this.Grupo2.Controls.Add(this.Grupo2A);
            this.Grupo2.Controls.Add(this.Etiqueta4);
            this.Grupo2.Location = new System.Drawing.Point(495, 12);
            this.Grupo2.Name = "Grupo2";
            this.Grupo2.Size = new System.Drawing.Size(419, 228);
            this.Grupo2.TabIndex = 2;
            this.Grupo2.TabStop = false;
            this.Grupo2.Text = "Cuenta destino";
            // 
            // CampoCuentaDestino
            // 
            this.CampoCuentaDestino.Location = new System.Drawing.Point(152, 42);
            this.CampoCuentaDestino.Name = "CampoCuentaDestino";
            this.CampoCuentaDestino.Size = new System.Drawing.Size(188, 22);
            this.CampoCuentaDestino.TabIndex = 6;
            // 
            // Grupo2A
            // 
            this.Grupo2A.Controls.Add(this.Etiqueta6);
            this.Grupo2A.Controls.Add(this.Etiqueta5);
            this.Grupo2A.Location = new System.Drawing.Point(20, 123);
            this.Grupo2A.Name = "Grupo2A";
            this.Grupo2A.Size = new System.Drawing.Size(368, 92);
            this.Grupo2A.TabIndex = 6;
            this.Grupo2A.TabStop = false;
            this.Grupo2A.Text = "Propietario";
            // 
            // Etiqueta6
            // 
            this.Etiqueta6.AutoSize = true;
            this.Etiqueta6.Location = new System.Drawing.Point(23, 57);
            this.Etiqueta6.Name = "Etiqueta6";
            this.Etiqueta6.Size = new System.Drawing.Size(51, 17);
            this.Etiqueta6.TabIndex = 4;
            this.Etiqueta6.Text = "E-mail:";
            // 
            // Etiqueta5
            // 
            this.Etiqueta5.AutoSize = true;
            this.Etiqueta5.Location = new System.Drawing.Point(23, 30);
            this.Etiqueta5.Name = "Etiqueta5";
            this.Etiqueta5.Size = new System.Drawing.Size(62, 17);
            this.Etiqueta5.TabIndex = 3;
            this.Etiqueta5.Text = "Nombre:";
            // 
            // Etiqueta4
            // 
            this.Etiqueta4.AutoSize = true;
            this.Etiqueta4.Location = new System.Drawing.Point(17, 45);
            this.Etiqueta4.Name = "Etiqueta4";
            this.Etiqueta4.Size = new System.Drawing.Size(129, 17);
            this.Etiqueta4.TabIndex = 5;
            this.Etiqueta4.Text = "N° Cuenta Destino:";
            // 
            // Grupo3
            // 
            this.Grupo3.Controls.Add(this.EtiquetaEstado);
            this.Grupo3.Location = new System.Drawing.Point(12, 246);
            this.Grupo3.Name = "Grupo3";
            this.Grupo3.Size = new System.Drawing.Size(784, 68);
            this.Grupo3.TabIndex = 5;
            this.Grupo3.TabStop = false;
            this.Grupo3.Text = "Estado de la transacción";
            // 
            // EtiquetaEstado
            // 
            this.EtiquetaEstado.AutoSize = true;
            this.EtiquetaEstado.Location = new System.Drawing.Point(22, 33);
            this.EtiquetaEstado.Name = "EtiquetaEstado";
            this.EtiquetaEstado.Size = new System.Drawing.Size(16, 17);
            this.EtiquetaEstado.TabIndex = 3;
            this.EtiquetaEstado.Text = "..";
            // 
            // BotonTransferir
            // 
            this.BotonTransferir.Location = new System.Drawing.Point(802, 264);
            this.BotonTransferir.Name = "BotonTransferir";
            this.BotonTransferir.Size = new System.Drawing.Size(112, 47);
            this.BotonTransferir.TabIndex = 6;
            this.BotonTransferir.Text = "Transferir";
            this.BotonTransferir.UseVisualStyleBackColor = true;
            this.BotonTransferir.Click += new System.EventHandler(this.BotonTransferir_Click);
            // 
            // Grupo4
            // 
            this.Grupo4.Controls.Add(this.EtiquetaID);
            this.Grupo4.Location = new System.Drawing.Point(12, 337);
            this.Grupo4.Name = "Grupo4";
            this.Grupo4.Size = new System.Drawing.Size(233, 64);
            this.Grupo4.TabIndex = 9;
            this.Grupo4.TabStop = false;
            this.Grupo4.Text = "ID del cliente";
            // 
            // EtiquetaID
            // 
            this.EtiquetaID.AutoSize = true;
            this.EtiquetaID.Location = new System.Drawing.Point(15, 31);
            this.EtiquetaID.Name = "EtiquetaID";
            this.EtiquetaID.Size = new System.Drawing.Size(20, 17);
            this.EtiquetaID.TabIndex = 7;
            this.EtiquetaID.Text = "...";
            // 
            // BotonCargar
            // 
            this.BotonCargar.Location = new System.Drawing.Point(251, 360);
            this.BotonCargar.Name = "BotonCargar";
            this.BotonCargar.Size = new System.Drawing.Size(197, 32);
            this.BotonCargar.TabIndex = 10;
            this.BotonCargar.Text = "Cargar cuentas";
            this.BotonCargar.UseVisualStyleBackColor = true;
            this.BotonCargar.Click += new System.EventHandler(this.BotonCargar_Click);
            // 
            // FormularioTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 413);
            this.Controls.Add(this.BotonCargar);
            this.Controls.Add(this.Grupo4);
            this.Controls.Add(this.BotonTransferir);
            this.Controls.Add(this.Grupo3);
            this.Controls.Add(this.Grupo2);
            this.Controls.Add(this.Grupo1);
            this.Name = "FormularioTransaccion";
            this.Text = "Transacciones";
            this.Grupo1.ResumeLayout(false);
            this.Grupo1.PerformLayout();
            this.Grupo1A.ResumeLayout(false);
            this.Grupo1A.PerformLayout();
            this.Grupo2.ResumeLayout(false);
            this.Grupo2.PerformLayout();
            this.Grupo2A.ResumeLayout(false);
            this.Grupo2A.PerformLayout();
            this.Grupo3.ResumeLayout(false);
            this.Grupo3.PerformLayout();
            this.Grupo4.ResumeLayout(false);
            this.Grupo4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ListaCuentaOrigen;
        private System.Windows.Forms.GroupBox Grupo1;
        private System.Windows.Forms.GroupBox Grupo1A;
        private System.Windows.Forms.GroupBox Grupo2;
        private System.Windows.Forms.GroupBox Grupo2A;
        private System.Windows.Forms.GroupBox Grupo3;
        private System.Windows.Forms.GroupBox Grupo4;
        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.Label Etiqueta2;
        private System.Windows.Forms.Label Etiqueta3;
        private System.Windows.Forms.Label Etiqueta4;
        private System.Windows.Forms.Label Etiqueta5;
        private System.Windows.Forms.Label Etiqueta6;
        private System.Windows.Forms.Label EtiquetaEstado;
        public  System.Windows.Forms.Label EtiquetaID;
        private System.Windows.Forms.TextBox CampoCantidad;
        private System.Windows.Forms.TextBox CampoCuentaDestino;
        private System.Windows.Forms.Button BotonTransferir;
        private System.Windows.Forms.Button BotonCargar;
    }
}