using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criba_Eratóstenes
{
    class Criba
    {
        private static bool[] _primos;//Vector de booleans

       

        public static void proceso(int x) //Se toma el primer número no tachado(Notas mías, es de una página, lo pegué aquí para apoyarme) y se eleva al cuadrado, si el resultado es menor que max se tachan todos sus múltiplos

        {
            _primos = new bool[x + 1];//Llenar hasta el límite
            for (int z = 0; z < x + 1; z++)
            {
                _primos[z] = true;
            }
         
            for (int inicio = 2; inicio < Math.Sqrt(_primos.Length); inicio++) // Se nos dice que iniciemos desde el 2.
            {
                if (_primos[inicio]==true)
                {
                    for (int e = inicio+1; e < _primos.Length; e++)  //Tomamos el siguiente número que no fue tachado.
                       
                    {
                        if (e % inicio == 0)
                        {
                            _primos[e] = false; //Tachamos los múltiplos
                        }

                        }

                     }

                     }
                     }
        // Igual se podría hacer en un método todo pero apenas y le entendí a lo que hice =) ...Si veo esto después de vacaciones no le voy a entender ni madres.
            
            public static string obtener(int x)
         {
            proceso(x);// Uso del método anterior para no hacer un desmadre en uno solo.
            string resultado = " ";
            for (int inicio = 2; inicio < _primos.Length; inicio++) //Comenzamos desde 2 como dice la fórmula.
            if (_primos[inicio]==true)

            resultado =resultado+inicio + ",";

            return resultado;
         }
            }
      }
// Tiene dudas de mis notas? piensa que lo copié de internet? Nel, Mire, https://aureliux.files.wordpress.com/2013/03/cribaeratostenes.pdf ni siquiera usaron vectores, solamente usé los textos que explicaban el procedimiento para hacerlo con vectores...
