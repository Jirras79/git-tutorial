namespace EvidencePojistencu
{
    /// <summary>
    /// Třída reprezentuje Evidenci pojištěnců
    /// </summary>
    class Evidence
    {
        /// <summary>
        /// Databáze s pojištěnci
        /// </summary>
        private Databaze databaze;




        /// <summary>
        /// Vytvoří novou evidenci
        /// </summary>
        public Evidence()
        {
            databaze = new Databaze();
        }
        /// <summary>
        /// Vyzve k zadání jména pojištěnce
        /// </summary>
        /// <returns></returns>
        private string ZjistiJmeno()
        {
            Console.Write("\n\nZadejte jméno: ");
            string jmeno;
            while (string.IsNullOrEmpty(jmeno = Console.ReadLine()))
            {
                Console.Write("Zadejte jméno znovu: ");
            }
            return jmeno;
        }
        /// <summary>
        /// Vyzve k zadání příjmení pojištěnce
        /// </summary>
        /// <returns></returns>
        private string ZjistiPrijmeni()
        {
            Console.Write("\nZadejte příjmení: ");
            string prijmeni;
            while (string.IsNullOrEmpty(prijmeni = Console.ReadLine()))
            {
                Console.Write("Zadejte příjmení znovu: ");
            }
            return prijmeni;
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
        private int ZjistiTelefonniCislo()
        {
            Console.Write("\nZadejte telefonní číslo:");
            int telefonniCislo;
            while (!int.TryParse(Console.ReadLine(), out telefonniCislo))
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
            string jmeno = ZjistiJmeno();
            string prijmeni = ZjistiPrijmeni();
            int vek = ZjistiVek();
            int telefonniCislo = ZjistiTelefonniCislo();
            databaze.PridejPojistence(jmeno, prijmeni, vek, telefonniCislo);
            Console.WriteLine("\nZáznam byl přidán.");
        }

        /// <summary>
        /// Vyhledá pojištěnce podle jména a příjmení
        /// </summary>
        public void VyhledejPojistence()
        {
            string jmeno = ZjistiJmeno();
            string prijmeni = ZjistiPrijmeni();
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
            List<Pojistenec> pojistenci = databaze.VypisPojistence();
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
