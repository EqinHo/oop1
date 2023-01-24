internal class Dyr
{
     public string name;
     public string art;
     public int alder;
    
    public Dyr()
    { 
    
    }
    public void DyreInfo()
    {
        Console.WriteLine($"{Environment.NewLine}Dyreinfo: {name} er en {art} som er {alder} år gammel.");
    }
}