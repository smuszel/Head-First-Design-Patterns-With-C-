using System;

class ProgramWithLambdas
{
    static void Main()
    {
        RemoteControlLambdas remoteControl = new RemoteControlLambdas();
        
        Light livingRoomLight = new Light("Living Room");
        Light kitchenLight = new Light("Kitchen");
        CeilingFan ceilingFan = new CeilingFan("Living Room");
        GarageDoor garageDoor = new GarageDoor("");
        Stereo stereo = new Stereo("Living Room");


        remoteControl.SetCommand(0, () => livingRoomLight.On(), () => livingRoomLight.Off());
        remoteControl.SetCommand(1, () => kitchenLight.On(), () => kitchenLight.Off());
        remoteControl.SetCommand(2, () => stereo.On(), () => stereo.Off());
        remoteControl.SetCommand(3, () => ceilingFan.Low(), () => ceilingFan.Off());
        remoteControl.SetCommand(4, () => ceilingFan.Medium(), () => ceilingFan.Off());
        remoteControl.SetCommand(5, () => ceilingFan.High(), () => ceilingFan.Off());

        System.Console.WriteLine(remoteControl);

        remoteControl.OnButtonPushed(0);
        remoteControl.OffButtonPushed(0);
        remoteControl.OnButtonPushed(1);
        remoteControl.OffButtonPushed(1);
        remoteControl.OnButtonPushed(2);
        remoteControl.OffButtonPushed(2);

        remoteControl.OnButtonPushed(3);
        remoteControl.OnButtonPushed(4);
        remoteControl.OnButtonPushed(5);
        remoteControl.OffButtonPushed(4);

        remoteControl.OnButtonPushed(6);
        remoteControl.OffButtonPushed(6);
    }
}
