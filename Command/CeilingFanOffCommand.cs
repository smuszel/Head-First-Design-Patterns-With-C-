public class CeilingFanOffCommand: ICommand
{
    CeilingFan fan;

    public CeilingFanOffCommand(CeilingFan fan)
    {
        this.fan = fan;
    }

    public void Execute()
    {
        fan.PrevSpeed = fan.Speed;
        fan.Off();
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