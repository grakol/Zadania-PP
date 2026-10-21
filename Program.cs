Console.Write("Podaj liczbę racji żywnościowych: ");
int PodajLiczbeRacji = int.Parse(Console.ReadLine());
Console.Write("Podaj liczbę członków drużyny: ");
int PodajLiczbeCzlonkow = int.Parse(Console.ReadLine());
Console.Write("Podaj liczbę dni: ");
int PodajLiczbeDni = int.Parse(Console.ReadLine());

int pełnychracjiotrzyma = PodajLiczbeRacji / PodajLiczbeCzlonkow;
int pozostałeracje = PodajLiczbeRacji % PodajLiczbeCzlonkow;
double dziennaracjanacałądrużynę = (double)PodajLiczbeRacji / PodajLiczbeDni;
double średnialiczbaracjinaosobę = dziennaracjanacałądrużynę / PodajLiczbeCzlonkow;
Console.WriteLine($"Każdy członek drużyny otrzyma {pełnychracjiotrzyma} pełnych racji żywnościowych.");
Console.WriteLine($"Pozostało {pozostałeracje} racji żywnościowych.");
Console.WriteLine($"Dzienna racja na całą drużynę {dziennaracjanacałądrużynę} racji żywnościowych.");
Console.WriteLine($"Średnia liczba racji na osobę wynosi {średnialiczbaracjinaosobę} racji żywnościowych.");
















