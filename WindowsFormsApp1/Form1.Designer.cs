namespace WindowsFormsApp1
{
    partial class Myapp
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonIngreso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPWD = new System.Windows.Forms.TextBox();
            this.textBoxUSR = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(35, 30);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(0, 35);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Padre:Form1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.images__1_;
            this.pictureBox1.Location = new System.Drawing.Point(478, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 169);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // buttonIngreso
            // 
            this.buttonIngreso.Image = global::WindowsFormsApp1.Properties.Resources.descargar__4_;
            this.buttonIngreso.Location = new System.Drawing.Point(12, 181);
            this.buttonIngreso.Name = "buttonIngreso";
            this.buttonIngreso.Size = new System.Drawing.Size(214, 173);
            this.buttonIngreso.TabIndex = 3;
            this.buttonIngreso.Text = "button ingreso";
            this.buttonIngreso.UseVisualStyleBackColor = true;
            this.buttonIngreso.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // textBoxPWD
            // 
            this.textBoxPWD.Location = new System.Drawing.Point(342, 12);
            this.textBoxPWD.Name = "textBoxPWD";
            this.textBoxPWD.Size = new System.Drawing.Size(100, 20);
            this.textBoxPWD.TabIndex = 6;
            // 
            // textBoxUSR
            // 
            this.textBoxUSR.Location = new System.Drawing.Point(342, 49);
            this.textBoxUSR.Name = "textBoxUSR";
            this.textBoxUSR.PasswordChar = '*';
            this.textBoxUSR.Size = new System.Drawing.Size(100, 20);
            this.textBoxUSR.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "comprobar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Myapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxUSR);
            this.Controls.Add(this.textBoxPWD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonIngreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Myapp";
            this.Text = "Myapp";
            this.Activated += new System.EventHandler(this.Myapp_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPWD;
        private System.Windows.Forms.TextBox textBoxUSR;
        private System.Windows.Forms.Button button1;
    }
}

