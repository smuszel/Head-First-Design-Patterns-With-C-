
public class MallardDuck : Duck
{
    public MallardDuck()
    {
        quackBehaviour = new CasualQuack();
        flyBehaviour = new FlyWithWings();
    }    

    public void Display()
    {
        System.Console.WriteLine("I'am a real Mallard duck");
    }
}