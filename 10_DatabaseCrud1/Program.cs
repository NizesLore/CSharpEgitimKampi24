using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud--> Create-Read-Update-Delete


            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();


            Console.WriteLine("---------------------------");

            #region Ürün Ekleme İslemi*
            //Console.WriteLine("Eklemek İstediğiniz Ürün Adı: ");
            //string productName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; initial Catalog = EgitimKampiDb; integrated security = true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (productName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün başarıyla eklendi!");

            #endregion


            #region Ürün Birden Çok Özellikli Ekleme işlemi

            string productName;
            decimal productPrice;
            //bool productStatus;

            Console.Write("Ürün Adı: ");
            productName = Console.ReadLine();
            Console.Write("Ürün Fiyatı: ");
            productPrice=decimal.Parse(Console.ReadLine());
            
            SqlConnection connection = new SqlConnection("Data source=(localdb)\\MSSQLLocalDB; initial catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice,ProdutStatus) valaues (@productName,@productPrice,@productStatus)", connection);
           command.




            #endregion
            Console.Read();







        }
    }
}