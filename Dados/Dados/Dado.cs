using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
   public class Dado
    {
        static   Random rnd = new Random();
        public int caras;
        public Dado()
        {
            caras = 6;
        }

        public int lanzar1dado()
        {   
            
                 int cara = rnd.Next(1, 7);
                return cara;
         }
        }
    }

