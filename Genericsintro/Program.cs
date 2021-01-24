using System;
using System.Collections.Generic;

namespace Genericsintro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Deniz");
            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);

            Console.WriteLine("Deniz Aral");
            
        }
    }
}
