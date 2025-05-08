using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Altura(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txbAltura.Text != "" && txbPeso.Text != "" && txbAltura.Text != "0" && txbPeso.Text != "0")
            {

                double altura = double.Parse(txbAltura.Text);
                double peso = double.Parse(txbPeso.Text);

                double imc = peso / (altura * altura);
                txbIMC.Text = Math.Round(imc,2).ToString();

                if (imc < 18.50)
                {
                    txbResultado.Text = "Baixo peso";
                    
                } 
                else if(imc <= 24.99)
                {
                    txbResultado.Text = "Peso Normal";
                }
                else if(imc <= 29.99)
                {
                    txbResultado.Text = "Excesso de peso";
                }
                else if (imc <= 34.99)
                {
                    txbResultado.Text = "Obesidade garu I";
                }
                else if (imc <= 39.99)
                {
                    txbResultado.Text = "Obeseidade grau II";
                }
                else
                {
                    txbResultado.Text = "Obesidade grau III";
                }
             }
            else
            {
                MessageBox.Show("Erro, altura e peso não podem ser nulos ","Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
           
        
        private void txbIMC_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
