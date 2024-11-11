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

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("-----------------------");

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //Console.WriteLine("-----------------------");
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;

            //}
            //Console.WriteLine(total);
            //Console.WriteLine("-----------------------");

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8


            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine("-----------------------");

            // string word = "Merhaba";

            //foreach (char c in word)
            // {
            //     Console.WriteLine(c);
            // }

            #endregion

            #region Ornek Sinav Sistemi

            Console.WriteLine("***** C# Eğitim Kampı Sınav *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("-----------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames=new string[studentCount];
            double[] studentEaxmAvg=new double[studentCount];





            #endregion
            Console.Read();

        }
    }
}
