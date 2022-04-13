using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, "+");

            lblResultado.Text = resultado.ToString();
        }

        public static double Operar(string numero1, string numero2, string operador)
        {
            Operando n1 = new Operando(numero1);
            Operando n2 = new Operando(numero2);

            return Calculadora.Operar(n1, n2, char.Parse(operador));
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultadoBinario = Operando.DecimalBinario(double.Parse(this.lblResultado.Text));

            lblResultado.Text = resultadoBinario;
        }
    }
}
