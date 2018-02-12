using System;
using System.Linq;
using System.Collections.Generic;

public class RemoteControlLambdas
{
    Action[] onCommands;
    Action[] offCommands;
    public RemoteControlLambdas()
    {
        offCommands = new Action[7];
        onCommands = new Action[7];

        Action noCommand = () => { };

        for (int i = 0; i < 7; i++)
        {
            offCommands[i] = noCommand;
            onCommands[i] = noCommand;
        }
    }

    public void SetCommand(int slot, Action onCommand, Action offCommand)
    {
        onCommands[slot] = onCommand;
        offCommands[slot] = offCommand;
    }

    public void OnButtonPushed(int slot)
    {
        onCommands[slot].Invoke();
    }
    public void OffButtonPushed(int slot)
    {
        offCommands[slot].Invoke();
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
