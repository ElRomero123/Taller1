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
            this.Etiqueta1 = new System.Windows.Forms.Label();
            this.Etiqueta2 = new System.Windows.Forms.Label();
            this.CampoSaldo = new System.Windows.Forms.TextBox();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.BotonActualizar = new System.Windows.Forms.Button();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.Grupo1.SuspendLayout();
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
            // Etiqueta1
            // 
            this.Etiqueta1.AutoSize = true;
            this.Etiqueta1.Location = new System.Drawing.Point(6, 33);
            this.Etiqueta1.Name = "Etiqueta1";
            this.Etiqueta1.Size = new System.Drawing.Size(109, 17);
            this.Etiqueta1.TabIndex = 2;
            this.Etiqueta1.Text = "Número cuenta:";
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
            // CampoSaldo
            // 
            this.CampoSaldo.Location = new System.Drawing.Point(121, 62);
            this.CampoSaldo.Name = "CampoSaldo";
            this.CampoSaldo.Size = new System.Drawing.Size(164, 22);
            this.CampoSaldo.TabIndex = 4;
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Location = new System.Drawing.Point(12, 131);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(89, 35);
            this.BotonAgregar.TabIndex = 2;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.UseVisualStyleBackColor = true;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(107, 131);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(89, 35);
            this.BotonBuscar.TabIndex = 3;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            // 
            // BotonActualizar
            // 
            this.BotonActualizar.Location = new System.Drawing.Point(202, 131);
            this.BotonActualizar.Name = "BotonActualizar";
            this.BotonActualizar.Size = new System.Drawing.Size(89, 35);
            this.BotonActualizar.TabIndex = 4;
            this.BotonActualizar.Text = "Actualizar";
            this.BotonActualizar.UseVisualStyleBackColor = true;
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(297, 131);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(89, 35);
            this.BotonEliminar.TabIndex = 5;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            // 
            // FormularioGestionFinanciera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 179);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.BotonActualizar);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.Grupo1);
            this.Name = "FormularioGestionFinanciera";
            this.Text = "Gestión financiera";
            this.Grupo1.ResumeLayout(false);
            this.Grupo1.PerformLayout();
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
    }
}