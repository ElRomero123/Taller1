namespace SimulateBank
{
    partial class FormularioLogin
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
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.Etiqueta1 = new System.Windows.Forms.Label();
            this.CampoID = new System.Windows.Forms.TextBox();
            this.Etiqueta2 = new System.Windows.Forms.Label();
            this.Etiqueta3 = new System.Windows.Forms.Label();
            this.CampoPassword = new System.Windows.Forms.TextBox();
            this.Grupo1 = new System.Windows.Forms.GroupBox();
            this.EtiquetaEstado = new System.Windows.Forms.Label();
            this.Grupo1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(12, 147);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(85, 31);
            this.BotonAceptar.TabIndex = 0;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // Etiqueta1
            // 
            this.Etiqueta1.AutoSize = true;
            this.Etiqueta1.Location = new System.Drawing.Point(9, 9);
            this.Etiqueta1.Name = "Etiqueta1";
            this.Etiqueta1.Size = new System.Drawing.Size(234, 34);
            this.Etiqueta1.TabIndex = 1;
            this.Etiqueta1.Text = "Por favor iniciar sesión para utilizar \r\nlos servicios del banco.";
            // 
            // CampoID
            // 
            this.CampoID.Location = new System.Drawing.Point(103, 76);
            this.CampoID.Name = "CampoID";
            this.CampoID.Size = new System.Drawing.Size(100, 22);
            this.CampoID.TabIndex = 2;
            // 
            // Etiqueta2
            // 
            this.Etiqueta2.AutoSize = true;
            this.Etiqueta2.Location = new System.Drawing.Point(12, 79);
            this.Etiqueta2.Name = "Etiqueta2";
            this.Etiqueta2.Size = new System.Drawing.Size(25, 17);
            this.Etiqueta2.TabIndex = 3;
            this.Etiqueta2.Text = "ID:";
            // 
            // Etiqueta3
            // 
            this.Etiqueta3.AutoSize = true;
            this.Etiqueta3.Location = new System.Drawing.Point(12, 107);
            this.Etiqueta3.Name = "Etiqueta3";
            this.Etiqueta3.Size = new System.Drawing.Size(85, 17);
            this.Etiqueta3.TabIndex = 4;
            this.Etiqueta3.Text = "Contraseña:";
            // 
            // CampoPassword
            // 
            this.CampoPassword.Location = new System.Drawing.Point(103, 104);
            this.CampoPassword.Name = "CampoPassword";
            this.CampoPassword.Size = new System.Drawing.Size(100, 22);
            this.CampoPassword.TabIndex = 5;
            this.CampoPassword.UseSystemPasswordChar = true;
            // 
            // Grupo1
            // 
            this.Grupo1.Controls.Add(this.EtiquetaEstado);
            this.Grupo1.Location = new System.Drawing.Point(12, 190);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Size = new System.Drawing.Size(310, 66);
            this.Grupo1.TabIndex = 6;
            this.Grupo1.TabStop = false;
            this.Grupo1.Text = "Estado";
            // 
            // EtiquetaEstado
            // 
            this.EtiquetaEstado.AutoSize = true;
            this.EtiquetaEstado.Location = new System.Drawing.Point(6, 28);
            this.EtiquetaEstado.Name = "EtiquetaEstado";
            this.EtiquetaEstado.Size = new System.Drawing.Size(20, 17);
            this.EtiquetaEstado.TabIndex = 0;
            this.EtiquetaEstado.Text = "...";
            // 
            // FormularioLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 268);
            this.Controls.Add(this.Grupo1);
            this.Controls.Add(this.CampoPassword);
            this.Controls.Add(this.Etiqueta3);
            this.Controls.Add(this.Etiqueta2);
            this.Controls.Add(this.CampoID);
            this.Controls.Add(this.Etiqueta1);
            this.Controls.Add(this.BotonAceptar);
            this.Name = "FormularioLogin";
            this.Text = "Login";
            this.Grupo1.ResumeLayout(false);
            this.Grupo1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupo1;
        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.Label Etiqueta2;
        private System.Windows.Forms.Label Etiqueta3;
        private System.Windows.Forms.Label EtiquetaEstado;
        private System.Windows.Forms.TextBox CampoID;
        private System.Windows.Forms.TextBox CampoPassword;
        private System.Windows.Forms.Button BotonAceptar; 
    }
}

