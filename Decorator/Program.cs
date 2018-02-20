class Program
{
    static void Main()
    {
        Beverage beverage0 = new Espresso();
        System.Console.WriteLine($"{beverage0.GetDescription()} {beverage0.Cost()} $");

        Beverage beverage1 = new DarkRoast();
        beverage1 = new Mocha(beverage1);
        beverage1 = new Mocha(beverage1);
        beverage1 = new Whip(beverage1);
        System.Console.WriteLine($"{beverage1.GetDescription()} {beverage1.Cost()} $");

        Beverage beverage2 = new HouseBlend();
        beverage2 = new Soy(beverage2);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Whip(beverage2);
        System.Console.WriteLine($"{beverage2.GetDescription()} {beverage2.Cost()} $");
    }
}
