using Clasa_Persoana;
using Clasa_Carte;

namespace Biblioteca
{
    class Program
    {
        public static void Main()
        {
            List<Persoana> persoane = new List<Persoana>();
            Persoana? persoanaNoua = null;
            string optiune;
        
            do
            {
                Console.WriteLine("C. Citire informatii persoana de la tastatura");
                Console.WriteLine("I. Afisarea informatiilor despre ultima persoana introdusa");
                Console.WriteLine("A. Afisare persoane din lista");
                Console.WriteLine("S. Salvare persoana in lista");
                Console.WriteLine("X. Inchidere program");

                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine()?.ToUpper() ?? string.Empty;

                switch (optiune)
                {
                    case "C":
                        persoanaNoua = CitirePersoanaTastatura();
                        break;

                    case "I":
                        AfisarePersoana(persoanaNoua);
                        break;

                    case "A":
                        AfisarePersoane(persoane);
                        break;

                    case "S":
                        ///persoanaNoua.Nume = persoane.Count + 1;
                        persoane.Add(persoanaNoua);
                        Console.WriteLine("Persoana salvata.");
                        break;

                    case "X":
                        Console.WriteLine("Aplicatia va fi inchisa");
                        return;

                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }

            } while (optiune.ToUpper() != "X") ;

            Console.ReadKey();
        }
        public static Persoana CitirePersoanaTastatura()
        {
            Console.WriteLine("Introduceti numele");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti prenumele");
            string prenume = Console.ReadLine();

            Console.WriteLine("Introduceti numarul de carti imprumutate");
            int.TryParse(Console.ReadLine(), out int nrcarti);

            Persoana persoana = new Persoana { Nume = nume, Prenume = prenume, nrCartiImprumutate = nrcarti };

            return persoana;
        }
        public static void AfisarePersoana(Persoana persoana)
        {
            Console.WriteLine(persoana.Info());

        }
        public static Carte CitireCarteTastatura()
        {
            Console.WriteLine("Introduceti titlul cartii");
            string titlu = Console.ReadLine();

            Console.WriteLine("Introduceti autorul cartii");
            string autor = Console.ReadLine();

            Console.WriteLine("Introduceti editura cartii");
            string editura = Console.ReadLine();

            Carte carte = new Carte { Titlu = titlu, Autor = autor, Editura = editura };
            return carte;
        }
        public static void AfisareCarte(Carte carte)
        {
            Console.WriteLine(carte.Info());
        }
        public static void AfisarePersoane(List<Persoana> persoane)
        {
            Console.WriteLine("Persoanele sunt: ");

            foreach (var persoana in persoane)
            {
                AfisarePersoana(persoana);
            }
        }

        /*public static void AfisarePersoanePesteNrCartiImprumutate(List<Persoana> persoane)
        {
            Console.WriteLine("Persoanele sunt:");

            var persoaneSelectate = persoane
                                    .Where(persoana => nrCartiImprumutate > 10);

            foreach (Persoana persoana in persoaneSelectate)
            {
                AfisarePersoana(persoana);
            }
        }*/

    }
}

