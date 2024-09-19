public class Tamagotchi
{
    private int hunger;

    private int boredom;

    private bool isAlive;

    private List<string> words = new List<string>() {"hej"};

    public string name;

    public Tamagotchi()
    {
        isAlive = true;
    }

    

    public void Feed()
    {
        Console.WriteLine($"[{name}] äter och blir mindre hungrig");
        hunger -= 2;
        if (hunger < 0);
        {
            hunger = 0;
        }

    }

    public void Hi()
    {
        int wordNum = Random.Shared.Next(words.Count);
        Console.WriteLine($"[{name}] says: {words[wordNum]}");
        ReduceBoredom();


    }

    public void Tick()
    {
        hunger++;
        boredom++;
        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }

    }

    public void PrintStats()
    {
        Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {boredom} || Vocabulary: {words.Count} words");

    }

    private void ReduceBoredom()
    {
        Console.WriteLine($"[{name}] är nu mindre utråkad");

        boredom -= 2;
        if (boredom < 0)
        {
            boredom = 0;
        }

    }

    public void teach(string ord)
    {
        Console.WriteLine($"[{name}] learns: {ord}");
        words.Add(ord);
        ReduceBoredom();
    }

    public bool GetAlive()
    {
        return isAlive;
    }
}


