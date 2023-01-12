using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowerMiejski.Controllers
{
    public class EmployeeController : Controller
    {
        
        public EmployeeController(SqlConnection connection)
        {
            Connection = connection;
        }

        public void zweryfikujUsterke(int id)
        {
            var query = $"EXEC weryfikuj_usterke @usterka = {id}";
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
