using System;


class Program
{
    static void Main()
    {
        MallardDuck duck = new MallardDuck();
        WildTurkey turkey = new WildTurkey();
        TurkeyAdapter turkeyAdapter = new TurkeyAdapter(turkey);

        System.Console.WriteLine("The tukey says...");
        turkeyAdapter.Quack();
        turkeyAdapter.Fly();

        System.Console.WriteLine("\nThe Duck says...");
        duck.Quack();
        duck.Fly();

    }
}
