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
            this.Grupo1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaCuentas
            // 
            this.ListaCuentas.FormattingEnabled = true;
            this.ListaCuentas.Location = new System.Drawing.Point(32, 47);
            this.ListaCuentas.Name = "ListaCuentas";
            this.ListaCuentas.Size = new System.Drawing.Size(121, 24);
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
            this.BotonCosultar.Location = new System.Drawing.Point(32, 113);
            this.BotonCosultar.Name = "BotonCosultar";
            this.BotonCosultar.Size = new System.Drawing.Size(92, 34);
            this.BotonCosultar.TabIndex = 17;
            this.BotonCosultar.Text = "Consultar";
            this.BotonCosultar.UseVisualStyleBackColor = true;
            // 
            // Grupo1
            // 
            this.Grupo1.Controls.Add(this.EtiquetaSaldo);
            this.Grupo1.Location = new System.Drawing.Point(176, 47);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Size = new System.Drawing.Size(200, 100);
            this.Grupo1.TabIndex = 18;
            this.Grupo1.TabStop = false;
            this.Grupo1.Text = "Saldo";
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
            // FormularioConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 181);
            this.Controls.Add(this.Grupo1);
            this.Controls.Add(this.BotonCosultar);
            this.Controls.Add(this.Etiqueta1);
            this.Controls.Add(this.ListaCuentas);
            this.Name = "FormularioConsulta";
            this.Text = "Consultar saldo";
            this.Grupo1.ResumeLayout(false);
            this.Grupo1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupo1;
        private System.Windows.Forms.Label EtiquetaSaldo;
        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.ComboBox ListaCuentas;
        private System.Windows.Forms.Button BotonCosultar;     
    }
}