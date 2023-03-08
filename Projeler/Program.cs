using System;

namespace Projeler
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz";
            string degisken2 = "Dersimiz CSharp";
            //Length
            Console.WriteLine(degisken.Length);

            //ToLower - ToUpper

            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //Concat - 
            Console.WriteLine(String.Concat(degisken,"Merhaba!"));

            //Compare - CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2)); // 0 , 1 , -1 
            Console.WriteLine(String.Compare(degisken,degisken2,true));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.StartsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken.EndsWith("Merhaba"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("C"));
            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //PadLeft - PadRight degisken sonuna 30'a tamamlayana kadar boşluk karakteri ekler.

            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));

            //Remove
            Console.WriteLine(degisken.Remove(10));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));

            //Split
            Console.WriteLine(degisken.Split( )[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));

        }
    }
}