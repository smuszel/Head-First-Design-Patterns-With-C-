using System;
using System.Linq;

public class RemoteControl
{
    ICommand[] onCommands;
    ICommand[] offCommands;
    ICommand undoCommand;

    public RemoteControl()
    {
        offCommands = new ICommand[7];
        onCommands = new ICommand[7];

        ICommand noCommand = new NoCommand();
        undoCommand = noCommand;

        for (int i = 0; i < 7; i++)
        {
            offCommands[i] = noCommand;
            onCommands[i] = noCommand;
        }
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        onCommands[slot] = onCommand;
        offCommands[slot] = offCommand;
    }

    public void OnButtonPushed(int slot)
    {
        onCommands[slot].Execute();
        undoCommand = onCommands[slot];
    }
    public void OffButtonPushed(int slot)
    {
        offCommands[slot].Execute();
        undoCommand = offCommands[slot];
    }

    public void UndoButtonPushed()
    {
        System.Console.WriteLine("Undoing last command");
        undoCommand.Undo();
    }

    public override string ToString()
    {
        System.Text.StringBuilder stringBuff = new System.Text.StringBuilder();
        stringBuff.Append("\n------ Remote Control ------\n");

        for (int i = 0; i < onCommands.Length; i++)
        {
            string a, b;

            a = onCommands[i].GetType().ToString();
            b = offCommands[i].GetType().ToString();

            stringBuff.Append($"[slot {i}] {a}  {b} \n");
        }

        return stringBuff.ToString();
    }


}
