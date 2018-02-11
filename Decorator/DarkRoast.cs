public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        Description = "Dark Roast Cofee";
    }

    public override double Cost()
    {
        return .99;
    }
}