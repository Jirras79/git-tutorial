using EvidencePojistencu;

Evidence evidence = new Evidence();
char volba = '0';
while (volba != '4')
{
    evidence.VypisUvodniObrazovku();
    volba = Console.ReadKey().KeyChar;
    switch (volba)
    {
        case '1':
            evidence.PridejPojistence();
            break;
        case '2':
            evidence.ZobrazVsechnyPojistence();
            break;
        case '3':
            evidence.VyhledejPojistence();
            break;
        case '4':
            Console.WriteLine("\nLibovolnou klávesou ukončíte program...");
            break;
        default:
            Console.WriteLine("\nNeplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
            break;
    }
    Console.WriteLine("\nPro pokračování stiskni libovolnou klávesu...");
    Console.ReadKey();
}
