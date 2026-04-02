using System;

namespace HotelLibb
{
    /// <summary>
    /// Predstavlja rezervacijo sobe v hotelu
    /// </summary>
    public class Rezervacija : ICenik
    {
        /// <summary>
        /// Šifra
        /// </summary>
        public string Sifra { get; set; }

        /// <summary>
        /// Gost
        /// </summary>
        public Gost Gost { get; set; }

        /// <summary>
        /// Soba
        /// </summary>
        public Soba Soba { get; set; }

        /// <summary>
        /// Datum začetka rezervacije
        /// </summary>
        public DateTime Od { get; set; }

        /// <summary>
        /// Datum konca rezervacije
        /// </summary>
        public DateTime Do { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        public Rezervacija(Gost gost, Soba soba, DateTime od, DateTime doDatum)
        {
            Sifra = Guid.NewGuid().ToString();
            Gost = gost;
            Soba = soba;
            Od = od;
            Do = doDatum;
        }

        /// <summary>
        /// Izračuna skupno ceno rezervacije
        /// </summary>
        public double IzracunajCeno()
        {
            int stNoci = (Do - Od).Days;
            if (stNoci <= 0) stNoci = 1;
            return stNoci * Soba.CenaNaNoc;
        }

        /// <summary>
        /// Vrne podatke o rezervaciji.
        /// </summary>
        public override string ToString()
        {
            return $"{Gost} | {Soba} | {Od:dd.MM.yyyy} - {Do:dd.MM.yyyy}";
        }
    }
}