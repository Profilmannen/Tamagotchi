Tamagotchi tama = new();

Console.WriteLine("Välj ett namn till din Tamagotchi");
tama.name = Console.ReadLine();

Console.WriteLine($"Bra! {tama.name} är ett väldigt fint namn :)");

while (tama.GetAlive() == true)
{
    Console.Clear();
    tama.PrintStats();
    Console.WriteLine("Vad vill du göra nu?");
    Console.WriteLine($"1. Lär {tama.name} ett nytt ord");
    Console.WriteLine($"2. Prata med {tama.name}");
    Console.WriteLine($"3. Mata {tama.name}");
    Console.WriteLine($"4. Gör ingenting");

    string doWhat = Console.ReadLine();
    if (doWhat == "1")
    {
        Console.WriteLine("Vilket ord");
        string ord = Console.ReadLine();
        tama.teach(ord);
    
    }

    if (doWhat == "2")
    {
        tama.Hi();
    }

    if (doWhat == "3")
    {
        tama.Feed();
    }

  
    
    if (doWhat == "4")
    {
        Console.WriteLine("Gör inget...");
    }


    tama.Tick();
    Console.WriteLine("klicka enter för att fortsätta");
    Console.ReadLine();
}

Console.WriteLine($"Nej! {tama.name} är död");
Console.WriteLine("Klicka enter för att avsluta");





Console.ReadLine();