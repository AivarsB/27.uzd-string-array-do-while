using System;

namespace _27.uzd_string_array_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Janis", "Peteris", "Gusts", "Aivars", "Juris" };

            int n = 0;
            int m = 0;

            do
            {
                Console.WriteLine(names[m]);
                n++;
                m++;
            }
            while (n < names.Length);
        }
    }
}
// Izveidot console aplikāciju, kurā ir definēts string tipa masīvs ar cilvēku vārdiem. Izmantojot do while ciklu izdrukāt visus vārdus.
