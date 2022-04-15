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
            this.cmbOperador.Items.AddRange(new String[] { "", "+", "-", "*", "/" });
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.Yes)
            {
                Dispose();
            }
            else
            {
                MessageBox.Show("Cierre cancelado", "Salir", MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultadoBinario;


            if (string.IsNullOrEmpty(this.lblResultado.Text))
            {
                MessageBox.Show("ERROR, Realize alguna operacion");
            }
            else
            {
                resultadoBinario = Operando.DecimalBinario(double.Parse(this.lblResultado.Text));
                lblResultado.Text = resultadoBinario;

                btnConvertirABinario.Enabled = false;
                btnConvertirADecimal.Enabled = true;
            }

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultadoDecimal;

            if(string.IsNullOrEmpty(this.lblResultado.Text))
            {
                MessageBox.Show("ERROR, Realize alguna operacion");
            }
            else
            {
                resultadoDecimal = Operando.BinarioDecimal(this.lblResultado.Text);
                lblResultado.Text = resultadoDecimal;

                btnConvertirABinario.Enabled = true;
                btnConvertirADecimal.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            StringBuilder sb = new StringBuilder();

            if(!string.IsNullOrEmpty(this.txtNumero1.Text) && !string.IsNullOrEmpty(this.txtNumero2.Text) && !string.IsNullOrEmpty(this.cmbOperador.Text))
            {
                resultado= Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                lblResultado.Text = resultado.ToString();

                sb.Append($"{this.txtNumero1.Text} {this.cmbOperador.Text} {this.txtNumero2.Text} = {this.lblResultado.Text}");
                lstOperaciones.Items.Add (sb.ToString());

                btnConvertirADecimal.Enabled = false;
                btnConvertirABinario.Enabled = true;
            }
            else
            {
                MessageBox.Show("ERROR, Ingrese parametros");
            }

        }

        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = "";
            btnConvertirADecimal.Enabled = true;
            btnConvertirABinario.Enabled = true;
            
        }

        public static double Operar(string numero1, string numero2, string operador)
        {
            Operando n1 = new Operando(numero1);
            Operando n2 = new Operando(numero2);

            return Calculadora.Operar(n1, n2, char.Parse(operador));
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
