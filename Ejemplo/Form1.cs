using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int A;
            int R;
            int i;
            int j;
            txtSeleccion.Text = comboBox1.SelectedIndex.ToString();
            switch (comboBox1.SelectedIndex)
            {           
                case -1: 
                    // SELECCIONA OPCION
                    txtSeleccion.Text = comboBox1.SelectedIndex.ToString();
                    MessageBox.Show("Selecciona Opcion","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
                case 0: 
                    // OPCION NUMERO PRIMO
                    //txtSeleccion.Text = comboBox1.SelectedIndex.ToString();
                    //MessageBox.Show("Has Seleccionado la Opcion: " + comboBox1.SelectedItem.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtResultado.Clear();
                    for ( i=2; i<=int.Parse(txtNumero1.Text);i++)
                    {
                        for (j=2;j<=int.Parse(txtNumero1.Text);j++)
                        {
                            if( i % j == 0)
                            {
                                txtResultado.Text=txtResultado.Text+j;
                            }
                        }
                    }
                    //txtResultado.Text = R;
                    break;
                default:
                    break;
            }
        }
            
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
