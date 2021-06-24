using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10.Ejercicio1.PatronDataflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var df1 = new TransformBlock<int, int>(t =>
            {
                Console.WriteLine("Entered 1st DF");
                Thread.Sleep(3000);
                return 2;
            });

            var df2 = new ActionBlock<int>(t =>
            {

                Console.WriteLine("Entered 2nd Task");
                Thread.Sleep(2000);
                Console.WriteLine(t);
            });

            df1.LinkTo(df2);

            df1.Completion.ContinueWith(t =>
            df2.Complete());

            df1.Post(2);

            df2.Completion.Wait();
        }

    }
}