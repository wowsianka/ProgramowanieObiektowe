using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Pracownik : Osoba
    {
        private int pracownikID;
        private String stanowisko;
        private String numerKonta;
        private String pesel;

        public Pracownik(string imie, string nazwisko, string email, string telefon,int pracownikID, 
                         string stanowisko, string numerKonta, string pesel) : base(imie,nazwisko,email,telefon)
        {
            this.PracownikID = pracownikID;
            this.stanowisko = stanowisko;
            this.numerKonta = numerKonta;
            this.pesel = pesel;
        }

        public int PracownikID { get => pracownikID; set => pracownikID = value; }
    }
}
