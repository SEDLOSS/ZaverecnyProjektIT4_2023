using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ZaverecnyProjektIT4_2023.classes;

namespace ZaverecnyProjektIT4_2023
{
    public class SqlRepository
    {

        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DatabaseLOL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static List<User> GatherAllUsers()
        {
            List<User> users = new List<User>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM users";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new User(reader.GetInt32(0), reader.GetString(1), (byte[])reader[2], (byte[])reader[3]));
            }
            reader.Close();
            conn.Close();
            return users;
        }

        public static void RegisterUser(string name, string password)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            HMACSHA512 hmac = new HMACSHA512();
            cmd.CommandText = "INSERT INTO users (name,passwordhash,passwordsalt) VALUES (@name,@hash,@salt)";
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("hash", hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));
            cmd.Parameters.AddWithValue("salt", hmac.Key);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void DeleteUser(int iD)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM users WHERE iD = @iD";
            cmd.Parameters.AddWithValue("iD", iD);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void UpdateUser(string iD, string password)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            HMACSHA512 hmac = new HMACSHA512();
            cmd.CommandText = "UPDATE users SET passwordhash=@hash, passwordsalt=@salt WHERE iD=@iD";
            cmd.Parameters.AddWithValue("iD", iD);
            cmd.Parameters.AddWithValue("hash", hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));
            cmd.Parameters.AddWithValue("salt", hmac.Key);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void AddRole(string roleName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO roles (roleName) VALUES (@roleName)", conn);
                cmd.Parameters.AddWithValue("@roleName", roleName);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Role added successfully.");
                }
                else
                {
                    Console.WriteLine("Role could not be added.");
                }
            }
        }



    }
}
