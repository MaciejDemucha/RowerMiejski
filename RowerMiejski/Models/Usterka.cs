using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowerMiejski.Models
{
    class Usterka
    {
        public int Id { get; set; }
        public int IdRower { get; set; }
        public String RowerModel { get; set; }
        public Boolean CzyZweryfikowana { get; set; }

        public Usterka(int id, int idRower, string rowerModel, bool czyZweryfikowana)
        {
            Id = id;
            IdRower = idRower;
            RowerModel = rowerModel;
            CzyZweryfikowana = czyZweryfikowana;
        }
    }
}
