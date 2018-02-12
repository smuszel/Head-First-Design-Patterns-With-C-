public class CeilingFanMediumCommand : ICommand
{
    CeilingFan fan;

    public CeilingFanMediumCommand(CeilingFan fan)
    {
        this.fan = fan;
    }

    public void Execute()
    {
        fan.PrevSpeed = fan.Speed;
        fan.Medium();
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