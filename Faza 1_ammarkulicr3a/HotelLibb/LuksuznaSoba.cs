namespace HotelLibb
{
    /// <summary>
    /// Razred luksuzna soba
    /// </summary>
    public class LuksuznaSoba : Soba
    {
        /// <summary>
        /// Določa če vsebuje soba jacuzi
        /// </summary>
        public bool Jacuzzi { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="stevilka">Številka sobe.</param>
        /// <param name="kapaciteta">Kapaciteta sobe.</param>
        /// <param name="cena">Cena na noč.</param>
        /// <param name="jacuzzi">Ali ima jacuzzi.</param>
        public LuksuznaSoba(int stevilka, int kapaciteta, double cena, bool jacuzzi)
            : base(stevilka, kapaciteta, cena)
        {
            Jacuzzi = jacuzzi;
        }

        /// <summary>
        /// Vrne opis luksuzne sobe
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + (Jacuzzi ? " + Jacuzzi" : "");
        }
    }
}