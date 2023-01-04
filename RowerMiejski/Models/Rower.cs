using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowerMiejski.Models
{
    class Rower
    {
        public int Id { get; set; }
        public String TypRoweru { get; set; }
        public String Model { get; set; }
        public Boolean CzyFunkcjonalny { get; set; }
        public float CenaZaMinute { get; set; }

        public Rower(int id, string typRoweru, string model, bool czyFunkcjonalny, float cenaZaMinute)
        {
            Id = id;
            TypRoweru = typRoweru;
            Model = model;
            CzyFunkcjonalny = czyFunkcjonalny;
            CenaZaMinute = cenaZaMinute;
        }
    }
}
