namespace HotelLibb
{
    public class Soba
    {
        public int Stevilka { get; set; }
        public int Kapaciteta { get; set; }
        public double CenaNaNoc { get; set; }

        public Soba(int stevilka, int kapaciteta, double cena)
        {
            Stevilka = stevilka;
            Kapaciteta = kapaciteta;
            CenaNaNoc = cena;
        }

        public static double operator +(Soba a, Soba b)
        {
            if (a == null || b == null)
                return 0;

            return a.CenaNaNoc + b.CenaNaNoc;
        }

        public override string ToString()
        {
            return $"Soba {Stevilka} ({Kapaciteta} oseb)";
        }
    }
}
