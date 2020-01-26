using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Kategoria
    {
        public enum nazwaKategorii { dramat, horror, komedia, romantyczny, animowany, dlaDzieci, thriller, SciFi, fantasy, historyczny, biografia, dokument }
        //List<Film> filmyKategorii;
        //List<Filmy> filmies = new List<Filmy>();
        private nazwaKategorii nazwa;
        public nazwaKategorii Nazwa { get => nazwa; set => nazwa = value; }

        public Kategoria(nazwaKategorii nazwa)
        {
            //this.filmyKategorii = new List<Film>();
            this.nazwa = nazwa;
        }


        //public void DodajFilmyDoKategorii(nazwaKategorii nazwa)
        //{
        //    foreach(Film f in filmies)
        //    {


        //    }

        //}




    }
}