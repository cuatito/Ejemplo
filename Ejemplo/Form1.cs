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
            listBox1.Items.Clear();
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
                    Primos(txtNumero1.Text);
                    break;
                case 1:
                    // OPCION NUMERO PRIMO
                    //Fibonacci(txtNumero1.Text);
                    break;
                case 2:
                    // OPCION NUMERO PRIMO
                    Factorial(txtNumero1.Text);
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
            for(int i=0;i<=N;++i)
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
                    if(cpi<=N)
                    {
                        listBox1.Items.Add(i.ToString("N0"));
                        cpi++;
                    }
                }
                cont = 0;
            }
        }

        private void Factorial (String Num)
        {
            Double R=1;
            for(int i=2; i<=Convert.ToInt32(Num); ++i)
            {
                R = R * i;
            }
            listBox1.Items.Add(R.ToString("N0"));
        }
        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
