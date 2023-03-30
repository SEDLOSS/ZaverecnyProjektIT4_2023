using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjektIT4_2023
{
    public partial class FormEmployeeAdd : Form
    {
        public FormEmployeeAdd()
        {
            InitializeComponent();
        }


        //public void RegisterUser(string name, string password)
        //{
        //    // Náhodně generujeme sůl
        //    byte[] salt = new byte[32];
        //    using (var rng = new RNGCryptoServiceProvider())
        //    {
        //        rng.GetBytes(salt);
        //    }

        //    // Hašujeme heslo a přidáváme sůl
        //    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
        //    byte[] saltedPasswordBytes = new byte[passwordBytes.Length + salt.Length];
        //    Array.Copy(passwordBytes, saltedPasswordBytes, passwordBytes.Length);
        //    Array.Copy(salt, 0, saltedPasswordBytes, passwordBytes.Length, salt.Length);

        //    byte[] hashedPasswordBytes;
        //    using (var sha512 = SHA512.Create())
        //    {
        //        hashedPasswordBytes = sha512.ComputeHash(saltedPasswordBytes);
        //    }

        //    // Ukládáme uživatele do databáze
        //    using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DatabaseLOL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
        //    {
        //        connection.Open();
        //        SqlCommand cmd = connection.CreateCommand();
        //        using (var command = connection.CreateCommand())
        //        {
        //            HMACSHA512 hmac = new HMACSHA512();
        //            cmd.CommandText = "INSERT INTO users (id, name, passwordhash, passwordsalt) VALUES (@id, @name, @hash, @salt)";
        //            cmd.Parameters.AddWithValue("name", name);
        //            cmd.Parameters.AddWithValue("hash", hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));
        //            cmd.Parameters.AddWithValue("salt", hmac.Key);
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}



        private void registerButton_Click(object sender, EventArgs e)
        {
            string name = Nametxt.Text;
            string password = Name1txt.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
