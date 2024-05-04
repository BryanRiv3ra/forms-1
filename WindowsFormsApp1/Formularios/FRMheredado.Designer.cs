namespace WindowsFormsApp1.Formularios
{
    partial class FRMheredado
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
            this.Saludar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Saludar
            // 
            this.Saludar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saludar.Location = new System.Drawing.Point(80, 98);
            this.Saludar.Name = "Saludar";
            this.Saludar.Size = new System.Drawing.Size(89, 34);
            this.Saludar.TabIndex = 3;
            this.Saludar.Text = "Saludo";
            this.Saludar.UseVisualStyleBackColor = true;
            this.Saludar.Click += new System.EventHandler(this.Saludar_Click);
            // 
            // FRMheredado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.Saludar);
            this.Name = "FRMheredado";
            this.Controls.SetChildIndex(this.Saludar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Saludar;
    }
}
