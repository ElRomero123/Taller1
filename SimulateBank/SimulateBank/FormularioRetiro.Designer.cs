namespace SimulateBank
{
    partial class FormularioRetiro
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
            this.BotonRetirar = new System.Windows.Forms.Button();
            this.Etiqueta1 = new System.Windows.Forms.Label();
            this.ListaCuentas = new System.Windows.Forms.ComboBox();
            this.Etiqueta2 = new System.Windows.Forms.Label();
            this.CampoCantidad = new System.Windows.Forms.TextBox();
            this.Grupo2 = new System.Windows.Forms.GroupBox();
            this.Grupo1 = new System.Windows.Forms.GroupBox();
            this.Grupo3 = new System.Windows.Forms.GroupBox();
            this.EtiquetaEstado = new System.Windows.Forms.Label();
            this.Grupo2.SuspendLayout();
            this.Grupo1.SuspendLayout();
            this.Grupo3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotonRetirar
            // 
            this.BotonRetirar.Location = new System.Drawing.Point(12, 220);
            this.BotonRetirar.Name = "BotonRetirar";
            this.BotonRetirar.Size = new System.Drawing.Size(92, 34);
            this.BotonRetirar.TabIndex = 21;
            this.BotonRetirar.Text = "Retirar";
            this.BotonRetirar.UseVisualStyleBackColor = true;
            // 
            // Etiqueta1
            // 
            this.Etiqueta1.AutoSize = true;
            this.Etiqueta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta1.Location = new System.Drawing.Point(12, 9);
            this.Etiqueta1.Name = "Etiqueta1";
            this.Etiqueta1.Size = new System.Drawing.Size(358, 24);
            this.Etiqueta1.TabIndex = 20;
            this.Etiqueta1.Text = "Apreciado cliente seleccione una cuenta.";
            // 
            // ListaCuentas
            // 
            this.ListaCuentas.FormattingEnabled = true;
            this.ListaCuentas.Location = new System.Drawing.Point(6, 38);
            this.ListaCuentas.Name = "ListaCuentas";
            this.ListaCuentas.Size = new System.Drawing.Size(260, 24);
            this.ListaCuentas.TabIndex = 19;
            // 
            // Etiqueta2
            // 
            this.Etiqueta2.AutoSize = true;
            this.Etiqueta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta2.Location = new System.Drawing.Point(388, 9);
            this.Etiqueta2.Name = "Etiqueta2";
            this.Etiqueta2.Size = new System.Drawing.Size(344, 24);
            this.Etiqueta2.TabIndex = 23;
            this.Etiqueta2.Text = "Introduzca la cantidad que desea retirar.";
            // 
            // CampoCantidad
            // 
            this.CampoCantidad.Location = new System.Drawing.Point(6, 38);
            this.CampoCantidad.Name = "CampoCantidad";
            this.CampoCantidad.Size = new System.Drawing.Size(255, 22);
            this.CampoCantidad.TabIndex = 24;
            // 
            // Grupo2
            // 
            this.Grupo2.Controls.Add(this.CampoCantidad);
            this.Grupo2.Location = new System.Drawing.Point(392, 47);
            this.Grupo2.Name = "Grupo2";
            this.Grupo2.Size = new System.Drawing.Size(338, 100);
            this.Grupo2.TabIndex = 23;
            this.Grupo2.TabStop = false;
            this.Grupo2.Text = "Cantidad ($)";
            // 
            // Grupo1
            // 
            this.Grupo1.Controls.Add(this.ListaCuentas);
            this.Grupo1.Location = new System.Drawing.Point(16, 47);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Size = new System.Drawing.Size(334, 100);
            this.Grupo1.TabIndex = 25;
            this.Grupo1.TabStop = false;
            this.Grupo1.Text = "Cuenta";
            // 
            // Grupo3
            // 
            this.Grupo3.Controls.Add(this.EtiquetaEstado);
            this.Grupo3.Location = new System.Drawing.Point(138, 179);
            this.Grupo3.Name = "Grupo3";
            this.Grupo3.Size = new System.Drawing.Size(592, 75);
            this.Grupo3.TabIndex = 25;
            this.Grupo3.TabStop = false;
            this.Grupo3.Text = "Estado del retiro";
            // 
            // EtiquetaEstado
            // 
            this.EtiquetaEstado.AutoSize = true;
            this.EtiquetaEstado.Location = new System.Drawing.Point(6, 36);
            this.EtiquetaEstado.Name = "EtiquetaEstado";
            this.EtiquetaEstado.Size = new System.Drawing.Size(20, 17);
            this.EtiquetaEstado.TabIndex = 0;
            this.EtiquetaEstado.Text = "...";
            // 
            // FormularioRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 285);
            this.Controls.Add(this.Grupo3);
            this.Controls.Add(this.Grupo1);
            this.Controls.Add(this.Grupo2);
            this.Controls.Add(this.Etiqueta2);
            this.Controls.Add(this.BotonRetirar);
            this.Controls.Add(this.Etiqueta1);
            this.Name = "FormularioRetiro";
            this.Text = "Retirar dinero";
            this.Grupo2.ResumeLayout(false);
            this.Grupo2.PerformLayout();
            this.Grupo1.ResumeLayout(false);
            this.Grupo3.ResumeLayout(false);
            this.Grupo3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
  
        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.Label Etiqueta2;
        private System.Windows.Forms.Label EtiquetaEstado;
        private System.Windows.Forms.GroupBox Grupo1;
        private System.Windows.Forms.GroupBox Grupo2;
        private System.Windows.Forms.GroupBox Grupo3;
        private System.Windows.Forms.ComboBox ListaCuentas;
        private System.Windows.Forms.TextBox CampoCantidad;
        private System.Windows.Forms.Button BotonRetirar;
    }
}