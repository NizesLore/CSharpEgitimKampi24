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


            Console.Read();
        }
    }
}
