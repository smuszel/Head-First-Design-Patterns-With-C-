public class Duck
{
    public IQuack quackBehaviour;
    public IFly flyBehaviour;

    public void PerformQuack()
    {
        quackBehaviour.Quack();
    }
    
    public void PerformFly()
    {
        flyBehaviour.Fly();
    }

    public void SetQuackBehaviour(IQuack qb)
    {
        quackBehaviour = qb;
    }

    public void SetFlyBehaviour(IFly fb)
    {
        flyBehaviour = fb;
    }

    public void Swim()
    {
        System.Console.WriteLine("All duck float, even decoys!");
    }
}