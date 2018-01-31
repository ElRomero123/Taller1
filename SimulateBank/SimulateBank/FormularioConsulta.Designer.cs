namespace SimulateBank
{
    partial class FormularioConsulta
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
            this.ListaCuentas = new System.Windows.Forms.ComboBox();
            this.Etiqueta1 = new System.Windows.Forms.Label();
            this.BotonCosultar = new System.Windows.Forms.Button();
            this.Grupo1 = new System.Windows.Forms.GroupBox();
            this.EtiquetaSaldo = new System.Windows.Forms.Label();
            this.BotonCargar = new System.Windows.Forms.Button();
            this.Grupo2 = new System.Windows.Forms.GroupBox();
            this.EtiquetaID = new System.Windows.Forms.Label();
            this.Grupo1.SuspendLayout();
            this.Grupo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaCuentas
            // 
            this.ListaCuentas.FormattingEnabled = true;
            this.ListaCuentas.Location = new System.Drawing.Point(296, 36);
            this.ListaCuentas.Name = "ListaCuentas";
            this.ListaCuentas.Size = new System.Drawing.Size(189, 24);
            this.ListaCuentas.TabIndex = 0;
            // 
            // Etiqueta1
            // 
            this.Etiqueta1.AutoSize = true;
            this.Etiqueta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta1.Location = new System.Drawing.Point(28, 9);
            this.Etiqueta1.Name = "Etiqueta1";
            this.Etiqueta1.Size = new System.Drawing.Size(358, 24);
            this.Etiqueta1.TabIndex = 16;
            this.Etiqueta1.Text = "Apreciado cliente seleccione una cuenta.";
            // 
            // BotonCosultar
            // 
            this.BotonCosultar.Location = new System.Drawing.Point(296, 136);
            this.BotonCosultar.Name = "BotonCosultar";
            this.BotonCosultar.Size = new System.Drawing.Size(125, 34);
            this.BotonCosultar.TabIndex = 17;
            this.BotonCosultar.Text = "Consultar";
            this.BotonCosultar.UseVisualStyleBackColor = true;
            this.BotonCosultar.Click += new System.EventHandler(this.BotonCosultar_Click);
            // 
            // Grupo1
            // 
            this.Grupo1.Controls.Add(this.EtiquetaSaldo);
            this.Grupo1.Location = new System.Drawing.Point(12, 36);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Size = new System.Drawing.Size(278, 99);
            this.Grupo1.TabIndex = 18;
            this.Grupo1.TabStop = false;
            this.Grupo1.Text = "Saldo($)";
            // 
            // EtiquetaSaldo
            // 
            this.EtiquetaSaldo.AutoSize = true;
            this.EtiquetaSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaSaldo.Location = new System.Drawing.Point(25, 50);
            this.EtiquetaSaldo.Name = "EtiquetaSaldo";
            this.EtiquetaSaldo.Size = new System.Drawing.Size(25, 24);
            this.EtiquetaSaldo.TabIndex = 19;
            this.EtiquetaSaldo.Text = "...";
            // 
            // BotonCargar
            // 
            this.BotonCargar.Location = new System.Drawing.Point(296, 176);
            this.BotonCargar.Name = "BotonCargar";
            this.BotonCargar.Size = new System.Drawing.Size(125, 34);
            this.BotonCargar.TabIndex = 19;
            this.BotonCargar.Text = "Cargar cuentas";
            this.BotonCargar.UseVisualStyleBackColor = true;
            this.BotonCargar.Click += new System.EventHandler(this.BotonCargar_Click);
            // 
            // Grupo2
            // 
            this.Grupo2.Controls.Add(this.EtiquetaID);
            this.Grupo2.Location = new System.Drawing.Point(12, 145);
            this.Grupo2.Name = "Grupo2";
            this.Grupo2.Size = new System.Drawing.Size(278, 64);
            this.Grupo2.TabIndex = 20;
            this.Grupo2.TabStop = false;
            this.Grupo2.Text = "ID del cliente";
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
            // FormularioConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 221);
            this.Controls.Add(this.Grupo2);
            this.Controls.Add(this.BotonCargar);
            this.Controls.Add(this.Grupo1);
            this.Controls.Add(this.BotonCosultar);
            this.Controls.Add(this.Etiqueta1);
            this.Controls.Add(this.ListaCuentas);
            this.Name = "FormularioConsulta";
            this.Text = "Consultar saldo";
            this.Grupo1.ResumeLayout(false);
            this.Grupo1.PerformLayout();
            this.Grupo2.ResumeLayout(false);
            this.Grupo2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupo1;
        private System.Windows.Forms.Label EtiquetaSaldo;
        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.ComboBox ListaCuentas;
        private System.Windows.Forms.Button BotonCosultar;
        private System.Windows.Forms.Button BotonCargar;
        private System.Windows.Forms.GroupBox Grupo2;
        public System.Windows.Forms.Label EtiquetaID;
    }
}