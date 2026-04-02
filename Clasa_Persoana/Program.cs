namespace Clasa_Persoana
{
    public class Persoana
    {
        private const char SEPARATOR = ' ';
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int nrCartiImprumutate { get; set; }
        public Persoana()
        {
            Nume = string.Empty;
            Prenume = string.Empty;
            nrCartiImprumutate = 0;
        }
        public Persoana(string nume, string prenume, int nrcarti)
        {
            Nume = nume;
            Prenume = prenume;
            nrCartiImprumutate = nrcarti;
        }
        public enum TipCarte
        {
            Thriller = 1,
            Basm = 2,
            Horror = 3,
            Aventura = 4,
            Actiune = 5,
        };
        public string Info()
        {
            string info = $"Nume:{Nume ?? "NECUNOSCUT"} Prenume:{Prenume ?? "NECUNOSCUT"}  CartiImprumutate: {nrCartiImprumutate}";
            return info;
        }
    }
}
class Program
{
    static void Main()
    {

    }
}