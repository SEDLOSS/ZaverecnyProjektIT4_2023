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
                users.Add(new User(reader.GetInt32(0), reader.GetString(1), (byte[])reader[2], (byte[])reader[3], reader.GetInt32(4)));
            }
            reader.Close();
            conn.Close();
            return users;
        }

        public static List<Employee> EmployeeList()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Employees";
            SqlDataReader reader = cmd.ExecuteReader();
            List<Employee> employee = new List<Employee>();
            while (reader.Read())
            {
                employee.Add(new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4), reader.GetInt32(5)));
            }
            reader.Close();
            conn.Close();
            return employee;
        }

        public static void DeleteEmployeebyId(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Employees WHERE Id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void AddEmployee(Employee employee)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Employees (FirstName, LastName, BirthDate, Email, PhoneNumber) VALUES (@firstname, @lastname, @birthdate, @email, @phonenumber)";
            cmd.Parameters.AddWithValue("firstname", employee.FirstName);
            cmd.Parameters.AddWithValue("lastname", employee.LastName);
            cmd.Parameters.AddWithValue("birthdate", employee.BirthDate);
            cmd.Parameters.AddWithValue("email", employee.Email);
            cmd.Parameters.AddWithValue("phonenumber", employee.PhoneNumber);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void EditEmployee(int id, Employee employee)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Employees SET FirstName=@firstname, LastName=@lastname, BirthDate=@birthdate, Email=@email, PhoneNumber=@phonenumber WHERE id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("firstname", employee.FirstName);
            cmd.Parameters.AddWithValue("lastname", employee.LastName);
            cmd.Parameters.AddWithValue("birthdate", employee.BirthDate);
            cmd.Parameters.AddWithValue("email", employee.Email);
            cmd.Parameters.AddWithValue("phonenumber", employee.PhoneNumber);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static List<Contract> ContractList()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Contract";
            SqlDataReader reader = cmd.ExecuteReader();
            List<Contract> contracts = new List<Contract>();
            while (reader.Read())
            {
                contracts.Add(new Contract(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
            }
            reader.Close();
            conn.Close();
            return contracts;
        }

        public static void AddContract(Contract contract)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Contract (Customer, Description) VALUES (@customer, @description)";
            cmd.Parameters.AddWithValue("customer", contract.Customer);
            cmd.Parameters.AddWithValue("description", contract.Description);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void EditContract(int id, Contract contract)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Contract SET Customer=@customer, Description=@description WHERE id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("customer", contract.Customer);
            cmd.Parameters.AddWithValue("description", contract.Description);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void DeleteContractbyId(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Contract WHERE Id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static List<WorkType> WorktypeList()

        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Worktypes";
            SqlDataReader reader = cmd.ExecuteReader();
            List<WorkType> worktype = new List<WorkType>();
            while (reader.Read())
            {
                worktype.Add(new WorkType(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
            }
            reader.Close();
            conn.Close();
            return worktype;
        }

        public static void AddWorktype(WorkType worktype)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Worktypes (Name, Description) VALUES (@name, @description)";
            cmd.Parameters.AddWithValue("name", worktype.Name);
            cmd.Parameters.AddWithValue("description", worktype.Description);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void EditWorktype(int id, WorkType worktype)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Worktypes SET Name=@name, Description=@description WHERE id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name", worktype.Name);
            cmd.Parameters.AddWithValue("description", worktype.Description);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void DeleteWorktypebyId(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Worktypes WHERE Id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
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

        public static void AddContract(int contractNumber, string Customer, string Description)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO contracts (ContractNumber, Customer, Description) VALUES (@ContractNumber, @Customer, @Description)";
            cmd.Parameters.AddWithValue("ContractNumber", contractNumber);
            cmd.Parameters.AddWithValue("Customer", Customer); ;
            cmd.Parameters.AddWithValue("Description", Description);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static Contract GetContractByNumber(int contractNumber)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM contracts WHERE ContractNumber = @ContractNumber";
            cmd.Parameters.AddWithValue("ContractNumber", contractNumber);
            SqlDataReader reader = cmd.ExecuteReader();
            Contract contract = null;
            if (reader.Read())
            {
                contract = new Contract(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            }
            reader.Close();
            conn.Close();
            return contract;
        }

        public static List<Contract> GetContractsByUser(int iD)
        {
            List<Contract> contracts = new List<Contract>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Contracts c INNER JOIN iD ON c.ContractNumber = iD WHERE iD = @iD";
            cmd.Parameters.AddWithValue("iD", iD);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                contracts.Add(new Contract(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
            }
            reader.Close();
            conn.Close();
            return contracts;
        }

        public static void DeleteContractsFromActualDay(int contractNumber)
        {
            DateTime now = DateTime.Now;
            DateTime startOfToday = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            DateTime endOfToday = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM contracts WHERE ContractNumber = @ContractNumber AND CreatedDate BETWEEN @StartOfToday AND @EndOfToday";
            cmd.Parameters.AddWithValue("contractNumber", contractNumber);
            cmd.Parameters.AddWithValue("StartOfToday", startOfToday);
            cmd.Parameters.AddWithValue("EndOfToday", endOfToday);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static List<Contract> GetContractsOrderedByCreatedDay()
        {
            List<Contract> contracts = new List<Contract>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Contracts ORDER BY CreatedDate";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                contracts.Add(new Contract(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
            }
            reader.Close();
            conn.Close();
            return contracts;
        }



    }
}