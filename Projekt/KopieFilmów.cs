using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class KopieFilmów : KopiaFilmu
    {
        public List<KopiaFilmu> listaKopii = new List<KopiaFilmu>();

        public KopieFilmów() : base()
        {

        }

        public void DodajKopie(Film film, Nośnik nośnik)
        {
            listaKopii.Add(new KopiaFilmu(film, nośnik));
        }

        public void Wypożyczfilm(KopiaFilmu kopia)
        {
            foreach (KopiaFilmu k in listaKopii)
            {
                if (k.id == kopia.id)
                {
                    k.JestWypożyczona = true;

                }
            }
        }

        public void OddajFilm(KopiaFilmu kopia)
        {
            foreach (KopiaFilmu k in listaKopii)
            {
                if (k.id == kopia.id)
                {
                    k.JestWypożyczona = false;
                }
            }
        }

        public KopiaFilmu ZnajdźKopie(int id)
        {
            KopiaFilmu kop = new KopiaFilmu();
            foreach (KopiaFilmu k in listaKopii)
            {
                //if (k.ID_Kopii.Equals(id.ToString()))
                //    return k;
                if (k.ID_Kopii == id)
                    return k;
                // kop=k;
            }
            //return kop;
            throw new Exception();
        }

        public override string ToString()
        {
            StringBuilder lista = new StringBuilder();
            foreach (KopiaFilmu k in listaKopii)
            {
                lista.Append(k + Environment.NewLine);
            }
            return lista.ToString();
        }

    }
}