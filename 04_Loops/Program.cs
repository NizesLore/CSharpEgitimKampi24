﻿using System;
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

            //int totalValue=0;

            //for (int i = 1; i<=20;i++)
            //{
            //    if (i%2==0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("-----------");
            //Console.WriteLine(totalValue);

            //Console.WriteLine("***************************");

            //int number = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i%7==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("***************************");
            //int count = 0;

            //for (int i = 1; i < 50; i++)
            //{
            //    if (i%7==0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //Console.WriteLine("***************************");

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda: " + bacterium);

            //}
            //Console.WriteLine("***************************");

            #endregion

            #region While Dongusu

            //While (Şart)
            //{
            //İşlemler
            //}

            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //};
            //Console.WriteLine("*****************************");
            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //Console.WriteLine("*****************************");

            //int i= 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Ornek Snav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //Console.Write("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number %100)/10;
            //hundreds = number / 100; //4.56 -->4

            //Console.WriteLine(hundreds + "-" + tens + "-" + ones);

            //sum = hundreds + tens + ones;

            //Console.WriteLine(sum);
            #endregion

          


            Console.Read();
        }

    }
}
