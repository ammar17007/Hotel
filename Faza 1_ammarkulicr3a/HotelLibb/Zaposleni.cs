namespace HotelLibb
{
    /// <summary>
    /// Zaposlen v hotelu
    /// Deduje od razreda Oseba.
    /// </summary>
    public class Zaposleni : Oseba
    {
        /// <summary>
        /// Delovno mesto zaposlenega
        /// </summary>
        public string DelovnoMesto { get; set; }

        /// <summary>
        /// Minimalna plača zaposlenega
        /// </summary>
        public const double MinimalnaPlaca = 1200;

        /// <summary>
        /// Število zaposlenih
        /// </summary>
        public static int SteviloZaposlenih = 0;

        /// <summary>
        /// ID zaposlenega
        /// </summary>
        public readonly int ID;

        /// <summary>
        /// Privzeti konstruktor
        /// </summary>
        public Zaposleni()
        {
            ID = ++SteviloZaposlenih;
        }

        /// <summary>
        /// Konstruktor z vsemi podatki zaposlenega
        /// </summary>
        public Zaposleni(string sifra, string ime, string priimek, string spol, string telefon, string delovnoMesto)
            : base(sifra, ime, priimek, spol, telefon)
        {
            DelovnoMesto = delovnoMesto;
            ID = ++SteviloZaposlenih;
        }

        /// <summary>
        /// Vrne opis zaposlenega
        /// </summary>
        public override string Opis()
        {
            return $"Zaposleni: {Ime} {Priimek} ({DelovnoMesto}) | ID: {ID}";
        }

        /// <summary>
        /// Vrne pozdrav
        /// </summary>
        public override string Pozdrav()
        {
            return $"Zdravo ime mi je {Ime}, zaposlen kot {DelovnoMesto}.";
        }
    }
}