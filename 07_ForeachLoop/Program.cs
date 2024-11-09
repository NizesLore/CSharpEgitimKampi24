using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loop

            //Foreach(1;2;3;4)

            //1: Degisken Turu
            //2: Degisken Adi
            //3: In
            //4: Liste, Koleksiyon, Dizi

            string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }


            #endregion

            Console.Read();

        }
    }
}
