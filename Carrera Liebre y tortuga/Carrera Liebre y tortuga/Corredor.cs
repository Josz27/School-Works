using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_Liebre_y_tortuga
{
  abstract  class Corredor
    {
   
        protected static Random rnd = new Random();

        public Corredor()
        {

        }

        public int Correr()
        {
            return rnd.Next(1, 11);
            
        }


}
    }

