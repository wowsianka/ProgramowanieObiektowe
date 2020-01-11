using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class KopiaFilmu
    {

        private Film film;
        private int id;
        private Boolean jestWypożyczona;
        private Nośnik nośnik;

        private List<Wypożyczenie> historiaWypożyczeń;

        internal Film Film { get => film; set => film = value; }
        public int Id { get => id; set => id = value; }
        public bool JestWypożyczona { get => jestWypożyczona; set => jestWypożyczona = value; }
        internal Nośnik Nośnik { get => nośnik; set => nośnik = value; }

        public KopiaFilmu(Film film, Nośnik nośnik)
        {
            this.Id = film.listaKopii.Count;
            this.Film = film;
            this.Nośnik = nośnik;
            this.historiaWypożyczeń = new List<Wypożyczenie>();
            this.JestWypożyczona = false;
        }

        public void wypożycz()
        {
            this.JestWypożyczona = true;
        }

        public void oddaj()
        {
            this.JestWypożyczona = false;
        }
    }
}
