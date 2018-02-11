public class Whip : CondimentDecorator
{
    Beverage beverage;

    public Whip(Beverage beverage)
    {
        this.beverage = beverage;
    }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Whip";
    }

    public override double Cost()
    {
        return beverage.Cost() + .1;
    }
}