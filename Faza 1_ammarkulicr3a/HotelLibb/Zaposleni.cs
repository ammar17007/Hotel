namespace HotelLibb
{
    public class Zaposleni : Oseba
    {
        public string DelovnoMesto { get; set; }

        public const double MinimalnaPlaca = 1200;

        public static int SteviloZaposlenih = 0;

        public readonly int ID;

        public Zaposleni()
        {
            ID = ++SteviloZaposlenih;
        }

        public Zaposleni(string sifra, string ime, string priimek, string spol, string telefon, string delovnoMesto)
            : base(sifra, ime, priimek, spol, telefon)
        {
            DelovnoMesto = delovnoMesto;
            ID = ++SteviloZaposlenih;
        }

        public override string Opis()
        {
            return $"Zaposleni: {Ime} {Priimek} ({DelovnoMesto}) | ID: {ID}";
        }

        public override string Pozdrav()
        {
            return $"Zdravo ime mi je {Ime}, zaposlen kot {DelovnoMesto}.";
        }
    }
}
