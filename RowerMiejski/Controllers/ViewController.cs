using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowerMiejski.Controllers
{
    public class ViewController : Controller
    {
        public ViewController(SqlConnection connection)
        {
            Connection = connection;
        }
        public DataTable getListaStacji()
        {
            var query = "EXEC wyswietl_stacje";
            Connection.Open();
            var adapter = new SqlDataAdapter(query, Connection);
            var output = new DataTable();
            adapter.Fill(output);
            Connection.Close();
            return output;
        }

        public DataTable getListaRowerow(int stacjaId)
        {
            var query = $"EXEC	wyswietl_rowery_na_stacji @stacja = {stacjaId}";
            var adapter = new SqlDataAdapter(query, Connection);
            var output = new DataTable();
            adapter.Fill(output);
            return output;
        }

        public DataTable getListaUsterek()
        {
            var query = "EXEC wyswietl_usterki";
            var adapter = new SqlDataAdapter(query, Connection);
            var output = new DataTable();
            adapter.Fill(output);
            return output;
        }
        public DataTable getListaMoichUsterek()
        {
            int pracownik_Id = -1;
            var prequery = $"SELECT Id FROM pracownik_view_employee";
            Connection.Open();
            var precmd = new SqlCommand(prequery, Connection);
            var prereader = precmd.ExecuteReader();
            while (prereader.Read())
            {
                pracownik_Id = prereader.GetInt32(0);
            }
            Connection.Close();


            var query = $"EXEC wyswietl_liste_usterek_dla_pracownika @pracownik = {pracownik_Id}";
            var adapter = new SqlDataAdapter(query, Connection);
            var output = new DataTable();
            adapter.Fill(output);
            return output;
        }

        public DataTable getHistoriaWypozyczen()
        {
            var query = "EXEC wyswietl_moja_historie_wypozyczen";
            var adapter = new SqlDataAdapter(query, Connection);
            var output = new DataTable();
            adapter.Fill(output);
            return output;
        }

        public DataTable getKlienci()
        {
            var query = "SELECT * FROM Klient";
            var adapter = new SqlDataAdapter(query, Connection);
            var output = new DataTable();
            adapter.Fill(output);
            return output;
        }

        public DataTable getWypozyczeniaKlienta(int Id)
        {
            var query = $"SELECT * FROM Wypożyczenie WHERE Klient_Id = {Id}";
            var adapter = new SqlDataAdapter(query, Connection);
            var output = new DataTable();
            adapter.Fill(output);
            return output;
        }
        public DataTable getTypy()
        {
            var query = $"SELECT * FROM Typ_roweru";
            var adapter = new SqlDataAdapter(query, Connection);
            var output = new DataTable();
            adapter.Fill(output);
            return output;
        }
    }
}
