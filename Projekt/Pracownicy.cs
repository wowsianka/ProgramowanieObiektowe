using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Pracownicy : Pracownik
    {
        List<Pracownik> pracownicy = new List<Pracownik>();

        public Pracownicy()
        {

        }

        public void DodajPracownika(Pracownik pracownik)
        {
            pracownicy.Add(pracownik);
        }
        public Pracownik ZnajdźPracownika(int id)
        {
            foreach (Pracownik p in pracownicy)
            {
                if (p.pracownikID == id)
                    return p;

            }

            throw new Exception();
        }
        public override string ToString()
        {
            StringBuilder lista = new StringBuilder();
            foreach (Pracownik p in pracownicy)
            {
                lista.Append(p + Environment.NewLine);
            }
            return lista.ToString();
        }

    }
}