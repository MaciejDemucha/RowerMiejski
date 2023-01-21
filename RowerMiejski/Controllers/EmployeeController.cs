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
