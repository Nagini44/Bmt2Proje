using Microsoft.Data.SqlClient;
using Yeniden.Models;
using System;

namespace Yeniden.Repositories
{

    public class Repos
    {
        private readonly string connectionString = "Data Source=NAGINI\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public List<Client> GetClients()
        { 
            var clients = new List<Client>();

            try 
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM library ORDER BY BookID Desc ";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Client client = new Client();
                                client.BookID = reader.GetInt32(0);
                                client.BookName = reader.GetString(1);
                                client.Yazar = reader.GetString(2);
                                client.Kategori = reader.GetString(3);
                                client.Yayıncı = reader.GetString(4);
                                client.ISBN = reader.GetString(5);
                                client.Available = reader.GetBoolean(6);

                                clients.Add(client);

                            }
                        }
                    }

                }       
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());   
            }
            return clients;
        }
        public Client? GetClient(int BookID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM library WHERE BookID=@BookID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", BookID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                Client client = new Client();
                                client.BookID = reader.GetInt32(0);
                                client.BookName = reader.GetString(1);
                                client.Yazar = reader.GetString(2);
                                client.Kategori = reader.GetString(3);
                                client.Yayıncı = reader.GetString(4);
                                client.ISBN = reader.GetString(5);
                                client.Available = reader.GetBoolean(6);

                                return client;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
            return null;
        }
        public void CreateClient(Client client)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Library" +
                        "(BookName,Yazar,Kategori,Yayıncı,ISBN,Available) VALUES" +
                        "(@BookName,@Yazar,@Kategori,@Yayıncı,@ISBN,@Available);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@BookName", client.BookName);
                        command.Parameters.AddWithValue("@Yazar", client.Yazar);
                        command.Parameters.AddWithValue("@Kategori", client.Kategori);
                        command.Parameters.AddWithValue("@Yayıncı", client.Yayıncı);
                        command.Parameters.AddWithValue("@ISBN", client.ISBN);
                        command.Parameters.AddWithValue("@Available", client.Available);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
        public void UpdateClient(Client client )
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Library " +
                                 "SET BookName=@BookName, Yazar=@Yazar ,Kategori=@Kategori, Yayıncı=@Yayıncı, ISBN=@ISBN  " +                                
                                 "WHERE BookID=@BookID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@BookName", client.BookName);
                        command.Parameters.AddWithValue("@Yazar", client.Yazar);
                        command.Parameters.AddWithValue("@Kategori", client.Kategori);
                        command.Parameters.AddWithValue("@Yayıncı", client.Yayıncı);
                        command.Parameters.AddWithValue("@ISBN", client.ISBN);

                        command.Parameters.AddWithValue("@BookID", client.ISBN);



                        command.ExecuteNonQuery();
                    }
                }   
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void DeleteClient(int BookID)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM Library WHERE BookID=@BookID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", BookID);

                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.ToString());
            }
        }
    }

}


