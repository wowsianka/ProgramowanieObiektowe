using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Cennik
    {
        //To jest cena za dzień

        static private double cenaBieżącegoRoku = 6;
        static private double deltaCeny = 0.5; //ile cena dnia filmu spada z każdym rokiem
        static private double najnizszaCena = 2;

        public static double cenaDniaFilmu(Film film)
        {
            int yearDiff = DateTime.Now.Year - film.RokPremiery.Year;
            return cenaBieżącegoRoku - deltaCeny * yearDiff >= najnizszaCena ? cenaBieżącegoRoku - deltaCeny * yearDiff : najnizszaCena;
        }
    }
}
