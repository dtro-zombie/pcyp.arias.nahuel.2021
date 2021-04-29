using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clase6.Ejercicio1.Abc
{
    class Program
    {
        // 64 para poder usar el codigo ascii
        private static int conteo = 64;
        //corte para el bucle
        private static bool ejecutar = true;
        
        //uso este objeto para crear un lock
        private static  object control = new object();
        private static int id1 = 0;
        private static int id2 = 0;

        static void Main(string[] args)
        {

            //creo el primer hilo y utiliza el metodo incremento

            Thread hilo1 = new Thread(Incremento);

            //lo inicio
            hilo1.Start();

            //obtener el id del hilo 1
            id1 = hilo1.ManagedThreadId;

            //creo el segundo que tambien utiliza el mismo metodo
            Thread hilo2 = new Thread(Incremento);
            // se inicia
            hilo2.Start();

            //obtener el id del hilo 2
            id2 = hilo2.ManagedThreadId;


            //condicion de corte del bucle
            while (ejecutar)
            {
                if(conteo==89)
                {
                    ejecutar = false;
                }
            }

            

            Console.ReadLine();

        }

        //metodo que utilizan los hilos
        static void Incremento()

        {
            
            // bucle la condicion de corte esta mas arriba
            while (ejecutar)
            {
                
                // este objeto controla que los hilos no accedan al mismo tiempo o que alguno se quede sin ejecutarse
                // en sistemas operativos es la condicion de carrera
                lock (control)
                {
                    //segun el id del hilo le coloco un color y digo si entro el 1 o el 2 
                    if (Thread.CurrentThread.ManagedThreadId == id1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("hilo1");
                    }

                    if (Thread.CurrentThread.ManagedThreadId == id2)
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("hilo2");
                    }

                    // conteo aumenta 1 para el bucle y llegar a la condicion de corte
                    conteo += 1;
                    // lo que hago aca es utilizar numeros del codigo ascii desde el 64 al 89
                    // ya que asi me va a dar con un casteo las letras del abc 
                    // utilizo lo que vale conteo y luego un casteo a byte
                    //La palabra clave byte se usa para declarar números enteros de 8 bits sin signo. 
                    //Su rango de valores aceptable es 0 a 255. Equivale al tipo de datos System.Byte de la plataforma .NET.
                    byte a;
                    a = (byte)conteo;
                    
                    Console.WriteLine(" letra " + (char)a);
                    //el hilo espera para que pueda ejecutarse el otro y asi hasta terminar el bucle
                    Thread.Sleep(100);
                }
            }
        }
    }
}
