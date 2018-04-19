using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catálogo_vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Catálogo c1 = new Catálogo();
        int c;
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            c = c1.buscarEspacio();
            
            
               
            
            //if (c==-1)
            //{
            //    MessageBox.Show("No hay espacio para más productos");
            //}
           
           
            c1.agregarproducto(c, Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox4.Text));
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            
        }
        



        private void button5_Click(object sender, EventArgs e)
        {
            string s = " ";

          s=c1.mostrarCatálogo();
            textBox5.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            string s = " ";
            s+= c1.Buscar(Convert.ToInt32(textBox1.Text));
            textBox5.Text = s;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c1.seEncontro(Convert.ToInt16(textBox1.Text)) == true)
            {
                c--;
            }
            c1.Eliminar(Convert.ToInt16(textBox1.Text));
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBox6.Text)-1;
            c1.agregarproducto(c, Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox4.Text));
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
        }
    }
}
