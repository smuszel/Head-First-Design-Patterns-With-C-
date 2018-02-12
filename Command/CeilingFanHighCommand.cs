public class CeilingFanHighCommand: ICommand
{
    CeilingFan fan;

    public CeilingFanHighCommand(CeilingFan fan)
    {
        this.fan = fan;
    }

    public void Execute()
    {
        fan.PrevSpeed = fan.Speed;
        fan.High();
    }

    public void Undo()
    {
        switch (fan.PrevSpeed)
        {
            case (int)CeilingFan.speeds.HIGH:
                fan.High();
                break;
            case (int)CeilingFan.speeds.MEDIUM:
                fan.Medium();
                break;
            case (int)CeilingFan.speeds.LOW:
                fan.Low();
                break;
            case (int)CeilingFan.speeds.OFF:
                fan.Off();
                break;
        }
    }
}