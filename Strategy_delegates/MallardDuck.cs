
public class MallardDuck : Duck
{
    public MallardDuck()
    {
        Quack = Program.NormalQuack;
        Fly = Program.FlyWithWings;
    }    

    public void Display()
    {
        System.Console.WriteLine("I'am a real Mallard duck");
    }
}