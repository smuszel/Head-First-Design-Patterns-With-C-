public class Tea: CaffeineBeverage
{
    public override void Brew()
    {
        System.Console.WriteLine("Steeping the tea");
    }

    public override void AddCondiments()
    {
        System.Console.WriteLine("Adding the lemon");
    }
}