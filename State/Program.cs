using System;


class Program
{
    static void Main()
    {
        GumballMachine machine = new GumballMachine(4);

        System.Console.WriteLine(machine.ToString());
        machine.InsertQuarter();
        machine.TurnCrank();

        System.Console.WriteLine(machine.ToString());
        machine.InsertQuarter();
        machine.TurnCrank();
        machine.InsertQuarter();
        machine.TurnCrank();

        System.Console.WriteLine(machine.ToString());
    }
}
