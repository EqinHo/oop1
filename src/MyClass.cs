internal class MyClass
{
    public bool IsInitialized;
    public MyClass()
    {
        Console.WriteLine("Hello, World from Class MyClass!");
        IsInitialized = true;
    }
    public override string ToString()
    {
        return "MyClass.IsInitialized : " + IsInitialized;
    }
    public void greetings() 
    {
        Console.WriteLine("What is your name?");
        // ask for name
        var name = Console.ReadLine();
        // get date now
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
    }
}