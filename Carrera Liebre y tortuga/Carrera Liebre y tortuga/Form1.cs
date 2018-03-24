using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera_Liebre_y_tortuga
{
    public partial class Form1 : Form
    {
        Liebre l1;
        Tortuga t1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = " ";
           l1 = new Liebre(textBox1.Text);
          t1 = new Tortuga(textBox2.Text);

            while (l1.Posicion < 80 && t1.Posicion < 80)
            {
                textBox3.Text += "La Liebre " + textBox1.Text + " se a desplazado: " + l1.correr().ToString() + " Casillas"+ Environment.NewLine;
                textBox3.Text += "La tortuga " + textBox2.Text + " se a desplazado: " + t1.correr().ToString() +" Casillas"+ Environment.NewLine;
            }

            if (l1.Posicion > t1.Posicion)
            {
                textBox3.Text += "  La liebre " + textBox1.Text + " ha ganado";
            }
            else if (t1.Posicion > l1.Posicion)
            {
                textBox3.Text += "  La tortuga " + textBox2.Text + " ha ganado";
            }
            else if (l1.Posicion > 80 && t1.Posicion > 80)
            {
                textBox3.Text += " Es Un Legendario Empate";
            }
        }
    }
}
