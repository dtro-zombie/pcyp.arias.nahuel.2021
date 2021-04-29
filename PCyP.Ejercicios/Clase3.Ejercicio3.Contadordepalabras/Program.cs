using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio3.Contadordepalabras
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> palabra = new Dictionary<string, int>();
            string[] frase = new string[250];

            string frase1 = "son las 5 menos  5 faltan 5 para las 5 cuantas veces dije 5 sin contar la ultima vez que dije 5";


            string[] misplits = frase1.Split(new char[] { ' ' });
            int cont = 0;
            for (int i=0; i<= misplits.Length-1;i++)
            {
                for(int j=0; j<=misplits.Length-1;j++)
                {
                    

                    if(misplits[i]==misplits[j])
                    {
                        cont++;
                    }
                }

                if (!palabra.ContainsKey(misplits[i]))
                {

                    palabra.Add(misplits[i], cont);
                }

                else if(i == 0)
                {
                    palabra.Add(misplits[i], 1);
                }
                cont = 0;
            }

            Console.WriteLine();

            foreach(KeyValuePair<string, int> element in palabra)
            {
                Console.WriteLine("key={0}   total={1}  ", element.Key, element.Value);
                Console.WriteLine();
            }


        }
    }
}
