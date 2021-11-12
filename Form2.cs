using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tds3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int valora = Convert.ToInt32(txtValorA.Text);
            int valorb = Convert.ToInt32(txtValorB.Text);
            int soma = valora + valorb;

            lblResultado.Text = Convert.ToString(soma);
            txtValorA.Text = "";
            txtValorB.Text = "";

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int valora = Convert.ToInt32(txtValorA.Text);
            int valorb = Convert.ToInt32(txtValorB.Text);
            int soma = valora - valorb;

            lblResultado.Text = Convert.ToString(soma);
            txtValorA.Text = "";
            txtValorB.Text = "";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int valora = Convert.ToInt32(txtValorA.Text);
            int valorb = Convert.ToInt32(txtValorB.Text);
            int soma = valora * valorb;

            lblResultado.Text = Convert.ToString(soma);
            txtValorA.Text = "";
            txtValorB.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int valora = Convert.ToInt32(txtValorA.Text);
            int valorb = Convert.ToInt32(txtValorB.Text);
            int soma = valora / valorb;

            lblResultado.Text = Convert.ToString(soma);
            txtValorA.Text = "";
            txtValorB.Text = "";
        }
    }
}
