using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Projekt
{
    public class HistoriaWypożyczeń : Wypożyczenie
    {
        List<Wypożyczenie> historia = new List<Wypożyczenie>();

        public HistoriaWypożyczeń()
        {

        }

        public void Wypożycz(KopiaFilmu kopia, Klient klient, Pracownik pracownik)
        {
            historia.Add(new Wypożyczenie(kopia, klient, pracownik));
        }

        public double oddajFilm(DateTime dateTime, int id)
        {
            double koszt = 0;
            int dni = 0;
            foreach (Wypożyczenie w in historia)
            {

                if (id == w.id_wypożyczenia)
                {
                    dni = (dateTime - w.dataWypożyczenia).Days;
                    koszt = w.cenaZaDzień * dni;
                }
            }
            return koszt;
        }

        public override string ToString()
        {
            StringBuilder lista = new StringBuilder();
            foreach (Wypożyczenie p in historia)
            {
                lista.Append(p + Environment.NewLine);
            }
            return lista.ToString();
        }



    }
}