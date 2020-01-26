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
            //stworzenie listy filmów
            Filmy filmy = new Filmy();
            //*************************dodanie filmów do listy*************************

            Film film1 = new Film("Alfabet", "Tarantino", DateTime.Now);
            Film film2 = new Film("Titanic i 3 muszkieterowie", "Tarantino", DateTime.Now);
            Film film3 = new Film("Titanic", "Sapkowski", DateTime.Now);
            filmy.DodajFilm(film1);
            filmy.DodajFilm(film2);
            filmy.DodajFilm(film3);

            //*************************dodanie kategorii do fimów*************************
            filmy.DodajDoKategorii(Kategoria.nazwaKategorii.animowany, 1);
            filmy.DodajDoKategorii(Kategoria.nazwaKategorii.dlaDzieci, 1);
            filmy.DodajDoKategorii(Kategoria.nazwaKategorii.komedia, 1);
            filmy.DodajDoKategorii(Kategoria.nazwaKategorii.animowany, 2);
            filmy.DodajDoKategorii(Kategoria.nazwaKategorii.dlaDzieci, 2);


            Console.WriteLine("=================================kopie filmów==============================");
            //*************************dodanie kopii filmów*************************
            KopieFilmów kopie = new KopieFilmów();
            kopie.DodajKopie(filmy.ZnajdźFilm(1), Nośnik.BluRay);
            kopie.DodajKopie(filmy.ZnajdźFilm(1), Nośnik.BluRay);
            kopie.DodajKopie(filmy.ZnajdźFilm(1), Nośnik.DVD);
            kopie.DodajKopie(filmy.ZnajdźFilm(1), Nośnik.DVD);
            kopie.DodajKopie(filmy.ZnajdźFilm(1), Nośnik.VHS);
            kopie.DodajKopie(filmy.ZnajdźFilm(2), Nośnik.BluRay);
            kopie.DodajKopie(filmy.ZnajdźFilm(2), Nośnik.BluRay);
            kopie.DodajKopie(filmy.ZnajdźFilm(2), Nośnik.DVD);
            kopie.DodajKopie(filmy.ZnajdźFilm(2), Nośnik.DVD);
            kopie.DodajKopie(filmy.ZnajdźFilm(2), Nośnik.VHS);
            kopie.DodajKopie(filmy.ZnajdźFilm(1), Nośnik.BluRay);
            kopie.DodajKopie(filmy.ZnajdźFilm(1), Nośnik.BluRay);
            kopie.DodajKopie(filmy.ZnajdźFilm(1), Nośnik.DVD);
            kopie.DodajKopie(filmy.ZnajdźFilm(1), Nośnik.DVD);
            kopie.DodajKopie(filmy.ZnajdźFilm(1), Nośnik.VHS);
            ////wypisanie listy kopii
            Console.WriteLine(kopie);

            Console.WriteLine("=================================Funkcja znajdź film po id==============================");
            //wypisanie filmu z określonym id
            Console.WriteLine(filmy.ZnajdźFilm(1));

            Console.WriteLine("=================================Wypisanie wszystkich filmów należących do danej kategorii(animowane)==============================");
            //wypisywanie wszystkich filmów należących do danej klasy
            foreach (Film f in filmy.Znajdźkategorie(Kategoria.nazwaKategorii.animowany))
                Console.WriteLine(f);

            Console.WriteLine("=================================wypisanie wszystkich filmów zawierających słowo Titanic w nazwie==============================");
            //wypisanie wszystkich filmów zawierających słowo "Titanic " w nazwie
            foreach (Film film in filmy.WyszukajPoNazwie("Titanic"))
                Console.WriteLine(film);

            Console.WriteLine("=================================pracownicy==============================");
            //dodanie i wypisanie pracowników
            Pracownicy pracownicy = new Pracownicy();
            pracownicy.DodajPracownika(new Pracownik("jan", "kowalski", "jkowal@gmail.com", "123123123", 1112, "kierownik", "33586989282982", "9999999999999"));
            pracownicy.DodajPracownika(new Pracownik("Anna", "kowalska", "akowal@gmail.com", "123123123", 1113, "menager", "33586989282982", "9999999999999"));
            //Console.WriteLine(pracownicy);

            //Console.WriteLine("=================================klienci==============================");
            ////dodanie i wypisanie klientów
            Klient klient1 = new Klient("Iza", "Zmatiza", "Agatazfiata@gmail.com", "123123123");
            Klient klient2 = new Klient("Romek", "Atomek", "Ratomek@gmail.com", "123123123");
            Klient klient3 = new Klient("Karina", "Mytnik", "KaroMaro@gmail.com", "123123123");
            Klient klient4 = new Klient("Filik", "Konopnik", "Konopijczyk@gmail.com", "123123123");

            Klienci klienci = new Klienci();
            klienci.DodajKlienta(klient1);
            klienci.DodajKlienta(klient2);
            klienci.DodajKlienta(klient3);
            klienci.DodajKlienta(klient4);

            //Console.WriteLine(klienci);

            Console.WriteLine("=================================wypożyczenie==============================");
            //wypożyczenia filmów
            HistoriaWypożyczeń wypożyczenia = new HistoriaWypożyczeń();
            wypożyczenia.Wypożycz(kopie.ZnajdźKopie(1002), klienci.ZnajdźKlienta(1), pracownicy.ZnajdźPracownika(1112));
            
            //wypożyczenia.Wypożycz(kopie.ZnajdźKopie(1), klienci.ZnajdźKlienta(2), pracownicy.ZnajdźPracownika(1));

            Console.WriteLine(wypożyczenia);


            Console.WriteLine("=================================serializacjaXML==============================");

            //serializacja listy filmów do pliku XML i ich odczyt z pliku XML
            filmy.ZapiszXML("listaFilmów.xml");
            Filmy odczytana = (Filmy)filmy.OdczytXML("listaFilmów.xml");
            Console.WriteLine("zapis do XML...");
            Console.WriteLine(filmy);
            Console.WriteLine("odczyt z XML..");
            Console.WriteLine(odczytana);

            Console.WriteLine("=================================klonowanie-IClonable==============================");

            //klonowanie listy klientów i zmiana listy przez dodanie nowego klienta
            Klient klient5 = new Klient("Jola", "Omyła", "jolaomy@gmail.com", "123123123");
            Klienci zmiana = (Klienci)klienci.DeepClone();
            zmiana.DodajKlienta(klient5);
            Console.WriteLine("----- lista klientów przed zmianą------");
            Console.WriteLine(klienci + "\n");
            Console.WriteLine("----- lista klientów po zmianie------");
            Console.WriteLine(zmiana);

            //klonowanie listy filmów i zmiana listy przez usunięcie filmu i dodanie nowego filmu
            Film film4 = new Film("Titanic", "Gucio", DateTime.Now);
            Filmy zmianafilmu = (Filmy)filmy.DeepClone();
            zmianafilmu.ZnajdźFilm(1).nazwa = "Plastuś";
            zmianafilmu.DodajFilm(film4);
            Console.WriteLine("-----lista filmów przed zmianią------");
            Console.WriteLine(filmy + "\n");
            Console.WriteLine("-----lista filmów po zmianie------");
            Console.WriteLine(zmianafilmu + "\n");

            Console.WriteLine("=================================sortowanie-IComparable==============================");

            //Sortowanie filmów względem reżysera (gdy reżyser jest taki sam to sortuje według tytułu)
            zmianafilmu.Sortuj();
            Console.WriteLine("-----posortowana lista filmów wg reżysera/tytuł------");
            Console.WriteLine(zmianafilmu);

            //sortowanie listy klientów wg nazwiska
            Console.WriteLine("-----posortowana lista klientów wg nazwiska------");
            klienci.SortujPoNAZWISKO();
            Console.WriteLine(klienci);



            Console.ReadKey();
            Console.ReadKey();
        }
    }
}