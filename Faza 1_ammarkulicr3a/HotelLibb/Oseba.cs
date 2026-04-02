using System;

namespace HotelLibb
{
    public abstract class Oseba
    {
        
        private string ime;
        private string priimek;

        public string Sifra { get; set; }

        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                if (value == "" || value == null)
                    ime = "Neznano";
                else
                    ime = value;
            }
        }

        public string Priimek
        {
            get
            {
                return priimek;
            }
            set
            {
                if (value == "" || value == null)
                    priimek = "Neznano";
                else
                    priimek = value;
            }
        }

        public string Spol { get; set; }
        public string Telefon { get; set; }

        public readonly DateTime DatumUstvarjanja;

        public Oseba()
        {
            DatumUstvarjanja = DateTime.Now;
        }

        public Oseba(string sifra, string ime, string priimek, string spol, string telefon)
        {
            Sifra = sifra;
            Ime = ime;
            Priimek = priimek;
            Spol = spol;
            Telefon = telefon;
            DatumUstvarjanja = DateTime.Now;
        }

        public abstract string Opis();

        public virtual string Pozdrav()
        {
            return $"Pozdravljeni, jaz sem {Ime} {Priimek}.";
        }

        public override string ToString()
        {
            return $"{Ime} {Priimek}";
        }
    }
}
