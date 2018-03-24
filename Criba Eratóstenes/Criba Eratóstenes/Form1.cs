using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criba_Eratóstenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Los Números Primos son los siguientes: "+Environment.NewLine;
            string[] primosfinales = Criba.obtener(1000).Split();


            for (int i = 0; i < primosfinales.Length; i++)
            {
                textBox1.Text += primosfinales[i] + Environment.NewLine;
            }
              
        }
    }
}
