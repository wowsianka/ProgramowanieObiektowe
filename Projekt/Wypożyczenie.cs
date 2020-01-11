using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Wypożyczenie
    {
        private DateTime dataWypożyczenia;
        private KopiaFilmu kopia;
        private Klient klient;
        private double cenaZaDzień;
        private int idpracownika;

        public Wypożyczenie(KopiaFilmu kopia, Klient klient, Pracownik pracownik)
        {
            this.kopia = kopia;
            this.klient = klient;
            this.dataWypożyczenia = DateTime.Now;
            this.cenaZaDzień = Cennik.cenaDniaFilmu(kopia.Film);
            this.idpracownika = pracownik.PracownikID;
        }


        public double oddajFilm()
        {
            this.kopia.oddaj();

            return 0;
        }
    }
}
