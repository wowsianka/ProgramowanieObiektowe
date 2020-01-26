using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Film : ICloneable, IComparable
    {
        private static int numberOfFilms = 1;

        public int id;
        public String nazwa;
        public String reżyser;
        public List<Kategoria.nazwaKategorii> kategorie = new List<Kategoria.nazwaKategorii>();
        public float ocenaImdb;
        //public List<KopiaFilmu> listaKopii;
        public DateTime rokPremiery;

        public int ID { get => id; set => id = value; }
        public string Nazwa { get => nazwa; set => nazwa = value; }
        public string Reżyser { get => reżyser; set => reżyser = value; }
        public float OcenaImdb { get => ocenaImdb; set => ocenaImdb = value; }
        public DateTime RokPremiery { get => rokPremiery; set => rokPremiery = value; }


        public Film()
        {

        }

        public Film(String nazwa, String reżyser, DateTime rokPremiery)
        {
            this.ID = Film.numberOfFilms++;
            this.Nazwa = nazwa;
            this.Reżyser = reżyser;
            //this.listaKopii = new List<KopiaFilmu>();
            this.RokPremiery = rokPremiery;
        }

        public Film(String nazwa, String reżyser, float ocena, DateTime rokPremiery) // List<Kategoria> kategorie,
               : this(nazwa, reżyser, rokPremiery)
        {
            //this.kategorie = kategorie;
            this.ocenaImdb = ocena;
        }

        //public void DodajKopie(Nośnik nośnik)
        //{
        //    this.listaKopii.Add(new KopiaFilmu(this, nośnik));
        //}

        //public void DodajDoKategorii(Kategoria.nazwaKategorii nazwa, int id)
        //{           
        //        this.kategorie.Add(nazwa);           
        //}

        public override string ToString()
        {
            StringBuilder wynik = new StringBuilder();
            wynik.Append("ID filmu: " + id + Environment.NewLine);
            wynik.Append("Tytuł: " + nazwa + Environment.NewLine);
            wynik.Append("reżyser: " + reżyser + Environment.NewLine);
            wynik.Append("data premiery: " + rokPremiery + Environment.NewLine);
            if (kategorie != null)
            {
                wynik.Append("kategorie: ");
                foreach (Kategoria.nazwaKategorii k in kategorie)
                {
                    wynik.Append(k + ", ");
                }
                wynik.Append(Environment.NewLine);
            }
            if (ocenaImdb > 0)
            {
                wynik.Append("ocena: " + ocenaImdb + Environment.NewLine);
            }
            //int b=0;
            //int d=0;
            //int v=0;
            //foreach(KopiaFilmu f in listaKopii)
            //    {
            //        if(f.Nośnik== Nośnik.BluRay){b++;}
            //        if(f.Nośnik==Nośnik.DVD){d++;}
            //        if(f.Nośnik==Nośnik.VHS){v++;}            
            //}
            //wynik.Append("Liczba kopii filmów na: blueray- "+b.ToString()+", DVD-"+d.ToString()+", VHS-"+v.ToString()+Environment.NewLine);


            return wynik.ToString();
        }

        //klonowanie filmu
        public virtual object Clone()
        {
            return (Film)this.MemberwiseClone();
        }

        //porównywanie filmu - metoda potrzebna do sortowania listy filmów
        public int CompareTo(object other)
        {
            if (other != null)
            {
                Film f = (Film)other;
                if (this.reżyser.CompareTo(f.reżyser) != 0)
                {
                    return this.reżyser.CompareTo(f.reżyser);
                }
                else
                    return this.nazwa.CompareTo(f.nazwa);


            }
            else
                return 1;
        }
    }
}