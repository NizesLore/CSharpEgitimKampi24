using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For

            //Loops
            //3+3=6

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.Write("Lütfen ekrana yazdırılmasını istediğinizz adedi giriniz: ");
            //int finishValue= int.Parse(Console.ReadLine());

            //for (int i = 1; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın CUMHURİYET");
            //}



            #endregion


            #region For Döngüsü ile Karar Yapıları
            //for (int i =1; i <=100; i++)
            //{
            //    if (i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            int totalValue = 0;
            //int totalValue=0;

            for (int i = 1; i <=10; i++)
            {
                totalValue += i;
            }
            Console.WriteLine(totalValue);

            #endregion


            Console.Read();
        }

    }
}
