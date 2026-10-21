int pktdoswiadczenia = 50;
int ilosczlota = 8;
int treningi = 0;

Console.WriteLine("=== Przed treningiem na arenie ===");
Console.WriteLine($"Punkty Doświadczenia: {pktdoswiadczenia}");
Console.WriteLine($"Złoto: {ilosczlota}");
Console.WriteLine($"Treningi: {treningi}");
Console.WriteLine("");



pktdoswiadczenia += 25;


Console.WriteLine("=== Po treningu na arenie ===");
Console.WriteLine($"Punkty Doświadczenia: {pktdoswiadczenia}");
Console.WriteLine($"Złoto: {ilosczlota}");
Console.WriteLine($"Treningi: {treningi}");
Console.WriteLine("");

pktdoswiadczenia *= 2;
ilosczlota -= 8;
treningi += 1;
ilosczlota += 15;

Console.WriteLine("=== Po treningu na arenie ===");
Console.WriteLine($"Punkty Doświadczenia: {pktdoswiadczenia}");
Console.WriteLine($"Złoto: {ilosczlota}");
Console.WriteLine($"Treningi: {treningi}");
Console.WriteLine("");







