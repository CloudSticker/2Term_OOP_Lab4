using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Threading;


namespace _2Term_OOP_Lab4
{
    class SQL_connection
    {
        static async Task Main(string[] args)
        {
            string connectionString = "Server=tcp:daniilda.database.windows.net,1433;Initial Catalog=oop_lab;Persist Security Info=False;User ID=daniilda;Password=16010105Dan;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; ";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                await connection.OpenAsync();
                Console.WriteLine("Подключение открыто");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // если подключение открыто
                if (connection.State == ConnectionState.Open)
                {
                    // закрываем подключение
                    connection.Close();
                    Console.WriteLine("Подключение закрыто...");
                }
            }
            Console.WriteLine("Программа завершила работу.");
            Console.Read();
        }
    }
}
