using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Projekt
{
    public class Klient : Osoba, ICloneable
    {
        private static int liczbaKlientów = 0;
        public int clientID;
        public double opłaty = 0;

        public Klient() : base()
        {

        }

        public Klient(string imie, string nazwisko, string email, string telefon) : base(imie, nazwisko, email, telefon)
        {
            this.clientID = liczbaKlientów++;
        }



        public override string ToString()
        {

            return "\n id: " + clientID.ToString() + "\n" + base.ToString();
        }

        //klonowanie klienta
        public override object Clone()
        {
            return base.Clone();
        }


    }
}