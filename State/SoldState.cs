public class SoldState : IState
{
    GumballMachine machine;
    
    public SoldState(GumballMachine machine)
    {
        this.machine = machine;
    }
    public void EjectQuarter()
    {
        System.Console.WriteLine("Sorry, you already turned the crank");
    }

    public void InsertQuarter()
    {
        System.Console.WriteLine("Please wait, we're already giving you a gumball");
    }

    public void TurnCrank()
    {
        System.Console.WriteLine("Turning twice doesn't get you another gumball!");
    }
    public void Dispense()
    {
        machine.ReleaseBall();

        if (machine.Count > 0)
        {
            machine.State = machine.noQuarterState;
        }
        else
        {
            System.Console.WriteLine("Oops, out of gumballs!");
            machine.State = machine.soldOutState;
        }
    }
}