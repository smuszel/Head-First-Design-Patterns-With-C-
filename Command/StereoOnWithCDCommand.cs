public class StereoOnWithCDCommand: ICommand
{
    Stereo stereo;

    public StereoOnWithCDCommand(Stereo stereo)
    {
        this.stereo = stereo;
    }

    public void Execute()
    {
        stereo.On();
        stereo.CD = true;
        stereo.Volume = 11;
    }

    public void Undo()
    {
        stereo.Off();
    }
}