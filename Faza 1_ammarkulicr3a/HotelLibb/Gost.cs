namespace HotelLibb
{
    public class Gost : Oseba
    {
        public string TipGosta { get; set; }

        public Gost() { }

        public Gost(string sifra, string ime, string priimek, string spol, string telefon, string tip)
            : base(sifra, ime, priimek, spol, telefon)
        {
        }

        public override string Opis()
        {
            return $"Gost: {Ime} {Priimek} ({TipGosta})";
        }

        public override string Pozdrav()
        {
            return $"Zdravo, ime mi je {Ime}. Veselim se bivanja!";
        }
    }
}
