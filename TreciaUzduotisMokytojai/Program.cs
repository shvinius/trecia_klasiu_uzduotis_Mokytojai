using System;

namespace TreciaUzduotisMokytojai
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
             List<Mokytojas> mokytojasList = new List<Mokytojas>();

            mokytojasList = NuskaitytiKelisMokytojus();
            Console.WriteLine("----------------------");
            IsvestiKelisMokytojus(mokytojasList);
             

        }
        /// <summary>
        /// Funkcija nuskaito Mokytojo objekta is konsoles.
        /// </summary>
        /// <returns>Mokytojo objekta</returns>
        
        static Mokytojas NuskaitytiMokytoja()
        {
            Mokytojas mokytojas = new Mokytojas();

            Console.WriteLine("Įveskite mokytojo vardą: ");
            string vardas = Console.ReadLine(); 
            mokytojas.Vardas = vardas;

            Console.WriteLine("Įveskite mokytojo pavardę: ");
            string pavarde = Console.ReadLine(); 
            mokytojas.Pavarde = pavarde;

            Console.WriteLine("Įveskite mokytojo auklėtinių klasę: ");
            string klase = Console.ReadLine();
            mokytojas.Klase = klase;

            Console.WriteLine("Įveskite mokytojo pareigas: ");
            string pareigos = Console.ReadLine();
            mokytojas.Pareigos = pareigos;

            Console.WriteLine("Įveskite mokytojo stažą: ");
            int stazas = Convert.ToInt32(Console.ReadLine());
            mokytojas.Stazas = stazas;

            Console.WriteLine("Įveskite mokytojo išsilavinimą: ");
            string issilavinimas = Console.ReadLine();
            mokytojas.Issilavinimas = issilavinimas;

            return mokytojas;
        }
        static List<Mokytojas> NuskaitytiKelisMokytojus()
        {
            List<Mokytojas> mokytojasList = new List<Mokytojas>();
            int kiekis;

            Console.WriteLine("Įveskite mokytoju kiekį: ");
            kiekis = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiekis; i++)
            {
                mokytojasList.Add(NuskaitytiMokytoja());
            }
            return mokytojasList;
        }
        /// <summary>
        /// Funkcija isveda viena Mokytoja i konsele.
        /// </summary>
        /// <param name="mokytojas">Mokytojas objektas, kuri isvedines i konsole.</param>
        static void IsvestiMokytoja (Mokytojas mokytojas)
        {
            Console.WriteLine("Vardas: " + mokytojas.Vardas);
            Console.WriteLine("Pavardė: " + mokytojas.Pavarde);
            Console.WriteLine("Klasė: " + mokytojas.Klase);
            Console.WriteLine("Pareigos: " + mokytojas.Pareigos);
            Console.WriteLine("Stažas: " + mokytojas.Stazas);
            Console.WriteLine("Išsilavinimas: " + mokytojas.Issilavinimas);
        }
        
        /// <summary>
        /// Funkcija isveda kelis mokytojus (sarasa) i konsole
        /// </summary>
        /// <param name="mokytojasList">Mokytoju Listas kuri isvedines i konsole </param>
        static void IsvestiKelisMokytojus(List<Mokytojas> mokytojasList)
        {
            foreach (Mokytojas mokytojas in mokytojasList)
            {
                IsvestiMokytoja(mokytojas);
                Console.WriteLine("----------------");

            }
        }

        
    }
}