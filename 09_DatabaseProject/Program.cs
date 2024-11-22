using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string tableNumber;
            Console.WriteLine("-----------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber=Console.ReadLine();
            Console.WriteLine("-----------------------");

            //SqlConnection connection = new SqlConnection(tableNumber);
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory");
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable =new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
                Console.WriteLine("..");
            }

            SqlCommand command = new SqlCommand("Select * From TblCategory");



            //Crud--> Create-Read-Update-Delete
            Console.WriteLine("***** Menü Sipariş İşlem Paneli");
            Console.WriteLine();


            Console.WriteLine("---------------------------");
            Console.WriteLine("Eklemek İstediğiniz Kategori Adı: ");
            string categoryName =Console.ReadLine();


            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R7AR1ND;initial " +
                "catalog=EgitimKampiDb;integrated security=treu");

            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            command.Parameters.AddWithValue("@p1",categoryName);
            command.ExecuteNonQuery();
            connection.Close();

            Console.Read();
        }
    }
}
