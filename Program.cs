Console.Write("Podaj liczbę punktów życia: ");
int punktyżycia = int.Parse(Console.ReadLine());
Console.Write("Czy masz klucz?: ");
bool maszklucz = bool.Parse(Console.ReadLine());
Console.Write("Czy znasz hasło?: ");
bool znashaslo = bool.Parse(Console.ReadLine());

if (punktyżycia <= 0)
{
    Console.WriteLine("Nie żyjesz");
}
    else if (punktyżycia > 0 && maszklucz || znashaslo)
{    
     Console.WriteLine("Możesz wejść do lochu");
}
else
{
    Console.WriteLine("Nie możesz wejść do Lochu (nie ma sposobu otwarcia drzwi)");
    
}

























