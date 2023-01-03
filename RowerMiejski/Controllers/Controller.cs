using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowerMiejski.Controllers
{
    public abstract class Controller
    {
        protected readonly SqlConnection Connection = new(Properties.Resources.ConnectionString);
    }
}
