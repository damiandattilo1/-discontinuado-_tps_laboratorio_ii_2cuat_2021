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
            
            this.Text = "Calculadora de Dattilo, Damian del curso 2A";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.cmbOperador.Items.AddRange(new String[] { "", "+", "-", "*", "/" });
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
    
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }


        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.Yes)
            {
                Dispose();
            }
            else
            {
                MessageBox.Show("Cierre cancelado");
            }
        }

        /// <summary>
        /// Evento que convierte el resultado a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Operando.DecimalBinario(this.lblResultado.Text);
        }

        /// <summary>
        /// Evento que convierte el resultado a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Convert.ToString(Operando.BinarioDecimal(this.lblResultado.Text));
        }
        /// <summary>
        /// Evento que llama a la funcion limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Evento que valida los parametros ingresados y llama al metodo operar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double aux;
            double resultado;
            if (String.IsNullOrWhiteSpace(txtNumero1.Text) || String.IsNullOrWhiteSpace(cmbOperador.Text) || String.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("ERROR: Ingrese valores");
            }
            else if(!double.TryParse(txtNumero1.Text, out aux) || !double.TryParse(txtNumero2.Text, out aux))
            {
                MessageBox.Show("ERROR: valores no validos");
            }
            else
            {
                
                resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
                this.lblResultado.Text = resultado.ToString();

                Operaciones();
            }
        }

        /// <summary>
        /// Reinicia los parametros
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = "";
        }

        /// <summary>
        /// Genera los objetos de la operacion y llama al metodo operar de la calculadora y retorna el resultado
        /// </summary>
        /// <param name="numero1"></param> Textbox 1
        /// <param name="numero2"></param>Textbox 2
        /// <param name="operador"></param> comboBox
        /// <returns></returns> El resultado de la operacion
        private static double Operar (string numero1, string numero2, string operador)
        {
            double resultado;
            char operadorChar = '+';
            
            Operando n1 = new Operando(numero1); 
            Operando n2 = new Operando(numero2);
            
            switch(operador)
            {
                case "+":
                    operadorChar = '+';
                    break;
                case "-":
                    operadorChar = '-';
                    break;
                case "*":
                    operadorChar = '*';
                    break;
                case "/":
                    operadorChar = '/';
                    break;

            }

            resultado = Calculadora.Operar(n1, n2, operadorChar);

            return resultado;
        }

        /// <summary>
        /// Imprime el resultado de la operacion anterior en el listBox
        /// </summary>
        private void Operaciones()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {lblResultado.Text}");
            
            lstOperaciones.Items.Add(sb.ToString());
        }


        private void Numero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Operaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FormCalculadora_Load_1(object sender, EventArgs e)
        {

        }
    }
}
