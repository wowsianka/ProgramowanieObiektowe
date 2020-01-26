using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public abstract class Osoba : ICloneable
    {
        public String imie;
        public String nazwisko;
        public String email;
        public String telefon;

        public Osoba()
        {

        }

        public Osoba(string imie, string nazwisko, string email, string telefon)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.email = email;
            this.telefon = telefon;
        }

        //klonowanie osoby
        public virtual object Clone()
        {
            return (Osoba)this.MemberwiseClone();
        }

        public override string ToString()
        {
            StringBuilder wynik = new StringBuilder();
            wynik.Append("Imię: " + imie + Environment.NewLine);
            wynik.Append("Nazwisko: " + nazwisko + Environment.NewLine);
            wynik.Append("email: " + email + Environment.NewLine);
            wynik.Append("nr telefonu: " + telefon + Environment.NewLine);
            return wynik.ToString();
        }


    }
}