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
                    Primos(txtNumero1.Text);
                    
                    break;
                default:
                    break;
            }
        }
            
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Primos(String Num)
        {
            int cont=0;
            int cpi=0;
            int N = Convert.ToInt32(Num);
            for(int i=N;i>0;--i)
            {
                for(int j=1;j<=N;j++)
                {
                    if(i%j==0)
                    {
                        cont += 1;
                    }
                }
                if(cont<3)
                {
                    if(cpi<=4)
                    {
                        listBox1.Items.Add(i);
                        cpi++;
                    }
                }
                cont = 0;
            }


        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
