using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Ornekleri

            //2 4 6 8 
            //sarı, kırmızı, mavi, turuncu, beyaz
            //adana, ankara, istanbul, bursa
            //DegiskenTuru[] DiziAdi =new DegiskenTuru[ElemanSayisi]

            string[] colors = new string[4];
            colors[0] = "Kırmızı";
            colors[1] = "Sarı";
            colors[2] = "Beyaz";
            colors[3] = "Mavi";

            Console.WriteLine(colors[2]);




            #endregion

            Console.Read();
        }
    }
}
