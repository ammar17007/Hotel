using System;

namespace HotelLibb
{
    /// <summary>
    /// Abstraktni razred, ki predstavlja osnovno osebo v sistemu
    /// </summary>
    public abstract class Oseba
    {

        private string ime;
        private string priimek;

        /// <summary>
        /// šifra osebe        
        /// </summary>
        public string Sifra { get; set; }

        /// <summary>
        /// Ime osebe. Če je prazno ali null, se nastavi na "Neznano".
        /// </summary>
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

        /// <summary>
        /// Priimek osebe. Če je prazno ali null, se nastavi na "Neznano".
        /// </summary>
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

        /// <summary>
        /// Spol osebe
        /// </summary>
        public string Spol { get; set; }

        /// <summary>
        /// Telefonska številka osebe
        /// </summary>
        public string Telefon { get; set; }

        /// <summary>
        /// Datum ustvarjanja
        /// </summary>
        public readonly DateTime DatumUstvarjanja;

        /// <summary>
        /// Privzeti konstruktor, ki nastavi datum ustvarjanja
        /// </summary>
        public Oseba()
        {
            DatumUstvarjanja = DateTime.Now;
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="sifra">Šifra osebe.</param>
        /// <param name="ime">Ime osebe.</param>
        /// <param name="priimek">Priimek osebe.</param>
        /// <param name="spol">Spol osebe.</param>
        /// <param name="telefon">Telefon osebe.</param>
        public Oseba(string sifra, string ime, string priimek, string spol, string telefon)
        {
            Sifra = sifra;
            Ime = ime;
            Priimek = priimek;
            Spol = spol;
            Telefon = telefon;
            DatumUstvarjanja = DateTime.Now;
        }

        /// <summary>
        /// Vrne opis
        /// </summary>
        /// <returns>Opis osebe.</returns>
        public abstract string Opis();

        /// <summary>
        /// Vrne pozdrav
        /// </summary>
        public virtual string Pozdrav()
        {
            return $"Pozdravljeni, jaz sem {Ime} {Priimek}.";
        }

        /// <summary>
        /// Vrne o osebi
        /// </summary>
        public override string ToString()
        {
            return $"{Ime} {Priimek}";
        }
    }
}