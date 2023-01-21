using RowerMiejski.Models;
using RowerMiejski.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
            var prequery = $"SELECT COUNT(*) from klient_view_wypozyczenie WHERE klient_view_wypozyczenie.[Koniec wypożyczenia] is NULL";
            Connection.Open();
            var precmd = new SqlCommand(prequery, Connection);
            var prereader = precmd.ExecuteReader();
            int output = -1;
            while (prereader.Read())
            {
                output = prereader.GetInt32(0);
            }
            Connection.Close();

            if (output >= 1)
                MessageBox.Show("Nie można wypożyczyć więcej niż jeden rower!");
            else
            {
                var query = $"EXEC wypozycz_rower @rower = {id}";
                Connection.Open();
                var cmd = new SqlCommand(query, Connection);
                cmd.ExecuteScalar();
                Connection.Close();
            }
        }

        public void zglosUsterke(int id)
        {
            var query = $"EXEC zglos_usterke @rower = {id}";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            cmd.ExecuteScalar();
            Connection.Close();
        }

        public void zwrocRower(int idStacja)
        {
            var prequery = $"SELECT Rower_Id FROM klient_view_wypozyczenie WHERE klient_view_wypozyczenie.[Koniec wypożyczenia] is NULL and klient_view_wypozyczenie.[Start wypożyczenia] IS NOT NULL AND klient_view_wypozyczenie.Klient_id = (SELECT Klient_Id FROM klient_view_customer)";
            Connection.Open();
            var precmd = new SqlCommand(prequery, Connection);
            var prereader = precmd.ExecuteReader();
            int output = -1;
            while (prereader.Read())
            {
                output = prereader.GetInt32(0);
            }
            Connection.Close();

            var query = $"EXEC zwroc_rower @rower = {output}, @stacja = {idStacja}";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            cmd.ExecuteScalar();
            Connection.Close();
        }

        public String czyWypozyczony()
        {
            var query = $"SELECT Model FROM klient_view_wypozyczenie WHERE [Koniec wypożyczenia] IS NULL";
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

        public Double getKosztWypozyczenia()
        {
            var query = $"SELECT Cena_minuta FROM Typ_roweru WHERE Id = (SELECT Typ_roweru_Id From Rower " +
                $"WHERE Rower.Id = (SELECT Rower_Id FROM klient_view_wypozyczenie WHERE [Koniec wypożyczenia] IS NULL))";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            Double output = 0.0;
            while (reader.Read())
            {
                output = reader.GetDouble(0);
            }
            Connection.Close();
            return output;
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

        public String getWypozyczonyRower()
        {
            var query1 = "SELECT Nazwa FROM klient_view_customer";
            Connection.Open();

            var cmd1 = new SqlCommand(query1, Connection);
            var reader1 = cmd1.ExecuteReader();
            String output1 = "";
            while (reader1.Read())
            {
                output1 = reader1.GetString(0);
            }
            Connection.Close();

            Connection.Open();

            var query2 = $"SELECT Model FROM klient_view_wypozyczenie WHERE [Start wypożyczenia] IS NOT NULL and [Koniec wypożyczenia] IS NULL;";

            var cmd2 = new SqlCommand(query2, Connection);
            var reader2 = cmd2.ExecuteReader();
            String output2 = "";
            while (reader2.Read())
            {
                output2 = reader2.GetString(0);
            }
            Connection.Close();
            return output2;
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

        public bool UpdateUzytkownik(Uzytkownik user, string oldUsername)
        {
            //String usernameToChange = getUsername();
            //var prequery = $"ALTER LOGIN {usernameToChange} WITH NAME = {user.Nazwa}; ALTER USER {usernameToChange} WITH NAME = {user.Nazwa}";
            //Connection.Open();
            //var precmd = new SqlCommand(prequery, Connection);
            //var prereader = precmd.ExecuteScalar();
            //Connection.Close();

            var query = $"UPDATE dbo.klient_view_customer " +
                $"SET Nazwa = '{user.Nazwa}', Imie = '{user.Imie}', Nazwisko = '{user.Nazwisko}', Telefon = '{user.Telefon}', " +
                $"Email = '{user.Email}', Data_urodzenia = '{user.DataUrodzenia}' " +
                $"WHERE Nazwa = '{oldUsername}'; ";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteScalar();
            Connection.Close();
            return true;
        }

    }
}
