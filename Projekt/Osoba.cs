using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    abstract class Osoba
    {
        private String imie;
        private String nazwisko;
        private String email;
        private String telefon;

        protected Osoba(string imie, string nazwisko, string email, string telefon)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.email = email;
            this.telefon = telefon;
        }
    }
}
