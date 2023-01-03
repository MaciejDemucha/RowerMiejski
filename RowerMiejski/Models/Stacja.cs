using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowerMiejski.Models
{
    class Stacja
    {
        public int Id { get; set; }
        public int Miejsca { get; set; }
        public int Rowery { get; set; }
        public String Ulica { get; set; }
        public String KodPocztowy { get; set; }

        public Stacja(int id, int miejsca, int rowery, String ulica, String kodPocztowy)
        {
            Id = id;
            Miejsca = miejsca;
            Rowery = rowery;
            Ulica = ulica;
            KodPocztowy = kodPocztowy;

        }

    }
}
