﻿using System;
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

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);


            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);


            //int[] numbers= new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);


            #endregion

            #region Dizideki Tum Elemanlari Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //Console.WriteLine("*************************************");
            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("*************************************");

            //char[] symbols = { 'a', 'b', 'c', '*','/','-'};

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //Console.WriteLine("*************************************");

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };


            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i]>maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);
            //Console.WriteLine("*************************************");

            string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            Console.WriteLine(persons.Length);


            #endregion

            Console.Read();
        }
    }
}