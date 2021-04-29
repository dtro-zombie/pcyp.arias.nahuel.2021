using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        

        static void Main(string[] args)


        {

            archivo a1 = new archivo();
            string[] lineas= File.ReadAllLines("./files/vial.csv");


            a1.imprimir(lineas);
            


        }
    }
}

