using RowerMiejski.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowerMiejski.Controllers
{
    class UserController : Controller
    {
        
        public UserController(SqlConnection connection)
        {
            Connection = connection;
        }

        public Double getBalans()
        {
            var query = "EXEC wyswietl_dane";
            Connection.Open();

            var cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            Double output = 0.0;
            while (reader.Read())
            {
                output = Math.Round(reader.GetDouble(6), 2);
            }
                Connection.Close();
            return output;
        }
     

        public int GetUzytkownikId(string username)
        {
            var query = $"SELECT Id FROM Klient WHERE Nazwa='{username}';";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            var output = (int)cmd.ExecuteScalar();
            Connection.Close();
            return output;
        }

        public String getUsername()
        {
            var query = "EXEC wyswietl_dane";
            Connection.Open();

            var cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            String output = "";
            while (reader.Read())
            {
                output = reader.GetString(0);
            }
            Connection.Close();
            return output;
        }

        public String getName()
        {
            var query = "EXEC wyswietl_dane";
            Connection.Open();

            var cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            String output = "";
            while (reader.Read())
            {
                output = reader.GetString(1);
            }
            Connection.Close();
            return output;
        }

        public String getSurname()
        {
            var query = "EXEC wyswietl_dane";
            Connection.Open();

            var cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            String output = "";
            while (reader.Read())
            {
                output = reader.GetString(2);
            }
            Connection.Close();
            return output;
        }

        public int getPhone()
        {
            var query = "EXEC wyswietl_dane";
            Connection.Open();

            var cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            int output = 0;
            while (reader.Read())
            {
                if (!reader.IsDBNull(3))
                    output = reader.GetInt32(3);
            }
            Connection.Close();
            return output;
        }

        public String getEmail()
        {
            var query = "EXEC wyswietl_dane";
            Connection.Open();

            var cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            String output = "";
            while (reader.Read())
            {
                if (!reader.IsDBNull(4))
                    output = reader.GetString(4);
            }
            Connection.Close();
            return output;
        }

        public DateTime getBirthDate()
        {
            var query = "EXEC wyswietl_dane";
            Connection.Open();

            var cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DateTime output = new DateTime();
            while (reader.Read())
            {
                if (!reader.IsDBNull(5))
                    output = reader.GetDateTime(5);
            }
            Connection.Close();
            return output;
        }

        public bool UpdateUzytkownik(Uzytkownik user)
        {
            return true;
        }

    }
}
