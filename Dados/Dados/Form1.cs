using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

         Dado d1 = new Dado();
         Dado d2 = new Dado();
        Dado d3 = new Dado();
        int[] cara = new int[6];
        int[] resultado = new int[11];
        int[] resultado2 = new int[11];





        //int a = 0;
        //int b = 0;
        //int y = 0;
        //int d = 0;
        //int e = 0;
        //int f = 0;
        //for (int z = 0; z <= 100; z++)
        //{
        //    cara = rnd.Next(1, 7);
        //    if (cara == 1)
        //    {
        //        a++;
        //    }
        //    if (cara == 2)
        //    {
        //        b++;
        //    }
        //    if (cara == 3)
        //    {
        //        y++;
        //    }
        //    if (cara == 4)
        //    {
        //        d++;
        //    }
        //    if (cara == 5)
        //    {
        //        e++;
        //    }
        //    if (cara == 6)
        //    {
        //        f++;
        //    }
        //}
        //string resultados = "La cara 1 cayó este numero de veces " + a.ToString()
        //    + Environment.NewLine + "La cara 2 cayó este numero de veces " + b.ToString() + Environment.NewLine
        //   + "La cara 3 cayó este numero de veces " + y.ToString() + Environment.NewLine
        //   + "La cara 4 cayó este numero de veces " + d.ToString() + Environment.NewLine +
        //   "La cara 5 cayó este numero de veces " + e.ToString() + Environment.NewLine
        //   + "La cara 6 cayó este numero de veces " + f.ToString();
        //return resultados;

        //public string lanzar2dado()
        //{ Haha lo que estaba haciendo xD
        //    int cara;
        //    int cara2;
        //    int a1 = 0;
        //    int a2 = 0;
        //    int a3 = 0;
        //    int a4 = 0;
        //    int a5 = 0;
        //    int a6 = 0;
        //    int a7 = 0;
        //    int a8 = 0;
        //    int a9 = 0;
        //    int a10 = 0;
        //    int a11 = 0;
        //    int a12 = 0;
        //    for (int z = 0; z <= 100; z++)
        //    {
        //        cara = rnd.Next(1, 7);
        //        cara2 = rnd.Next(1, 7);
        //        int suma = cara + cara2;

        //        if (suma == 2)
        //        {
        //            a1++;
        //        }
        //        if (suma == 3)
        //        {
        //            a2++;
        //        }
        //        if (suma == 4)
        //        {
        //            a3++;
        //        }
        //        if (cara == 5)
        //        {
        //            e++;
        //        }
        //        if (cara == 6)
        //        {
        //            f++;
        //        }
        //    }
        //    string resultados = "La cara 1 cayó este numero de veces " + a.ToString()
        //        + Environment.NewLine + "La cara 2 cayó este numero de veces " + b.ToString() + Environment.NewLine
        //       + "La cara 3 cayó este numero de veces " + y.ToString() + Environment.NewLine
        //       + "La cara 4 cayó este numero de veces " + d.ToString() + Environment.NewLine +
        //       "La cara 5 cayó este numero de veces " + e.ToString() + Environment.NewLine
        //       + "La cara 6 cayó este numero de veces " + f.ToString();
        //    return resultados;


        public string mostrar()
        {
            string holder = " ";
            for (int i = 0, b=1; i < cara.Length; i++ ,b++)
            {
               
                holder += "[Número de veces que salió la cara " + b + "] = " + cara[i] + Environment.NewLine;
            }
            return holder; 
        }
        public string mostrar2()
        {
            string holder = " ";
            for (int i = 0, b = 2; i <resultado.Length; i++, b++)
            {

                holder += "[Número de veces que resultó como suma el número :" + b + "] = " + resultado[i] + Environment.NewLine;
            }
            return holder;
        }
        public string mostrar3()
        {
            string holder = " ";
            for (int i = 0, b = 2; i < resultado2.Length; i++, b++)
            {

                holder += "[Número de veces que resultó como suma el número :" + b + "] = " + resultado2[i] + Environment.NewLine;
            }
            return holder;
        }
        public void limpiar()
        {
            for (int b = 0; b < resultado.Length; b++)
            {
                resultado[b] = 0;
                resultado2[b] = 0;
            }
            textBox2.Text = " ";
            textBox3.Text = " ";
        }
        public void limpiarcara()
        {
            for (int b = 0; b < cara.Length; b++)
            {
                cara[b] = 0;
            }
            textBox1.Text = " ";

        }



        private void button1_Click(object sender, EventArgs e)
        {
            for (int c = 0; c <100; c++)
            {
                int d = d1.lanzar1dado();
                cara[d - 1]++;
            }
            
            textBox1.Text = mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //for (int c = 0; c < 100; c++)
            //{
            //    int d = d2.lanzar1dado();
            //    cara[d - 1]++;
            //}

            for (int c = 0; c < 100; c++)
            {
                int x = d2.lanzar1dado()+d3.lanzar1dado();
                resultado[x - 2]++;
            }

            textBox2.Text = mostrar2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int c = 0; c < 100; c++)
            {
                int x = d1.lanzar1dado() + d1.lanzar1dado();
                resultado2  [x - 2]++;
            }

            textBox3.Text = mostrar3();
        }
       



        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
            limpiarcara();
        }
    }
    }


