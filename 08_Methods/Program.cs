using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Methods

            //()
            //Geriye Değer Döndürmeyen Methodlar
            //Customer --> Listele, ekle, sil, güncelle
            //Void


            //void CustomerList()
            //{
            //    Console.WriteLine("Ali YILDIZ");
            //    Console.WriteLine("Ayşe YILDIZ");
            //    Console.WriteLine("Hakan ÖZTÜRK");
            //    Console.WriteLine("Merve ÇINAR");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}


            //Sum();



            #endregion


            #region Geriye Değer Döndürmeyen Parametreli Methodlar

            void WriteMethod(string customerName)
            {
                Console.WriteLine(customerName);
            }



            #endregion
            Console.Read();

        }
    }
}
