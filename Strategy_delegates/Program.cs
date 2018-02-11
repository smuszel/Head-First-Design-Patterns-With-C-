using System;


class Program
{
    static void Main(string[] args)
    {
        Duck mallard = new MallardDuck();
        mallard.Quack();
        mallard.Fly();

        Duck model = new ModelDuck();
        model.Fly();
        model.Fly = FlyRocketPowered;
        model.Fly();
    }

    public static void NormalQuack()
    {
        System.Console.WriteLine("Quack");
    }
    public static void FlyWithWings()
    {
        System.Console.WriteLine("I'm flying");
    }

    public static void FlyRocketPowered()
    {
        System.Console.WriteLine("I'm flying with a rocket!");
    }

    public static void FlyNoWay()
    {
        System.Console.WriteLine("I can't fly");
    }
}
