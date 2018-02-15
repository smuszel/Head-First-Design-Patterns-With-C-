public class Coffee : CaffeineBeverage
{
    public override void Brew()
    {
        System.Console.WriteLine("Dripping Coffee through filter");
    }

    public override void AddCondiments()
    {
        System.Console.WriteLine("Adding Sugar and Milk");
    }

    public override bool CustomerWantsCondiments()
    {
        string answer = GetUserInput();

        if (answer.ToLower().StartsWith('y'))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    string GetUserInput()
    {
        System.Console.WriteLine("Would you like milk and sugar with your cofee (y/n)?");
        return System.Console.ReadLine();
    }
}