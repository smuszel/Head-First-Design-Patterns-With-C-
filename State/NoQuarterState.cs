public class NoQuarterState : IState
{
    GumballMachine machine;

    public NoQuarterState(GumballMachine machine)
    {
        this.machine = machine;
    }

    public void EjectQuarter()
    {
        System.Console.WriteLine("No quarter ejected");
    }

    public void InsertQuarter()
    {
        System.Console.WriteLine("Quarter inserted");
        machine.State = machine.hasQuarterState;
    }

    public void TurnCrank()
    {
        System.Console.WriteLine("Insert quarter first");
    }
    
    public void Dispense()
    {
        System.Console.WriteLine("No gumball dispensed");   
    }
}