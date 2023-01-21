using RowerMiejski.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RowerMiejski.Controllers
{
    public class EmployeeController : Controller
    {
        
        public EmployeeController(SqlConnection connection)
        {
            Connection = connection;
        }
        public String getUsername()
        {
            var query = $"SELECT Nazwa FROM pracownik_view_employee";
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
            var query = $"SELECT Imie FROM pracownik_view_employee";
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
        public String getSurnname()
        {
            var query = $"SELECT Nazwisko FROM pracownik_view_employee";
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
        public bool UpdateEmployee(Uzytkownik user, string oldUsername)
        {
            //String usernameToChange = getUsername();
            //var prequery = $"ALTER LOGIN {usernameToChange} WITH NAME = {user.Nazwa}; ALTER USER {usernameToChange} WITH NAME = {user.Nazwa}";
            //Connection.Open();
            //var precmd = new SqlCommand(prequery, Connection);
            //var prereader = precmd.ExecuteScalar();
            //Connection.Close();

            var query = $"UPDATE dbo.pracownik_view_employee " +
                $"SET Nazwa = '{user.Nazwa}', Imie = '{user.Imie}', Nazwisko = '{user.Nazwisko}' " +
                $"WHERE Nazwa = '{oldUsername}'; ";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteScalar();
            Connection.Close();
            return true;
        }

        public void zweryfikujUsterke(int id)
        {
            var query = $"EXEC weryfikuj_usterke @usterka = {id}";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            cmd.ExecuteScalar();
            Connection.Close();
        }

        public void modyfikujDaneStacji(DataGridViewCell selectedCell, int stacja_Id)
        {
            var query =$"";
            if (selectedCell.ColumnIndex == 1)
                query = $"UPDATE Adres SET Ulica = '{selectedCell.Value}' WHERE Id = {stacja_Id}";
            else if(selectedCell.ColumnIndex == 2)
                query = $"UPDATE Adres SET Kod_pocztowy = '{selectedCell.Value}' WHERE Id = {stacja_Id}";
            else if(selectedCell.ColumnIndex == 3)
                query = $"UPDATE Stacja SET Miejsca = {selectedCell.Value} WHERE Id = {stacja_Id}";

            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            cmd.ExecuteScalar();
            Connection.Close();
        }

        public void modyfikujTypRoweru(DataGridViewCell selectedCell, int typRoweru_Id)
        {
            var query = $"";
            String price = selectedCell.Value.ToString();
            price = price.Replace(',', '.');
            //Convert.ToDouble(price);
            if (selectedCell.ColumnIndex == 1)
                query = $"UPDATE Typ_roweru SET Cena_minuta = CAST({price} AS float) WHERE Id = {typRoweru_Id}";
            else if (selectedCell.ColumnIndex == 2)
                query = $"UPDATE Typ_roweru SET Nazwa = '{selectedCell.Value}' WHERE Id = {typRoweru_Id}";

            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            cmd.ExecuteScalar();
            Connection.Close();
        }

        public void usunUsterke(int id)
        {
            var query = $"EXEC usun_usterke @usterka = {id}";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            cmd.ExecuteScalar();
            Connection.Close();
        }

        public void usunRower(int id)
        {
            var query = $"EXEC usun_rower @rower = {id}";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            cmd.ExecuteScalar();
            Connection.Close();
        }

        public void usunKlienta(int id)
        {
            var query = $"EXEC usun_klienta @klient = {id}";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            cmd.ExecuteScalar();
            Connection.Close();
        }
    }
}
