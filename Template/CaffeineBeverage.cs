public abstract class CaffeineBeverage
{
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        
        if (CustomerWantsCondiments())
        {
            AddCondiments();
        }
    }

    public abstract void Brew();
    public abstract void AddCondiments();
    public void BoilWater()
    {
        System.Console.WriteLine("Boiling water");
    }

    public void PourInCup()
    {
        System.Console.WriteLine("Pouring into cup");
    }

    public virtual bool CustomerWantsCondiments()
    {
        return true;
    }
}