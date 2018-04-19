using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catálogo_vectores
{
    class Catálogo
    {
        int[] codigo = new int[15];
        string[] nombre = new string[15];
        int[] cantidad = new int[15];
        double[] costo = new double[15];

        public void agregarproducto(int posicion, int codigos, string nombres, int cantidades, double costos)
        {
            codigo[posicion] = codigos;
            nombre[posicion] = nombres;
            cantidad[posicion] = cantidades;
            costo[posicion] = costos;

        }
        public string mostrarCatálogo()
        {
            string s = "";
            int x = 1;
            for (int c = 0; c < 15; c++)
            {
                s += "Datos Producto " + x + " Código: " + codigo[c].ToString() + " " + "Nombre: " + nombre[c] + " " + "Cantidad: " + cantidad[c].ToString() + " " + "Costo: " + costo[c].ToString() + Environment.NewLine;
                x++;
            }
            return s;
        }

        public string Buscar(int codigoProducto)
        {
            string s = "";
            for (int c = 0; c < 15; c++)
            {
                if (codigoProducto == codigo[c])
                {
                    s = s += "Datos Producto " + " Código: " + codigo[c].ToString() + " " + "Nombre: " + nombre[c] + " " + "Cantidad: " + cantidad[c].ToString() + " " + "Costo: " + costo[c].ToString();
                    return s;

                }
                else
                {
                    s = "No se encontró el producto";
                }
            }
            return s;
        }
        public void Eliminar(int codigoProducto)
        {
            for (int c = 0; c < 15; c++)
            {
                if (codigoProducto == codigo[c])
                {
                    codigo[c] = 0;
                    nombre[c] = "0";
                    cantidad[c] = 0;
                    costo[c] = 0;

                }
            }
        }

        public Boolean seEncontro(int codigoProducto)
        {
            Boolean a = false;
            for (int c = 0; c < 15; c++)
            {
                if (codigoProducto == codigo[c])
                {
                    a = true;

                }

            }
            return a;
        }
        public int buscarEspacio()
        {
            int regresar = -1;
            for (int c = 0; c < 15; c++)
            {
                if (costo[c]==0)
                {
                    return regresar = c;
                }
            }
            return regresar;

        }
        //public void insertar(int posicion, int codigos, string nombres, int cantidades, double costos)
        //{
        //    codigo[posicion] = codigos;
        //    nombre[posicion] = nombres;
        //    cantidad[posicion] = cantidades;
        //    costo[posicion] = costos;
        //}




    }
}

