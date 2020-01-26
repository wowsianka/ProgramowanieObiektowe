using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Pracownik : Osoba
    {
        public int pracownikID;
        private String stanowisko;
        private String numerKonta;
        private String pesel;

        public Pracownik()
        {

        }
        public Pracownik(string imie, string nazwisko, string email, string telefon, int pracownikID,
                         string stanowisko, string numerKonta, string pesel) : base(imie, nazwisko, email, telefon)
        {
            this.PracownikID = pracownikID;
            this.stanowisko = stanowisko;
            this.numerKonta = numerKonta;
            this.pesel = pesel;
        }

        public int PracownikID { get => pracownikID; set => pracownikID = value; }

        public override string ToString()
        {
            StringBuilder wynik = new StringBuilder();
            wynik.Append(" Id Pracownika: " + pracownikID + Environment.NewLine);
            wynik.Append("stanowisko: " + stanowisko + Environment.NewLine);
            wynik.Append("numer konta: " + numerKonta + Environment.NewLine);
            wynik.Append(" pesel: " + pesel + Environment.NewLine);
            return wynik.ToString() + base.ToString();
        }

    }
}