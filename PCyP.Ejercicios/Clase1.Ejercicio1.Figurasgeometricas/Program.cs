using System;


namespace Clase1.Ejercicio1.Figurasgeometricas
{
    class Program
    {
        static void Main(string[] args)
        {

            //Realizar un programa capaz de calcular el área y perímetro de un cuadrado, rectángulo y triángulo. 
            //Todos los datos necesarios para su funcionamiento se ingresan por teclado.

            figura f1 = new figura();

            int opcion = 0;
            int lado = 0;
            do
            {
                
                Console.WriteLine(" 1--para area y perimetro de un cuadrado ");
                Console.WriteLine(" 2--para area y perimetro de un rectangulo ");
                Console.WriteLine(" 3--para area y perimetro de un triangulo");
                Console.WriteLine(" 0--para salir");
                string l = Console.ReadLine();
                opcion = int.Parse(l);

                switch (opcion)
                {
                    case 1:

                        //CUADRADO
                        
                        Console.WriteLine("ingrese un lado");
                        l = Console.ReadLine();
                        lado = int.Parse(l);
                        Console.WriteLine("PERIMETRO");
                        Console.WriteLine(f1.PerimetroCuadrado(lado)); 

                        Console.WriteLine("AREA");
                        Console.WriteLine(f1.areadelcuadrado(lado));
                        


                        break;

                    case 2:
                        int base2 = 0;
                        int altura = 0;
                        //RECTANGULO
                        Console.WriteLine("ingrese la base");
                        l = Console.ReadLine();
                        base2 = int.Parse(l);

                        Console.WriteLine("ingrese la altura");
                        l = Console.ReadLine();
                        altura = int.Parse(l);

                        Console.WriteLine("PERIMETRO");
                        Console.WriteLine(f1.PerimetroRectangulo(base2,altura));

                        Console.WriteLine("AREA");
                        Console.WriteLine(f1.areadelRectangulo(base2, altura));

                        break;

                    case 3:
                        //TRIANGULO
                        int lado2 = 0;
                        int lado3 = 0;

                        Console.WriteLine("ingrese la base");
                        l = Console.ReadLine();
                        base2 = int.Parse(l);

                        Console.WriteLine("ingrese la altura");
                        l = Console.ReadLine();
                        altura = int.Parse(l);

                        Console.WriteLine("ingrese un lado");
                        l = Console.ReadLine();
                        lado = int.Parse(l);
                        Console.WriteLine("ingrese un lado 2");
                        l = Console.ReadLine();
                        lado2 = int.Parse(l);
                        Console.WriteLine("ingrese un lado 3");
                        l = Console.ReadLine();
                        lado3 = int.Parse(l);


                        Console.WriteLine("AREA");
                        Console.WriteLine(f1.areadelTriangulo(base2, altura));

                        Console.WriteLine("PERIMETRO");

                        Console.WriteLine(f1.PerimetroTriangulo(lado, lado2, lado3));

                        break;
                }
            } while (opcion!=0);


            



        }
    }
}
