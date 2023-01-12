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
    public class UserController : Controller
    {
        
        public UserController(SqlConnection connection)
        {
            Connection = connection;
        }

        public void doladuj(Double kwota)
        {
            var query = $"EXEC zaktualizuj_bilans @kwota = {kwota}";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            cmd.ExecuteScalar();
            Connection.Close();
        }

        public void wypozyczRower(int id)
        {
            var query = $"EXEC wypozycz_rower @rower = {id}";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            cmd.ExecuteScalar();
            Connection.Close();
        }

        public void zglosUsterke(int id)
        {
            var query = $"EXEC zglos_usterke @rower = {id}";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            cmd.ExecuteScalar();
            Connection.Close();
        }

        public void zwrocRower(int idRower, int idStacja)
        {
            var query = $"EXEC zwroc_rower @rower = {idRower}, @stacja = {idStacja}";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            cmd.ExecuteScalar();
            Connection.Close();
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
