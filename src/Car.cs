internal class Car
{
    string color = "red";
    int maxspeed = 350;
    string karosseri = "cabriolet";


    static void main(string[] args)
    {
        Car myObj1 = new Car();
        Car myObj2 = new Car();
        Car myObj3 = new Car();

        Console.Write(myObj3.karosseri);
        Console.WriteLine(myObj1.color);
        Console.WriteLine(myObj2.maxspeed);

    }

}
