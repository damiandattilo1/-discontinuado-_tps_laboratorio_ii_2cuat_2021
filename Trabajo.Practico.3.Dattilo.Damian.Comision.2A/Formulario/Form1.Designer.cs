
namespace Formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.eficiencia1 = new System.Windows.Forms.ComboBox();
            this.id1 = new System.Windows.Forms.TextBox();
            this.porcentaje1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.marca1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.precio1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tipo1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.precio2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.marca2 = new System.Windows.Forms.ComboBox();
            this.porcentaje2 = new System.Windows.Forms.TextBox();
            this.id2 = new System.Windows.Forms.TextBox();
            this.eficiencia2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tipo2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eficiencia1
            // 
            this.eficiencia1.BackColor = System.Drawing.SystemColors.Window;
            this.eficiencia1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eficiencia1.FormattingEnabled = true;
            this.eficiencia1.Location = new System.Drawing.Point(375, 177);
            this.eficiencia1.Name = "eficiencia1";
            this.eficiencia1.Size = new System.Drawing.Size(121, 24);
            this.eficiencia1.TabIndex = 1;
            this.eficiencia1.Tag = "";
            // 
            // id1
            // 
            this.id1.Location = new System.Drawing.Point(64, 175);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(100, 22);
            this.id1.TabIndex = 3;
            this.id1.TextChanged += new System.EventHandler(this.id1_TextChanged);
            // 
            // porcentaje1
            // 
            this.porcentaje1.Location = new System.Drawing.Point(567, 175);
            this.porcentaje1.Name = "porcentaje1";
            this.porcentaje1.Size = new System.Drawing.Size(100, 22);
            this.porcentaje1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Operar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // marca1
            // 
            this.marca1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marca1.FormattingEnabled = true;
            this.marca1.Location = new System.Drawing.Point(199, 173);
            this.marca1.Name = "marca1";
            this.marca1.Size = new System.Drawing.Size(121, 24);
            this.marca1.TabIndex = 6;
            this.marca1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Porcentaje de fallas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seleccione Eficiencia Energetica 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ingrese  ID 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Marca\r\n";
            // 
            // precio1
            // 
            this.precio1.Location = new System.Drawing.Point(748, 179);
            this.precio1.Name = "precio1";
            this.precio1.Size = new System.Drawing.Size(100, 22);
            this.precio1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(730, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Precio";
            // 
            // tipo1
            // 
            this.tipo1.BackColor = System.Drawing.SystemColors.Window;
            this.tipo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo1.FormattingEnabled = true;
            this.tipo1.Location = new System.Drawing.Point(898, 174);
            this.tipo1.Name = "tipo1";
            this.tipo1.Size = new System.Drawing.Size(121, 24);
            this.tipo1.TabIndex = 20;
            this.tipo1.Tag = "";
            this.tipo1.SelectedIndexChanged += new System.EventHandler(this.caracteristica_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(895, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Seleccione Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(730, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Precio";
            // 
            // precio2
            // 
            this.precio2.Location = new System.Drawing.Point(748, 277);
            this.precio2.Name = "precio2";
            this.precio2.Size = new System.Drawing.Size(100, 22);
            this.precio2.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Marca\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Ingrese  ID 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(320, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Seleccione Eficiencia Energetica 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(564, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Porcentaje de fallas";
            // 
            // marca2
            // 
            this.marca2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marca2.FormattingEnabled = true;
            this.marca2.Location = new System.Drawing.Point(199, 271);
            this.marca2.Name = "marca2";
            this.marca2.Size = new System.Drawing.Size(121, 24);
            this.marca2.TabIndex = 25;
            // 
            // porcentaje2
            // 
            this.porcentaje2.Location = new System.Drawing.Point(567, 273);
            this.porcentaje2.Name = "porcentaje2";
            this.porcentaje2.Size = new System.Drawing.Size(100, 22);
            this.porcentaje2.TabIndex = 24;
            // 
            // id2
            // 
            this.id2.Location = new System.Drawing.Point(64, 273);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(100, 22);
            this.id2.TabIndex = 23;
            // 
            // eficiencia2
            // 
            this.eficiencia2.BackColor = System.Drawing.SystemColors.Window;
            this.eficiencia2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eficiencia2.FormattingEnabled = true;
            this.eficiencia2.Location = new System.Drawing.Point(375, 277);
            this.eficiencia2.Name = "eficiencia2";
            this.eficiencia2.Size = new System.Drawing.Size(121, 24);
            this.eficiencia2.TabIndex = 22;
            this.eficiencia2.Tag = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(877, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "Seleccione Tipo";
            // 
            // tipo2
            // 
            this.tipo2.BackColor = System.Drawing.SystemColors.Window;
            this.tipo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo2.FormattingEnabled = true;
            this.tipo2.Location = new System.Drawing.Point(880, 272);
            this.tipo2.Name = "tipo2";
            this.tipo2.Size = new System.Drawing.Size(121, 24);
            this.tipo2.TabIndex = 32;
            this.tipo2.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "IGUALDAD DE AIRES ACONDICIONADOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tipo2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.precio2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.marca2);
            this.Controls.Add(this.porcentaje2);
            this.Controls.Add(this.id2);
            this.Controls.Add(this.eficiencia2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tipo1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.precio1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.marca1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.porcentaje1);
            this.Controls.Add(this.id1);
            this.Controls.Add(this.eficiencia1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox eficiencia1;
        private System.Windows.Forms.TextBox id1;
        private System.Windows.Forms.TextBox porcentaje1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox marca1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox precio1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox tipo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox precio2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox marca2;
        private System.Windows.Forms.TextBox porcentaje2;
        private System.Windows.Forms.TextBox id2;
        private System.Windows.Forms.ComboBox eficiencia2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox tipo2;
        private System.Windows.Forms.Label label1;
    }
}

