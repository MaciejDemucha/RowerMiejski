using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowerMiejski.Models
{
    class Wypozyczenie
    {
        public int Id { get; set; }
        public String RowerModel { get; set; }
        public DateTime DataWypozyczenia { get; set; }
        public DateTime DataOddania { get; set; }
        public float Oplata { get; set; }
        public Boolean Status { get; set; }

        public Wypozyczenie(int id, string rowerModel, DateTime dataWypozyczenia, DateTime dataOddania, float oplata, bool status)
        {
            Id = id;
            RowerModel = rowerModel;
            DataWypozyczenia = dataWypozyczenia;
            DataOddania = dataOddania;
            Oplata = oplata;
            Status = status;
        }
    }
}
