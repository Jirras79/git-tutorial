namespace EvidencePojistencu
{
    /// <summary>
    /// Pojištěnec v evidenci
    /// </summary>
    class Pojistenec
    {
        
        public string Jmeno { get; set; }
        
        public string Prijmeni { get; set; }
        
        public int Vek { get; set; }
        
        public string TelefonniCislo { get; set; }

        /// <summary>
        /// Vytvoří instanci pojištěnce
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="vek"></param>
        /// <param name="telefonniCislo"></param>
        public Pojistenec(string jmeno, string prijmeni, int vek, string telefonniCislo)
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
