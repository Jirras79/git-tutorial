namespace EvidencePojistencu
{
    /// <summary>
    /// Pojištěnec v evidenci
    /// </summary>
    class Pojistenec
    {
        /// <summary>
        /// Jméno pojištěnce
        /// </summary>
        public string Jmeno { get; set; }
        /// <summary>
        /// Příjmení pojištěnce
        /// </summary>
        public string Prijmeni { get; set; }
        /// <summary>
        /// Věk pojištěnce
        /// </summary>
        public int Vek { get; set; }
        /// <summary>
        /// Telefonní číslo pojištěnce
        /// </summary>
        public int TelefonniCislo { get; set; }

        /// <summary>
        /// Vytvoří instanci pojištěnce
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="vek"></param>
        /// <param name="telefonniCislo"></param>
        public Pojistenec(string jmeno, string prijmeni, int vek, int telefonniCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }

        public override string ToString()
        {
            return $"{Jmeno,-10} {Prijmeni,-15} Věk: {Vek,-3} Telefon: {TelefonniCislo}";
        }
    }

}
