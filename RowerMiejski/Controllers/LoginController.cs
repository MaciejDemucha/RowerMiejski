using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowerMiejski.Controllers
{
    class LoginController : Controller
    {
        public void login(String username, string password)
        {
            String conn = $@"Server=LAPTOP-S2A0N94M\DEMUCHASQL;Database=RowerMiejski;Uid='{username}';Pwd='{password}';";
            Connection = new SqlConnection(conn);
        }

    }
}
