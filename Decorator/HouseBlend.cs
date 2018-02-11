public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        Description = "House Blend Cofee";
    }

    public override double Cost()
    {
        return .89;
    }
}