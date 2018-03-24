using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_Liebre_y_tortuga
{
    class Tortuga:Corredor
    {
        public int _posicion = 0;
        private string _nombre;
        public  int _pasos;


        public string nombre
        {
            get { return _nombre; }
        }

        public int Posicion
        {
            get { return _posicion; }
        }
        public Tortuga(string nombre)
        {
            _nombre = nombre;
        }

        public int correr()
        {
             _pasos = Correr(); // paso rápido
            if (_pasos == 1 || _pasos == 2 || _pasos == 3 || _pasos == 4 || _pasos == 5)
            {
                return _posicion+=3 ;
            }

            else if (_pasos == 6 || _pasos == 7)//resbalón
            {
                return _posicion -= 6;
            }

            else // paso lento
            {
                return _posicion++;
            }

        }
    }
}

