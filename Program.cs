internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //MyClass myclass = new MyClass();

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

 /*       if (myclass.IsInitialized)
        {
            Console.WriteLine("myclass is initalized");

        }
 */
        //Console.WriteLine(myclass);//
        //myclass.greetings();
       
      
    }
    
}

/*oppgave 
 * Lag en klasse som modellerer et dyr
 * klassen skal inneholde informasjon om navn, art og alder.
 * Den skal også inneholde en metode som skriver ut informasjonen
 * Lag 3 forekomster av klassen for 3 valgfrie dyr og bruk forekomstenes utskriftsmetode til å skrive.
 */