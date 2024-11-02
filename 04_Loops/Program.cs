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

            //Loops 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21

            //Console.WriteLine("****************************");
            ////int i;
            ////for (i = 1; i <= 5; i++)
            ////{
            ////    Console.WriteLine("C# Eğitim Kampı");
            ////}
            //Console.WriteLine("****************************");
            ////for (int i = 1; i <=20; i++)
            ////{
            ////    Console.WriteLine(i);
            ////}
            //Console.WriteLine("****************************");
            ////for (int i = 3; i <= 50; i+=3)
            ////{
            ////    Console.WriteLine(i);
            ////}
            //Console.WriteLine("****************************");

            //Console.Write("Lütfen ekrana yazdırılmasını istediğiniz adedi giriniz: ");
            //int finishValue= int.Parse(Console.ReadLine());

            //for (int i = 1; i < = finishValue; i++)
            //{
            //    Console.WriteLine("YAŞASIN CUMHURİYET");
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

            //Console.WriteLine("***************************");
            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //Console.WriteLine("***************************");

            int totalValue=0;

            for (int i = 1; i<=20;i++)
            {
                if (i%2==0)
                {
                    totalValue += i;
                    Console.WriteLine(i);
                }
                

            }
            Console.WriteLine("-----------");
            Console.WriteLine(totalValue);








            #endregion


            Console.Read();
        }

    }
}
