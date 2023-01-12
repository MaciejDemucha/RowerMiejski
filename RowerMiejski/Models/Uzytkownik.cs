using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowerMiejski.Models
{
    public class Uzytkownik
    {
        //public int Id { get; set; }
        public String Nazwa { get; set; }
        public String Imie { get; set; }
        public String Nazwisko { get; set; }
        public int Telefon { get; set; }
        public String Email { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public Double Balans { get; set; }

        public Uzytkownik(/*int id,*/ string nazwa, string imie, string nazwisko, int telefon, String email, DateTime dataUrodzenia, Double balans)
        {
            //Id = id;
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
