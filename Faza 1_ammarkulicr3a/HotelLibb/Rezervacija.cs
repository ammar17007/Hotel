using System;

namespace HotelLibb
{
    public class Rezervacija : ICenik
    {
        public string Sifra { get; set; }
        public Gost Gost { get; set; }
        public Soba Soba { get; set; }
        public DateTime Od { get; set; }
        public DateTime Do { get; set; }

        public Rezervacija(Gost gost, Soba soba, DateTime od, DateTime doDatum)
        {
            Sifra = Guid.NewGuid().ToString();
            Gost = gost;
            Soba = soba;
            Od = od;
            Do = doDatum;
        }

        public double IzracunajCeno()
        {
            int stNoci = (Do - Od).Days;
            if (stNoci <= 0) stNoci = 1;
            return stNoci * Soba.CenaNaNoc;
        }

        public override string ToString()
        {
            return $"{Gost} | {Soba} | {Od:dd.MM.yyyy} - {Do:dd.MM.yyyy}";
        }
    }
}
