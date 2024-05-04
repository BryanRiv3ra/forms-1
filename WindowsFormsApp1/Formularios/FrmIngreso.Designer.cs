namespace WindowsFormsApp1.Formularios
{
    partial class FrmIngreso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sumar = new System.Windows.Forms.Button();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.comboBoxFacultades = new System.Windows.Forms.ComboBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el num2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // sumar
            // 
            this.sumar.Location = new System.Drawing.Point(27, 154);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(75, 23);
            this.sumar.TabIndex = 3;
            this.sumar.Text = "Sumar";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // numero1
            // 
            this.numero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero1.Location = new System.Drawing.Point(124, 4);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(100, 35);
            this.numero1.TabIndex = 4;
            // 
            // numero2
            // 
            this.numero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero2.Location = new System.Drawing.Point(124, 49);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(100, 35);
            this.numero2.TabIndex = 5;
            // 
            // comboBoxFacultades
            // 
            this.comboBoxFacultades.FormattingEnabled = true;
            this.comboBoxFacultades.Location = new System.Drawing.Point(171, 156);
            this.comboBoxFacultades.Name = "comboBoxFacultades";
            this.comboBoxFacultades.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFacultades.TabIndex = 7;
            this.comboBoxFacultades.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacultades_SelectedIndexChanged);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(139, 103);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(0, 29);
            this.Resultado.TabIndex = 8;
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.comboBoxFacultades);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmIngreso";
            this.Text = "FrmIngreso";
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.ComboBox comboBoxFacultades;
        private System.Windows.Forms.Label Resultado;
    }
}