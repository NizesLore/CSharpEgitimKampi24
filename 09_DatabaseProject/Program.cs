using System;
using System.Collections.Generic;
using System.Data;
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
            tableNumber = Console.ReadLine();
            Console.WriteLine("-----------------------");

            //SqlConnection connection = new SqlConnection(tableNumber);
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory");
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
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

            #region Kategori Ekleme İslemi
            //Console.WriteLine("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName =Console.ReadLine();


            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R7AR1ND;initial " +
            //    "catalog=EgitimKampiDb;integrated security=treu");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi");
            #endregion

            #region Urun Ekleme İslemi

            string productName;
            decimal productPrice;
            //bool productStatus;

            Console.WriteLine("Ürün Adı:      ");
            productName = Console.ReadLine();
            Console.Write("Ürün Fiyatı: ");
            productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data source=DESKTOP-R7AR1ND;initial " +
                "catalog=EgitimKampiDb;integrated security=true");

            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values 
                (@productName, @productPrice, @productStatus)",connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productStatus", true);
            command.ExecuteNonQuery();
            connection.Close();
            Console.Write("Ürün eklemesi başarılı! ");



            #endregion

            #region Urun Listeleme Islemi

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-R7AR1ND;initial " +
            //    "catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}


            //connection.Close();


            #endregion

            #region Urun Silme İslemi

            //Console.WriteLine("Silinecek Urun Id: ");
            //int productId = int.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-R7AR1ND;initial " +
            //"catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();


            //connection.Close();


            //Console.WriteLine("Silme işlemi yapıldı!");


            #endregion

            #region Urun Guncelleme Islemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());



            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-R7AR1ND;initial " +
            //    "Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice" +
            //    "where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme başarılı! ");
            #endregion



            Console.WriteLine();

            Console.Read();
        }
    }
}
