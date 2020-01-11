using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Filmy
    {
        List<Film> filmy = new List<Film>();

        public void dodajFilm(Film film)
        {
            filmy.Add(film);
        }

        public List<Film> wyszukajPoNazwie(String nazwa)
        {
            List<Film> znalezione = new List<Film>();

            foreach(Film film in this.filmy)
            {
                if (film.Nazwa.Contains(nazwa))
                    znalezione.Add(film);
            }

            return znalezione;
        }
    }
}
