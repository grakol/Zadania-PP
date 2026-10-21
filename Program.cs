Console.Write("Podaj swój wiek: ");
int wiek = int.Parse(Console.ReadLine());

if (wiek < 0)
{
    Console.WriteLine("Niepoprawny wiek.");
}
else if (wiek < 13)
{
    Console.WriteLine("Dziecko");
}
else if (wiek < 18)
{
    Console.WriteLine("Nastolatek");
}
else if (wiek < 65)
{
    Console.WriteLine("Dorosły");
}
else if (wiek >= 65)
{
    Console.WriteLine("Senior");
}
























