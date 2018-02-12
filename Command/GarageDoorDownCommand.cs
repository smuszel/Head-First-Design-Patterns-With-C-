public class GarageDoorDownCommand: ICommand
{
    GarageDoor door;

    public GarageDoorDownCommand(GarageDoor door)
    {
        this.door = door;
    }

    public void Execute()
    {
        door.Down();
    }

    public void Undo()
    {
        door.Up();
    }
}