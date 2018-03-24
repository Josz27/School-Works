using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_Liebre_y_tortuga
{
    class Liebre:Corredor
    {
        private string _nombre;
        public int _posicion = 0, _pasos;

        public string nombre
        {
            get { return _nombre; }
        }

        public int Posicion
        {
            get { return _posicion; }
        }


        public Liebre(string nombre)
        {
            _posicion = 0;
            _nombre = nombre;
        }
        public int correr()
        {
             _pasos = Correr();

            if (_pasos == 1 || _pasos == 2 ) // dormir
            {
                return _posicion +=0 ;
            }

            else if (_pasos == 3 || _pasos == 4)//Salto grande
            {
                return _posicion += 9;
            }

            else if (_pasos == 5 )// resbalón grande
            { 
                return _posicion -= 12;
            }
            else if (_pasos == 6 || _pasos == 7 || _pasos==8) // salto pequeño
            {
                return _posicion++;
            }

            else //resbalón pequeño
            {
                return _posicion -= 2; 
            }

        }
    }

}

