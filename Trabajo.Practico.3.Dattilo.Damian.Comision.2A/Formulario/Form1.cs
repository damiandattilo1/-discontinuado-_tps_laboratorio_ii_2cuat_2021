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

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

            Calidad<AireAcondicionado> aires = new Calidad<AireAcondicionado>(4);
            
            this.Text = "TP 3 de Dattilo, Damian del curso 2A";
            this.StartPosition = FormStartPosition.CenterScreen;
            
            //this.elegirClase.Items.AddRange(new String[] { "Microondas", "Aire Acondicionado" });
            
            this.eficiencia1.Items.AddRange(new String[] { "A", "B", "C", "D" });
            
            this.marca1.Items.AddRange(new String[] { "LG", "Whirlpool", "Philco", "Samsung", "Sony" });

            this.eficiencia2.Items.AddRange(new String[] { "A", "B", "C", "D" });

            this.marca2.Items.AddRange(new String[] { "LG", "Whirlpool", "Philco", "Samsung", "Sony" });

            this.tipo1.Items.AddRange(new String[] { "Frio", "Calor", "FrioCalor", "Deshumidificador"});

            this.tipo2.Items.AddRange(new String[] { "Frio", "Calor", "FrioCalor", "Deshumidificador" });
        }

        private void id1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(id1.Text) || string.IsNullOrWhiteSpace(precio1.Text) || string.IsNullOrWhiteSpace(porcentaje1.Text) || String.IsNullOrWhiteSpace(eficiencia1.Text) || String.IsNullOrWhiteSpace(marca1.Text) || String.IsNullOrWhiteSpace(tipo1.Text))
            {
                MessageBox.Show("ERROR: Ingrese valores");
            }
            else
            {
                EMarca m1 = (EMarca)Enum.Parse(typeof(EMarca), marca1.Text);
                EficienciaEnergetica e1 = (EficienciaEnergetica)Enum.Parse(typeof(EficienciaEnergetica), eficiencia1.Text);
                ETipo t1 = (ETipo)Enum.Parse(typeof(ETipo), tipo1.Text);

                EMarca m2 = (EMarca)Enum.Parse(typeof(EMarca), marca2.Text);
                EficienciaEnergetica e2 = (EficienciaEnergetica)Enum.Parse(typeof(EficienciaEnergetica), eficiencia2.Text);
                ETipo t2 = (ETipo)Enum.Parse(typeof(ETipo), tipo2.Text);

                AireAcondicionado aire1 = new AireAcondicionado(int.Parse(id1.Text), m1, e1, int.Parse(porcentaje1.Text), t1 , int.Parse(precio1.Text));
                AireAcondicionado aire2 = new AireAcondicionado(int.Parse(id2.Text), m2, e2, int.Parse(porcentaje2.Text), t2, int.Parse(precio2.Text));

                if(aire1 == aire2)
                {
                    MessageBox.Show("Los aires acondicionados son IGUALES");
                }
                else
                {
                    MessageBox.Show("Los aires acondicionados son DISTINTOS");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void caracteristica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
