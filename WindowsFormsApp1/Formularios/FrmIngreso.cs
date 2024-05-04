using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formularios
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {

        }

        private void sumar_Click(object sender, EventArgs e)
        {
            comboBoxFacultades.Items.Add("ingenieria");
            comboBoxFacultades.Items.Add("Medicina");
            comboBoxFacultades.Items.Add("Derecho");
            Resultado.Text = numero1.Text + numero2;
        }

        private void comboBoxFacultades_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxFacultades.SelectedItem+"");

        }
    }
}
