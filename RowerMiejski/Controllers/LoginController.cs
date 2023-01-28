using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace RowerMiejski.Controllers
{
    class LoginController : Controller
    {
        public void login(String username, string password)
        {
            String conn = $@"Server=LAPTOP-S2A0N94M\DEMUCHASQL;Database=RowerMiejski;Trusted_Connection=false;User Id={username};Password={password};";
            Connection = new SqlConnection(conn);
            string getid = "SELECT username FROM user WHERE username='" + username + "' AND password='" + password + "'";
            
        }
        public void register(String username, string password, string name, string surname, int phone, string email, DateTime datebirth, double balance)
        {
            String conn = $@"Server=LAPTOP-S2A0N94M\DEMUCHASQL;Database=RowerMiejski;Trusted_Connection=true";
            Connection = new SqlConnection(conn);

            var query1 = $"CREATE LOGIN {username} WITH PASSWORD = '{password}'";
            var query2 = $"CREATE USER [{username}] FOR LOGIN [{username}] WITH DEFAULT_SCHEMA=[dbo]";
            var query3 = $"ALTER ROLE[Klient] ADD MEMBER[{username}]";
            var queryaddklient = $"INSERT INTO Klient VALUES ('{username}', '{name}', '{surname}', {phone}, '{email}', '{datebirth}', {balance})";

            Connection.Open();

            var cmd1 = new SqlCommand(query1, Connection);
            cmd1.ExecuteScalar();
            var cmd2 = new SqlCommand(query2, Connection);
            cmd2.ExecuteScalar();
            var cmd3 = new SqlCommand(query3, Connection);
            cmd3.ExecuteScalar();
            var cmd4 = new SqlCommand(queryaddklient, Connection);
            cmd4.ExecuteScalar();

            Connection.Close();

            MessageBox.Show("Pomyślnie zarejestrowano użytkownika!");
        }

    }
}
