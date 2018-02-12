using System;
public class MacroCommand: ICommand
{
    ICommand[] commands;
    public MacroCommand(ICommand[] commands)
    {
        this.commands = commands;
    }

    public void Execute()
    {
        foreach (ICommand c in commands)
        {
            c.Execute();
        }
    }

    public void Undo()
    {
        Array.Reverse(commands);
        foreach (ICommand c in commands)
        {
            c.Undo();
        }
        Array.Reverse(commands);
    }
}