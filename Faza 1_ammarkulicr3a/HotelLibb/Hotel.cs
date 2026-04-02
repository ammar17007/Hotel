using System.Collections.Generic;
using System.Linq;

namespace HotelLibb
{
    public class Hotel
    {
        public string Ime { get; set; }

        private List<Soba> sobe = new List<Soba>();
        private List<Zaposleni> zaposleni = new List<Zaposleni>();

        public static int SteviloHotelov = 0;

        public Hotel()
        {
            SteviloHotelov++;
        }

        public Hotel(string ime)
        {
            Ime = ime;
            SteviloHotelov++;
        }

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

        public void DodajSobo(Soba s)
        {
            sobe.Add(s);

            if (SobaDodana != null)
            {
                SobaDodana("Dodana soba: " + s.Stevilka);
            }
        }

        public void DodajZaposlenega(Zaposleni z)
        {
            zaposleni.Add(z);
        }

        public override string ToString()
        {
            return $"Hotel {Ime} | Sobe: {sobe.Count} | Zaposleni: {zaposleni.Count}";
        }

        public delegate void Obvestilo(string sporocilo);

        public void Izpisi(Obvestilo obv)
        {
            obv("Hotel deluje");
        }

        public event Obvestilo SobaDodana;


    }
}
