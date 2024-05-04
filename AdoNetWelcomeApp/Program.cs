using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Claims;

string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Pooling=True";
string connectionString2 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=tempdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Pooling=True";

/*
DataSource / Server - имя сервера, источника данных
Initial Catalog / Database - имя базы данных

Integrated Security / Trusted_Connection - подключение по учтке Windows

User_ID - логин SQL Server
Password - пароль логина SQL Server

Connect Timeout - время ожидания подключения
*/

//SqlConnection connection = new SqlConnection(connectionString);

//try
//{
//    await connection.OpenAsync();
//    Console.WriteLine("Connection is open");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    if(connection.State == ConnectionState.Open)
//    {
//        await connection.CloseAsync();
//        Console.WriteLine("Connection is close");
//    }
//}

using (SqlConnection connection = new SqlConnection(connectionString))
{
    await connection.OpenAsync();
    Console.WriteLine("Connection is open");

    //Console.WriteLine(new String('*', 30));
    //Console.WriteLine("Property of connection:");
    //Console.WriteLine($"Connection string: {connection.ConnectionString}");
    //Console.WriteLine($"Database: {connection.Database}");
    //Console.WriteLine($"Server: {connection.DataSource}");
    //Console.WriteLine($"Version of server: {connection.ServerVersion}");
    //Console.WriteLine($"State of connection: {connection.State}");
    //Console.WriteLine($"Workstation ID: {connection.WorkstationId}");
    //Console.WriteLine(new String('*', 30));

    Console.WriteLine($"Id connection: {connection.ClientConnectionId}");
}


using (SqlConnection connection = new SqlConnection(connectionString2))
{
    await connection.OpenAsync();
    Console.WriteLine("Connection is open");
    Console.WriteLine($"Id connection: {connection.ClientConnectionId}");
}

using (SqlConnection connection = new SqlConnection(connectionString))
{
    await connection.OpenAsync();
    Console.WriteLine("Connection is open");
    Console.WriteLine($"Id connection: {connection.ClientConnectionId}");
}



Console.WriteLine("Connection is close");
Console.WriteLine("Application finished");