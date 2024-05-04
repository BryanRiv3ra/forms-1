using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formularios
{
    public partial class FRMheredado : WindowsFormsApp1.Myapp
    {
        public FRMheredado()
        {
            InitializeComponent();
        }

        private void Saludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola pa");
        }
    }
}
