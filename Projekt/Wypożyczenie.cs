using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Wypożyczenie
    {
        public int id_wypożyczenia;
        public DateTime dataWypożyczenia;
        private KopiaFilmu kopia;
        public Klient klient;
        public double cenaZaDzień;
        private int idpracownika;
        static int nr = 0;


        public int Id_wypożyczenia { get => id_wypożyczenia; set => id_wypożyczenia = value; }
        public DateTime DataWypożyczenia { get => dataWypożyczenia; set => dataWypożyczenia = value; }
        public double CenaZaDzień { get => cenaZaDzień; set => cenaZaDzień = value; }
        public int Idpracownika { get => idpracownika; set => idpracownika = value; }
        internal KopiaFilmu Kopia { get => kopia; set => kopia = value; }
        internal Klient Klient { get => klient; set => klient = value; }

        public Wypożyczenie()
        {

        }

        public Wypożyczenie(KopiaFilmu kopia, Klient klient, Pracownik pracownik)
        {
            this.Kopia = kopia;
            this.Klient = klient;
            this.DataWypożyczenia = DateTime.Now;
            this.CenaZaDzień = Cennik.cenaDniaFilmu(kopia.Film);
            this.Idpracownika = pracownik.PracownikID;
            this.id_wypożyczenia = nr;
            nr++;
        }

        public override string ToString()
        {
            StringBuilder wynik = new StringBuilder();
            wynik.Append("Id filmu " + kopia.ID_Kopii + Environment.NewLine);
            wynik.Append("nazwa filmu " + kopia.nazwa + Environment.NewLine);
            wynik.Append("reżyser filmu " + kopia.reżyser + Environment.NewLine);
            wynik.Append("id klienta " + klient.clientID + Environment.NewLine);
            wynik.Append("id wypożyczenia: " + nr + Environment.NewLine);
            wynik.Append("data wypożyczenia: " + dataWypożyczenia.ToString() + Environment.NewLine);
            return wynik.ToString();
        }



        //public double oddajFilm(DateTime dateTime,int id )
        //{
        //    this.Kopia.oddaj();

        //    return 0;
        //}
    }
}