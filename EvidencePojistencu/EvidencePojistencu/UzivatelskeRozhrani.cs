namespace EvidencePojistencu
{
    /// <summary>
    /// Třída reprezentuje uživatelské rozhraní pro zadávání pojištěnců
    /// </summary>
    class UzivatelskeRozhrani
    {
        /// <summary>
        /// Databáze s pojištěnci
        /// </summary>
        private Databaze databaze;

        /// <summary>
        /// Vytvoří novou evidenci pojištěnců
        /// </summary>
        public UzivatelskeRozhrani()
        {
            databaze = new Databaze();
        }

        /// <summary>
        /// Vyzve k zadání jména nebo přijmení pojištěnce
        /// </summary>
        /// <returns></returns>
        private string ZjistiJmeno(string typ)
        {
            Console.Write($"\n\nZadejte {typ}: ");
            string jmeno;
            while (string.IsNullOrEmpty(jmeno = Console.ReadLine()))
            {
                Console.Write($"Zadejte {typ} znovu: ");
            }
            return jmeno;
        }


        /// <summary>
        /// Vyzve k zadání věku pojištěnce
        /// </summary>
        /// <returns></returns>
        private int ZjistiVek()
        {
            Console.Write("\nZadejte věk:");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek))
            {
                Console.Write("Zadejte věk znovu: ");
            }
            return vek;
        }

        /// <summary>
        /// Vyzve k zadání telefonního čísla
        /// </summary>
        /// <returns></returns>
        private string ZjistiTelefonniCislo()
        {
            Console.Write("\nZadejte telefonní číslo:");
            string telefonniCislo;
            while (string.IsNullOrEmpty(telefonniCislo = Console.ReadLine()))
            {
                Console.Write("Zadejte telefonní číslo znovu: ");
            }
            return telefonniCislo;
        }

        /// <summary>
        /// Vyzve k přidání pojištěnce a uloží do databáze
        /// </summary>
        public void PridejPojistence()
        {
            string jmeno = ZjistiJmeno("jméno");
            string prijmeni = ZjistiJmeno("příjmení");
            int vek = ZjistiVek();
            string telefonniCislo = ZjistiTelefonniCislo();
            databaze.PridejPojistence(jmeno, prijmeni, vek, telefonniCislo);
            Console.WriteLine("\nZáznam byl přidán.");
        }

        /// <summary>
        /// Vyhledá pojištěnce podle jména a příjmení
        /// </summary>
        public void VyhledejPojistence()
        {
            string jmeno = ZjistiJmeno("jméno");
            string prijmeni = ZjistiJmeno("příjmení");
            List<Pojistenec> pojistenci = databaze.NajdiPojistence(jmeno, prijmeni);
            if (pojistenci.Count > 0)
            {
                Console.WriteLine("\n\n----------- Seznam nalezených pojištěnců -------------");
                foreach (Pojistenec p in pojistenci)
                {
                    Console.WriteLine(p);
                }
            }
            else
            {
                Console.WriteLine("Nebyly nalezeny žádné záznamy.");
            }
        }

        /// <summary>
        /// Zobrazí všechny pojištěnce v evidenci.
        /// </summary>
        public void ZobrazVsechnyPojistence()
        {
            IList<Pojistenec> pojistenci = databaze.VratPojistence();
            if (pojistenci.Count > 0)
            {
                Console.WriteLine("\n\n-------------- Seznam všech pojištěnců ---------------");
                foreach (Pojistenec p in pojistenci)
                {
                    Console.WriteLine(p);
                }
            }
            else
            {
                Console.WriteLine("V evidenci nejsou žádní pojištěnci.");
            }
        }
        /// <summary>
        /// Vypíše úvodní obrazovku
        /// </summary>
        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("\n--- Evidence pojištěných ---");
            Console.WriteLine("\n1. Přidat pojištěného");
            Console.WriteLine("2. Zobrazit všechny pojištěné");
            Console.WriteLine("3. Vyhledat pojištěného");
            Console.WriteLine("4. Ukončit");
            Console.Write("\nZadejte možnost: ");
        }
    }

}
