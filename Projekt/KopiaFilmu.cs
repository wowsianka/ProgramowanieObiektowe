using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class KopiaFilmu : Film
    {
        private int id_org;
        private String nazwa_org;
        private String reżyser_org;
        private List<Kategoria.nazwaKategorii> kategorie_org = new List<Kategoria.nazwaKategorii>();
        private float ocenaImdb_org;
        private DateTime rokPremiery_org;
        private Film film1;
        private Boolean jestWypożyczona;
        private Nośnik nośnik;
        //public List<KopiaFilmu> listaKopii=new List<KopiaFilmu>();
        public int ID_Kopii;
        static int nr_Kopii;
        public int ID_Kopii1 { get => ID_Kopii; set => ID_Kopii = value; }
        public List<Wypożyczenie> historiaWypożyczeń = new List<Wypożyczenie>();

        public Film Film { get => film1; set => film1 = value; }
        public bool JestWypożyczona { get => jestWypożyczona; set => jestWypożyczona = value; }
        internal Nośnik Nośnik { get => nośnik; set => nośnik = value; }
        public int Id_org { get => id_org; set => id_org = value; }
        public string Nazwa_org { get => nazwa_org; set => nazwa_org = value; }
        public string Reżyser_org { get => reżyser_org; set => reżyser_org = value; }
        internal List<Kategoria.nazwaKategorii> Kategorie_org { get => kategorie_org; set => kategorie_org = value; }
        public float OcenaImdb_org { get => ocenaImdb_org; set => ocenaImdb_org = value; }
        public DateTime RokPremiery_org { get => rokPremiery_org; set => rokPremiery_org = value; }

        public KopiaFilmu() : base()
        {
        }
        public KopiaFilmu(Film film, Nośnik nośnik) : base()
        {
            this.nazwa_org = film.nazwa;
            this.reżyser_org = film.reżyser;
            this.id_org = film.id;
            this.kategorie_org = film.kategorie;
            this.ocenaImdb_org = film.ocenaImdb;
            this.rokPremiery_org = film.rokPremiery;
            this.Film = film;
            //this.ID_Kopii.Append(film.id+"/"+nr_Kopii);
            this.ID_Kopii = film.id * 1000 + nr_Kopii;
            nr_Kopii++;
            this.Nośnik = nośnik;
            // this.historiaWypożyczeń = new List<Wypożyczenie>();
            this.JestWypożyczona = false;
        }

        //public void DodajKopie(Film film, Nośnik nośnik)
        //{
        //    listaKopii.Add(new KopiaFilmu(film,nośnik));
        //}

        //public void wypożycz()
        //{
        //    this.JestWypożyczona = true;
        //}

        //public void oddaj()
        //{
        //    this.JestWypożyczona = false;
        //}


        public override string ToString()
        {
            StringBuilder wynik = new StringBuilder();
            wynik.Append("ID filmu: " + id_org + Environment.NewLine);
            wynik.Append("Tytuł: " + nazwa_org + Environment.NewLine);
            wynik.Append("reżyser: " + reżyser_org + Environment.NewLine);
            wynik.Append("data premiery: " + rokPremiery_org + Environment.NewLine);
            if (kategorie != null)
            {
                wynik.Append("kategorie: ");
                foreach (Kategoria.nazwaKategorii k in kategorie_org)
                {
                    wynik.Append(k + ", ");
                }
                wynik.Append(Environment.NewLine);
            }
            if (ocenaImdb > 0)
            {
                wynik.Append("ocena: " + ocenaImdb_org + Environment.NewLine);
            }
            wynik.Append("id kopii: " + this.ID_Kopii);
            wynik.Append(" nośnik:" + this.nośnik + "jest wypożyczona: " + jestWypożyczona.ToString() + " " + Environment.NewLine);
            //wynik.Append(x.ToString()+ Environment.NewLine);
            //int b = 0;
            //int d = 0;
            //int v = 0;
            //foreach (KopiaFilmu f in listaKopii)
            //{
            //    if (f.Nośnik == Nośnik.BluRay) { b++; }
            //    if (f.Nośnik == Nośnik.DVD) { d++; }
            //    if (f.Nośnik == Nośnik.VHS) { v++; }
            //}
            //wynik.Append("Liczba kopii filmów na: blueray- " + b.ToString() + ", DVD-" + d.ToString() + ", VHS-" + v.ToString() + Environment.NewLine);
            return wynik.ToString();
        }

    }
}