namespace SimulateBank
{
    partial class FormularioGestionFinanciera
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
            this.CampoNumero = new System.Windows.Forms.TextBox();
            this.Grupo1 = new System.Windows.Forms.GroupBox();
            this.CampoSaldo = new System.Windows.Forms.TextBox();
            this.Etiqueta2 = new System.Windows.Forms.Label();
            this.Etiqueta1 = new System.Windows.Forms.Label();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.BotonActualizar = new System.Windows.Forms.Button();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.Grupo2 = new System.Windows.Forms.GroupBox();
            this.EtiquetaEstado = new System.Windows.Forms.Label();
            this.EtiquetaID = new System.Windows.Forms.Label();
            this.Grupo3 = new System.Windows.Forms.GroupBox();
            this.Grupo1.SuspendLayout();
            this.Grupo2.SuspendLayout();
            this.Grupo3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CampoNumero
            // 
            this.CampoNumero.Location = new System.Drawing.Point(121, 30);
            this.CampoNumero.Name = "CampoNumero";
            this.CampoNumero.Size = new System.Drawing.Size(164, 22);
            this.CampoNumero.TabIndex = 0;
            // 
            // Grupo1
            // 
            this.Grupo1.Controls.Add(this.CampoSaldo);
            this.Grupo1.Controls.Add(this.Etiqueta2);
            this.Grupo1.Controls.Add(this.Etiqueta1);
            this.Grupo1.Controls.Add(this.CampoNumero);
            this.Grupo1.Location = new System.Drawing.Point(12, 12);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Size = new System.Drawing.Size(374, 113);
            this.Grupo1.TabIndex = 1;
            this.Grupo1.TabStop = false;
            this.Grupo1.Text = "Gestión de una cuenta";
            // 
            // CampoSaldo
            // 
            this.CampoSaldo.Location = new System.Drawing.Point(121, 62);
            this.CampoSaldo.Name = "CampoSaldo";
            this.CampoSaldo.Size = new System.Drawing.Size(164, 22);
            this.CampoSaldo.TabIndex = 4;
            // 
            // Etiqueta2
            // 
            this.Etiqueta2.AutoSize = true;
            this.Etiqueta2.Location = new System.Drawing.Point(6, 65);
            this.Etiqueta2.Name = "Etiqueta2";
            this.Etiqueta2.Size = new System.Drawing.Size(70, 17);
            this.Etiqueta2.TabIndex = 3;
            this.Etiqueta2.Text = "Saldo ($):";
            // 
            // Etiqueta1
            // 
            this.Etiqueta1.AutoSize = true;
            this.Etiqueta1.Location = new System.Drawing.Point(6, 33);
            this.Etiqueta1.Name = "Etiqueta1";
            this.Etiqueta1.Size = new System.Drawing.Size(109, 17);
            this.Etiqueta1.TabIndex = 2;
            this.Etiqueta1.Text = "Número cuenta:";
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Location = new System.Drawing.Point(12, 131);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(89, 35);
            this.BotonAgregar.TabIndex = 2;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.UseVisualStyleBackColor = true;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(107, 131);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(89, 35);
            this.BotonBuscar.TabIndex = 3;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // BotonActualizar
            // 
            this.BotonActualizar.Location = new System.Drawing.Point(202, 131);
            this.BotonActualizar.Name = "BotonActualizar";
            this.BotonActualizar.Size = new System.Drawing.Size(89, 35);
            this.BotonActualizar.TabIndex = 4;
            this.BotonActualizar.Text = "Actualizar";
            this.BotonActualizar.UseVisualStyleBackColor = true;
            this.BotonActualizar.Click += new System.EventHandler(this.BotonActualizar_Click);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(297, 131);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(89, 35);
            this.BotonEliminar.TabIndex = 5;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // Grupo2
            // 
            this.Grupo2.Controls.Add(this.EtiquetaEstado);
            this.Grupo2.Location = new System.Drawing.Point(12, 172);
            this.Grupo2.Name = "Grupo2";
            this.Grupo2.Size = new System.Drawing.Size(279, 64);
            this.Grupo2.TabIndex = 6;
            this.Grupo2.TabStop = false;
            this.Grupo2.Text = "Estado del proceso";
            // 
            // EtiquetaEstado
            // 
            this.EtiquetaEstado.AutoSize = true;
            this.EtiquetaEstado.Location = new System.Drawing.Point(6, 31);
            this.EtiquetaEstado.Name = "EtiquetaEstado";
            this.EtiquetaEstado.Size = new System.Drawing.Size(20, 17);
            this.EtiquetaEstado.TabIndex = 5;
            this.EtiquetaEstado.Text = "...";
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
            // Grupo3
            // 
            this.Grupo3.Controls.Add(this.EtiquetaID);
            this.Grupo3.Location = new System.Drawing.Point(297, 172);
            this.Grupo3.Name = "Grupo3";
            this.Grupo3.Size = new System.Drawing.Size(233, 64);
            this.Grupo3.TabIndex = 8;
            this.Grupo3.TabStop = false;
            this.Grupo3.Text = "ID del cliente";
            // 
            // FormularioGestionFinanciera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 248);
            this.Controls.Add(this.Grupo3);
            this.Controls.Add(this.Grupo2);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.BotonActualizar);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.Grupo1);
            this.Name = "FormularioGestionFinanciera";
            this.Text = "Gestión financiera";
            this.Grupo1.ResumeLayout(false);
            this.Grupo1.PerformLayout();
            this.Grupo2.ResumeLayout(false);
            this.Grupo2.PerformLayout();
            this.Grupo3.ResumeLayout(false);
            this.Grupo3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CampoNumero;
        private System.Windows.Forms.GroupBox Grupo1;
        private System.Windows.Forms.TextBox CampoSaldo;
        private System.Windows.Forms.Label Etiqueta2;
        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.Button BotonActualizar;
        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.GroupBox Grupo2;
        private System.Windows.Forms.Label EtiquetaEstado;
        public System.Windows.Forms.Label EtiquetaID;
        private System.Windows.Forms.GroupBox Grupo3;
    }
}