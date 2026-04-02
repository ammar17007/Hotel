namespace HotelLibb
{
    /// <summary>
    /// Hotelska soba
    /// </summary>
    public class Soba
    {
        /// <summary>
        /// Številka sobe
        /// </summary>
        public int Stevilka { get; set; }

        /// <summary>
        /// Kapaciteta sobe
        /// </summary>
        public int Kapaciteta { get; set; }

        /// <summary>
        /// Cena na noč
        /// </summary>
        public double CenaNaNoc { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        public Soba(int stevilka, int kapaciteta, double cena)
        {
            Stevilka = stevilka;
            Kapaciteta = kapaciteta;
            CenaNaNoc = cena;
        }

        /// <summary>
        /// računanje cene
        /// </summary>
        public static double operator +(Soba a, Soba b)
        {
            if (a == null || b == null)
                return 0;

            return a.CenaNaNoc + b.CenaNaNoc;
        }

        /// <summary>
        /// Vrne o sobi
        /// </summary>
        public override string ToString()
        {
            return $"Soba {Stevilka} ({Kapaciteta} oseb)";
        }
    }
}