using System.Collections.Generic;
using System.Linq;

namespace HotelLibb
{
    /// <summary>
    /// Predstavlja hotel, z sobami in gosti
    /// </summary>
    public class Hotel
    {
        /// <summary>
        /// Ime hotela, saj jih je več
        /// </summary>
        public string Ime { get; set; }

        private List<Soba> sobe = new List<Soba>();
        private List<Zaposleni> zaposleni = new List<Zaposleni>();

        /// <summary>
        /// Skupno število hotelov
        /// </summary>
        public static int SteviloHotelov = 0;

        /// <summary>
        /// Konstruktor, ki poveča števec hotelov
        /// </summary>
        public Hotel()
        {
            SteviloHotelov++;
        }

        /// <summary>
        /// Konstruktor z imenom hotela
        /// </summary>
        /// <param name="ime">Ime hotela</param>
        public Hotel(string ime)
        {
            Ime = ime;
            SteviloHotelov++;
        }

        /// <summary>
        /// Vrne seznam vseh sob v hotelu
        /// </summary>
        public List<Soba> Sobe => sobe;

        public Soba this[int index]
        {
            get => sobe[index];
            set => sobe[index] = value;
        }

        public Zaposleni this[string sifra]
        {
            get
            {
                foreach (var z in zaposleni)
                {
                    if (z.Sifra == sifra)
                        return z;
                }
                return null;
            }
        }

        /// <summary>
        /// Doda novo sobo
        /// </summary>
        /// <param name="s">Soba za dodajanje</param>
        public void DodajSobo(Soba s)
        {
            sobe.Add(s);

            if (SobaDodana != null)
            {
                SobaDodana("Dodana soba: " + s.Stevilka);
            }
        }

        /// <summary>
        /// Nov zaposlen
        /// </summary>
        /// <param name="z">Zaposleni</param>
        public void DodajZaposlenega(Zaposleni z)
        {
            zaposleni.Add(z);
        }

        /// <summary>
        /// Vrne informacije o hotelu
        /// </summary>
        public override string ToString()
        {
            return $"Hotel {Ime} | Sobe: {sobe.Count} | Zaposleni: {zaposleni.Count}";
        }

        /// <summary>
        /// Delegat za obveščanje
        /// </summary>
        /// <param name="sporocilo">Besedilo sporočila</param>
        public delegate void Obvestilo(string sporocilo);

        /// <summary>
        /// Izvede podano funkcijo obvestila
        /// </summary>
        /// <param name="obv">Delegat za obveščanje</param>
        public void Izpisi(Obvestilo obv)
        {
            obv("Hotel deluje");
        }

        /// <summary>
        /// Dogodek, ki se sproži ob dodajanju sobe
        /// </summary>
        public event Obvestilo SobaDodana;
    }
}