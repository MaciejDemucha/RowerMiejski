using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowerMiejski.Models
{
    class Uzytkownik
    {
        public int Id { get; set; }
        public String Nazwa { get; set; }
        public String Imie { get; set; }
        public String Nazwisko { get; set; }
        public int Telefon { get; set; }
        public int Email { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public float Balans { get; set; }

        public Uzytkownik(int id, string nazwa, string imie, string nazwisko, int telefon, int email, DateTime dataUrodzenia, float balans)
        {
            Id = id;
            Nazwa = nazwa;
            Imie = imie;
            Nazwisko = nazwisko;
            Telefon = telefon;
            Email = email;
            DataUrodzenia = dataUrodzenia;
            Balans = balans;
        }
    }
}
