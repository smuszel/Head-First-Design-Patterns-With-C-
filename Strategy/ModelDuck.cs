
public class ModelDuck : Duck
{
    public ModelDuck()
    {
        quackBehaviour = new CasualQuack();
        flyBehaviour = new FlyNoWay();
    }

    public void Display()
    {
        System.Console.WriteLine("I'am a model duck");
    }
}