using System;
public class HasQuarterState : IState
{
    GumballMachine machine;
    Random randomWinner;

    public HasQuarterState(GumballMachine machine)
    {
        this.machine = machine;
    }

    public void EjectQuarter()
    {
        System.Console.WriteLine("Quarter returned");
        machine.State = machine.noQuarterState;
    }

    public void InsertQuarter()
    {
        System.Console.WriteLine("You cannot insert another quarter");
    }

    public void TurnCrank()
    {
        System.Console.WriteLine("You turned...");

        randomWinner = new Random();
        int i = randomWinner.Next(1, 10);

        if (i == 1)
        {
            machine.State = machine.winnerState;
        }
        else
        {
            machine.State = machine.soldState;
        }
    }

    public void Dispense()
    {
        System.Console.WriteLine("No gumball dispensed");
    }
}