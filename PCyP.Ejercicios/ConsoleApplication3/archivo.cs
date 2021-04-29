using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication3
{
    class archivo
    {



    public void imprimir(string[] lineas)
        {

            foreach (var linea in lineas)
            {
                var valores = linea.Split(',');
                Console.WriteLine(" NUMERO DE HOJA: " + valores[0]
                    + " TIPO OBJETO: " + valores[1]
                    + " IDENTIFICADOR TRAMO: " + valores[2]
                    + " TIPO CAMINO: " + valores[3]
                    + " LONGITUD: " + valores[4]);
                Console.WriteLine("");
            }

        }

       
    }
}
