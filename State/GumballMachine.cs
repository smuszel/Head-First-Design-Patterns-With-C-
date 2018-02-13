public class GumballMachine
{
    public readonly IState soldOutState;
    public readonly IState noQuarterState;
    public readonly IState hasQuarterState;
    public readonly IState soldState;
    public readonly IState winnerState;

    public IState State { get; set; }
    public int Count { get; set; }

    public GumballMachine(int numberGumballs)
    {
        soldOutState = new SoldOutState(this);
        noQuarterState = new NoQuarterState(this);
        hasQuarterState = new HasQuarterState(this);
        soldState = new SoldState(this);
        winnerState = new WinnerState(this);

        Count = numberGumballs;

        if (Count > 0 )
        {
            State = noQuarterState;
        }
        else
        {
            State = soldOutState;
        }
    }
    public void InsertQuarter()
    {
        State.InsertQuarter();
    }

    public void EjectQuarter()
    {
        State.EjectQuarter();
    }

    public void TurnCrank()
    {
        State.TurnCrank();
        State.Dispense();
    }

    public void ReleaseBall()
    {
        System.Console.WriteLine("A gumball comes rolling out the slot...");
        if (Count > 0)
        {
            Count--;
        }
    }

    public override string ToString()
    {
        return $"Inventory {Count} gumballs";
    }
}