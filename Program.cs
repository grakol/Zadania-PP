Console.Write("Podaj liczbę punktów życia: ");
int PodajLiczbeŻycia = int.Parse(Console.ReadLine());
Console.Write("Podaj liczbę mikstur: ");
int PodajLiczbeMikstur = int.Parse(Console.ReadLine());
Console.Write("Czy masz klucz?: ");
bool PodajCzyMaKlucz = bool.Parse(Console.ReadLine());
Console.Write("Czy masz mapę?: ");
bool PodajCzyMaMape = bool.Parse(Console.ReadLine());
Console.WriteLine();

bool zyje = PodajLiczbeŻycia > 0;
bool maPelneZdrowie = PodajLiczbeŻycia == 100;
bool maZaopatrzenie = PodajLiczbeMikstur > 0;
bool maPrzedmiotNawigacyjny =  PodajCzyMaKlucz == true || PodajCzyMaMape == true;
bool gotowyDoWyprawy = zyje && maPelneZdrowie && maZaopatrzenie && maPrzedmiotNawigacyjny;
bool wymagaleczeia = !maPelneZdrowie;

Console.WriteLine($"Żyje: {zyje}");
Console.WriteLine($"Ma pełne zdrowie: {maPelneZdrowie}");
Console.WriteLine($"Wymaga leczenia: {wymagaleczeia}");
Console.WriteLine($"Ma zaopatrzenie: {maZaopatrzenie}");
Console.WriteLine($"Ma klucz lub mapę: {maPrzedmiotNawigacyjny}");
Console.WriteLine($"Gotowy do wyprawy: {gotowyDoWyprawy}");




















