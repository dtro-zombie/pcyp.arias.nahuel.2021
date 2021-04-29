using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figurasgeometricas
{
    class figura
    {

        public int PerimetroCuadrado(int lado)
        {
            

            


            return lado*4;
        }
            

        public int areadelcuadrado(int lado)
        {
           


            return lado *= lado;
        }

        public int PerimetroRectangulo(int base2, int altura)
        {

            return (2*base2)+(2*altura);

        }
        public int PerimetroTriangulo(int lado1, int lado2, int lado3)
       
        {
            return lado1+lado2+lado3;
        }

        public int areadelRectangulo(int base2, int altura)
        {

            return base2 * altura;

        }

        public int areadelTriangulo(int base2, int altura)
        {
            return (base2 * altura)/2;
        }

       
    }

   

}
