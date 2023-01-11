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
        public ViewController(String connectionString)
        {
            Connection = new SqlConnection(connectionString);
        }
        public DataTable getListaStacji()
        {
            var query = "EXEC wyswietl_stacje";
            var adapter = new SqlDataAdapter(query, Connection);
            var output = new DataTable();
            adapter.Fill(output);
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

        public DataTable getHistoriaWypozyczen()
        {
            var query = "EXEC wyswietl_moja_historie_wypozyczen";
            var adapter = new SqlDataAdapter(query, Connection);
            var output = new DataTable();
            adapter.Fill(output);
            return output;
        }
    }
}
