namespace HotelLibb
{
    public class LuksuznaSoba : Soba
    {
        public bool Jacuzzi { get; set; }

        public LuksuznaSoba(int stevilka, int kapaciteta, double cena, bool jacuzzi)
            : base(stevilka, kapaciteta, cena)
        {
            Jacuzzi = jacuzzi;
        }

        public override string ToString()
        {
            return base.ToString() + (Jacuzzi ? " + Jacuzzi" : "");
        }
    }
}
