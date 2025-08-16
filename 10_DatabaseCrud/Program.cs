using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crud--> Create-Read-Update-Delete
           

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();


            Console.WriteLine("---------------------------");

            #region Kategori Ekleme İslemi*
            Console.WriteLine("Eklemek İstediğiniz Kategori Adı: ");
            string categoryName = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; initial Catalog = EgitimKampiDb; integrated security = true");

            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            command.Parameters.AddWithValue("@p1", categoryName);
            command.ExecuteNonQuery();
            connection.Close();

            Console.Write("Kategori başarıyla eklendi!");
            Console.Read();




        }
    }
}