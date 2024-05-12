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

            int n1 = Convert.ToInt32(numero1.Text);
            int n2 = Convert.ToInt32(numero2.Text);
            Resultado.Text = (n1 + n2).ToString();
        }

        private void comboBoxFacultades_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxFacultades.SelectedItem.ToString());

        }

        private void carreras_Click(object sender, EventArgs e)
        {
            comboBoxFacultades.Items.Add("ingenieria");
            comboBoxFacultades.Items.Add("Medicina");
            comboBoxFacultades.Items.Add("Derecho");
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            numero1.Clear();
            numero2.Clear();
            Resultado.Clear();
        }

        private void numero1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
