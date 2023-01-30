internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //MyClass myclass = new MyClass();

        /*
        // Animal without constructor parameters
        var dog = new Dyr();
        dog.name = "Tom";
        dog.alder = 3;
        dog.art = "Hund";
        dog.DyreInfo();

        var tiger = new Dyr();
        tiger.name = "Tigergutt";
        tiger.alder = 23;
        tiger.art = "Tiger";
        tiger.DyreInfo();

        var drage = new Dyr();
        drage.name = "Charizard";
        drage.alder = 100;
        drage.art = "drage";
        drage.DyreInfo();
        */
 /*       if (myclass.IsInitialized)
        {
            Console.WriteLine("myclass is initalized");

        }
 */
        //Console.WriteLine(myclass);//
        //myclass.greetings();
        // Create a dice
        Dice dice = new Dice();
        // Roll single dice
        Console.WriteLine("Rolled 1: " + dice.Roll());
        // Roll 5 dices
        Console.WriteLine("Rolled 5: " + String.Join(", ", dice.Roll(5)));
    }
    
}

/*oppgave 
 * Lag en klasse som modellerer et dyr
 * klassen skal inneholde informasjon om navn, art og alder.
 * Den skal også inneholde en metode som skriver ut informasjonen
 * Lag 3 forekomster av klassen for 3 valgfrie dyr og bruk forekomstenes utskriftsmetode til å skrive.
 */