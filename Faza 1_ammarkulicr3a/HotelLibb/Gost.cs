namespace HotelLibb
{
    /// <summary>
    /// Razred, ki predstavlja gosta hotela
    /// </summary>
    public class Gost : Oseba
    {
        /// <summary>
        /// Tip gosta
        /// </summary>
        public string TipGosta { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        public Gost() { }

        /// <summary>
        /// Konstruktor za določanje gosta
        /// </summary>
        /// <param name="sifra">Šifra gosta.</param>
        /// <param name="ime">Ime gosta.</param>
        /// <param name="priimek">Priimek gosta.</param>
        /// <param name="spol">Spol gosta.</param>
        /// <param name="telefon">Telefon gosta.</param>
        /// <param name="tip">Tip gosta.</param>
        public Gost(string sifra, string ime, string priimek, string spol, string telefon, string tip)
            : base(sifra, ime, priimek, spol, telefon)
        {
        }

        /// <summary>
        /// Vrne opis gosta
        /// </summary>
        public override string Opis()
        {
            return $"Gost: {Ime} {Priimek} ({TipGosta})";
        }

        /// <summary>
        /// Vrne pozdrav gosta
        /// </summary>
        public override string Pozdrav()
        {
            return $"Zdravo, ime mi je {Ime}. Veselim se bivanja!";
        }
    }
}