using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjektIT4_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var RegfistrationForm = new RegistrationForm();
            RegfistrationForm.Show();


        }


        public static bool AuthenticateUser(string name, string password)
        {
            // připojení k databázi
            using (SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DatabaseLOL; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                conn.Open();

                // získání uživatele z databáze podle jména
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE name = @name", conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // získání uloženého hesla a soli z databáze
                            byte[] savedSalt = Convert.FromBase64String(reader.GetString(reader.GetOrdinal("passwordsalt")));
                            byte[] savedPasswordHash = Convert.FromBase64String(reader.GetString(reader.GetOrdinal("passwordhash")));

                            // vytvoření hashu ze vstupního hesla a soli
                            byte[] passwordHash;

                            using (var sha512 = SHA512.Create())
                            {
                                passwordHash = sha512.ComputeHash(Encoding.UTF8.GetBytes(password).Concat(savedSalt).ToArray());
                            }

                            // porovnání hashů
                            return savedPasswordHash.SequenceEqual(passwordHash);
                        }
                        else
                        {
                            // uživatel nebyl nalezen v databázi
                            return false;
                        }
                    }
                }
            }
        }


        private void loginbutton_Click_1(object sender, EventArgs e)
        {
            string name = nametextBox.Text;
            string password = passwordtextBox.Text;

            if (AuthenticateUser(name, password))
            {
                // úspěšné přihlášení
                MessageBox.Show("Přihlášení proběhlo úspěšně.");
            }
            else
            {
                // neúspěšné přihlášení
                MessageBox.Show("Nesprávné přihlašovací údaje.");
            }
        }
    }
}
