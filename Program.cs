internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        MyClass myclass = new MyClass();
 /*       if (myclass.IsInitialized)
        {
            Console.WriteLine("myclass is initalized");

        }
 */
        Console.WriteLine(myclass);//
        myclass.greetings();
        bool test = true;
      
    }
    
}