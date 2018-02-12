public class GarageDoorUpCommand: ICommand
{
    GarageDoor door;

    public GarageDoorUpCommand(GarageDoor door)
    {
        this.door = door;
    }

    public void Execute()
    {
        door.Up();
    }
    public void Undo()
    {
        door.Down();
    }
}