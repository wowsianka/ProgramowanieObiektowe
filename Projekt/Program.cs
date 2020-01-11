using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Program
    {


        static void Main(string[] args)
        {
            Filmy filmy = new Filmy();
            filmy.dodajFilm(new Film("pies i kot", "tomek", DateTime.Now));
            filmy.dodajFilm(new Film("kot i pies", "tomek", DateTime.Now));
            filmy.dodajFilm(new Film("kot", "tomek", DateTime.Now));

            foreach(Film film in filmy.wyszukajPoNazwie("pies"))
                Console.WriteLine(film);
            Console.ReadKey();
        }
    }
}
