using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt
{
    public class Klienci : ICloneable
    {
        public List<Klient> klienci;

        public Klienci() : base()
        {
            klienci = new List<Klient>();
        }


        public void DodajKlienta(Klient klient)
        {
            klienci.Add(klient);
        }


        public Klient ZnajdźKlienta(int id)
        {
            foreach (Klient k in klienci)
            {
                if (k.clientID == id)
                    return k;
            }

            throw new Exception();
        }

        public void DodajOpłatę(Klient klient, double koszt)
        {
            klient.opłaty = +koszt;
        }

        public void Opłać(Klient klient, double wpłata)
        {
            klient.opłaty -= wpłata;
        }

        public override string ToString()
        {
            StringBuilder lista = new StringBuilder();
            foreach (Klient k in klienci)
            {
                lista.Append(k + Environment.NewLine);
            }
            return lista.ToString();
        }

        public object Clone()
        {
            return (Klienci)this.MemberwiseClone();
        }

        //klonowanie klientów
        public object DeepClone()
        {
            Klienci kopiaListyKlientow = (Klienci)MemberwiseClone();
            kopiaListyKlientow.klienci = new List<Klient>();
            foreach (Klient k in klienci)
            {
                Klient kopiaKlienta = (Klient)k.Clone();
                kopiaListyKlientow.DodajKlienta(kopiaKlienta);

            }
            return kopiaListyKlientow;

        }

        //sortowanie klientów po nazwisku
        public void SortujPoNAZWISKO()
        {
            klienci.Sort(new NAZWISKOComparator());
        }

    }




    //klasa potrzebna do sortowania listy klientów po nazwisku
    class NAZWISKOComparator : IComparer<Klient>
    {
        public int Compare(Klient x, Klient y)
        {
            if (x != null && y != null)
            {
                return x.nazwisko.CompareTo(y.nazwisko);
            }
            return 1;
        }
    }
}