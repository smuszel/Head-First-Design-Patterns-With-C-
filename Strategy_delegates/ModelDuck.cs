
public class ModelDuck : Duck
{
    public ModelDuck()
    {
        Quack = Program.NormalQuack;
        Fly = Program.FlyNoWay;
    }

    public void Display()
    {
        System.Console.WriteLine("I'am a model duck");
    }
}