public class Mocha: CondimentDecorator
{
    Beverage beverage;

    public Mocha(Beverage beverage)
    {
        this.beverage = beverage;
    }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Mocha";
    }

    public override double Cost()
    {
        return beverage.Cost() + .2;
    }
}