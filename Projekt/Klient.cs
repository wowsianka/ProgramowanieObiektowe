using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Klient : Osoba
    {
        private static int liczbaKlientów = 0;

        private int clientID;

        public Klient(string imie, string nazwisko, string email, string telefon) : base(imie,nazwisko,email,telefon)
        {
            this.clientID = liczbaKlientów++;
        }
    }
}
