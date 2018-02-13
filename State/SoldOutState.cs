public class SoldOutState : IState
{
    GumballMachine machine;
    
    public SoldOutState(GumballMachine machine)
    {
        this.machine = machine;
    }

    public void EjectQuarter()
    {
        System.Console.WriteLine("Insert quarter first");
    }

    public void InsertQuarter()
    {
        System.Console.WriteLine("Machine does not accept quarters when empty");
    }

    public void TurnCrank()
    {
        System.Console.WriteLine("You turned, there are no gumballs");
    }

    public void Dispense()
    {
        System.Console.WriteLine("No gumballs dispensed");    
    }
}