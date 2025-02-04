namespace EvidencePojistencu
{
    /// <summary>
    /// Správa záznamů
    /// </summary>
    class Databaze
    {
        /// <summary>
        /// Kolekce záznamů
        /// </summary>
        private List<Pojistenec> pojistenci;

        /// <summary>
        /// Vytvoří instanci databaze
        /// </summary>
        public Databaze()
        {
            pojistenci = new List<Pojistenec>();
        }

        /// <summary>
        /// Přidá nového pojištěnce
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="vek"></param>
        /// <param name="telefonniCislo"></param>
        public void PridejPojistence(string jmeno, string prijmeni, int vek, int telefonniCislo)
        {
            pojistenci.Add(new Pojistenec(jmeno, prijmeni, vek, telefonniCislo));
        }

        /// <summary>
        /// Najde pojištěnce podle jména a příjmení
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <returns></returns>
        public List<Pojistenec> NajdiPojistence(string jmeno, string prijmeni)
        {
            List<Pojistenec> nalezeny = new List<Pojistenec>();
            foreach (Pojistenec p in pojistenci)
            {
                if ((p.Jmeno == jmeno) && (p.Prijmeni == prijmeni))
                    nalezeny.Add(p);
            }
            return nalezeny;
        }


        public List<Pojistenec> VypisPojistence()
        {
            return pojistenci;
        }
    }

}
