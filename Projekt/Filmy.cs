using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt
{
    public class Filmy : Film, ICloneable, ISavable
    {
        public List<Film> filmy = new List<Film>();

        public Filmy()
        {
        }

        public void DodajFilm(Film film)
        {
            filmy.Add(film);
        }

        public void DodajDoKategorii(Kategoria.nazwaKategorii nazwa, int id)
        {
            foreach (Film f in filmy)
            {
                if (f.ID == id)
                    f.kategorie.Add(nazwa);
            }
        }

        public List<Film> Znajdźkategorie(Kategoria.nazwaKategorii nazwa)
        {
            List<Film> lista = new List<Film>();
            foreach (Film f in filmy)
            {
                if (f.kategorie.Contains(nazwa))
                    lista.Add(f);

            }
            return lista;
        }

        public List<Film> WyszukajPoNazwie(String nazwa)
        {
            List<Film> znalezione = new List<Film>();

            foreach (Film film in this.filmy)
            {
                if (film.Nazwa.Contains(nazwa))
                    znalezione.Add(film);
            }

            return znalezione;
        }
        public Film ZnajdźFilm(int id)
        {
            //Film fil = new Film;
            foreach (Film f in filmy)
            {
                if (f.id == id)
                    return f;

            }

            throw new Exception();
        }

        public override string ToString()
        {
            StringBuilder lista = new StringBuilder();
            foreach (Film f in filmy)
            {
                lista.Append(f + Environment.NewLine);
            }
            return lista.ToString();
        }



        public override object Clone()
        {
            return (Filmy)this.MemberwiseClone();

        }

        //klonowanie filmów
        public object DeepClone()
        {
            Filmy kopia = (Filmy)Clone();
            kopia.filmy = new List<Film>();
            foreach (Film f in filmy)
            {
                Film kopiafilmu = (Film)f.Clone();
                kopia.DodajFilm(kopiafilmu);
            }
            return kopia;

        }

        //serializacja do XML
        public void ZapiszXML(string nazwa)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Filmy));
            StreamWriter writer = new StreamWriter(nazwa);
            serializer.Serialize(writer, this);
            writer.Close();
        }

        //deserializacja z XML
        public object OdczytXML(string nazwa)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Filmy));
            Stream stream = new FileStream(nazwa, FileMode.Open);
            Filmy wynik = (Filmy)serializer.Deserialize(stream);
            stream.Close();
            return wynik;

        }

        //sortowanie filmów
        public void Sortuj()
        {
            filmy.Sort();
        }

    }
}