using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Film
    {
        private static int numberOfFilms = 0;

        private int id;
        private String nazwa;
        private String reżyser;
        private List<Kategoria> kategorie;
        private float ocenaImdb;
        public List<KopiaFilmu> listaKopii;
        private DateTime rokPremiery;

        public int ID { get => id; set => id = value; }
        public string Nazwa { get => nazwa; set => nazwa = value; }
        public string Reżyser { get => reżyser; set => reżyser = value; }
        public float OcenaImdb { get => ocenaImdb; set => ocenaImdb = value; }
        public DateTime RokPremiery { get => rokPremiery; set => rokPremiery = value; }

        public Film(String nazwa, String reżyser, DateTime rokPremiery)
        {
            this.ID = Film.numberOfFilms++;
            this.Nazwa = nazwa;
            this.Reżyser = reżyser;
            this.listaKopii = new List<KopiaFilmu>();
            this.RokPremiery = rokPremiery;
        }

        public Film(String nazwa, String reżyser, List<Kategoria> kategorie, float ocena, DateTime rokPremiery) 
               : this(nazwa,reżyser,rokPremiery)
        {
            this.kategorie = kategorie;
            this.ocenaImdb = ocena;
        }

        public void dodajKopie(Nośnik nośnik)
        {
            this.listaKopii.Add(new KopiaFilmu(this, nośnik));
        }

        public override string ToString()
        {
            return this.nazwa;
        }
    }
}
