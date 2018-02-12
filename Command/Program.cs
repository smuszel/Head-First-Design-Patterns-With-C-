using System;

class Program
{
    static void RootMain()
    {
        RemoteControl remoteControl = new RemoteControl();
        
        Light livingRoomLight = new Light("Living Room");
        Light kitchenLight = new Light("Kitchen");
        CeilingFan ceilingFan = new CeilingFan("Living Room");
        GarageDoor garageDoor = new GarageDoor("");
        Stereo stereo = new Stereo("Living Room");


        ICommand livingRoomLightOn = (ICommand) new LightOnCommand(livingRoomLight);
        ICommand livingRoomLightOff = (ICommand) new LightOffCommand(livingRoomLight);

        ICommand kitchenLightOn = (ICommand) new LightOnCommand(kitchenLight);
        ICommand kitchenLightOff = (ICommand) new LightOffCommand(kitchenLight);

        ICommand ceilingFanOff = (ICommand) new CeilingFanOffCommand(ceilingFan);
        ICommand ceilingFanLow = (ICommand) new CeilingFanLowCommand(ceilingFan);
        ICommand ceilingFanMedium = (ICommand) new CeilingFanMediumCommand(ceilingFan);
        ICommand ceilingFanHigh = (ICommand) new CeilingFanHighCommand(ceilingFan);

        ICommand garageDoorUp = (ICommand) new GarageDoorUpCommand(garageDoor);
        ICommand garageDoorDown = (ICommand) new GarageDoorDownCommand(garageDoor);

        ICommand stereoOnWithCD = new StereoOnWithCDCommand(stereo) as ICommand;
        ICommand stereoOff = new StereoOffCommand(stereo) as ICommand;

        ICommand[] pseudoPartyOn = new ICommand[] { garageDoorUp, ceilingFanHigh, kitchenLightOn, livingRoomLightOn };
        ICommand[] pseudoPartyOff = new ICommand[] { garageDoorDown, ceilingFanOff, kitchenLightOff, livingRoomLightOff };
        ICommand pseudoPartyOnMacro = new MacroCommand(pseudoPartyOn) as ICommand;
        ICommand pseudoPartyOffMacro = new MacroCommand(pseudoPartyOff) as ICommand;

        remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
        remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
        remoteControl.SetCommand(2, stereoOnWithCD, stereoOff);
        remoteControl.SetCommand(3, ceilingFanLow, ceilingFanOff);
        remoteControl.SetCommand(4, ceilingFanMedium, ceilingFanOff);
        remoteControl.SetCommand(5, ceilingFanHigh, ceilingFanOff);
        remoteControl.SetCommand(6, pseudoPartyOnMacro, pseudoPartyOffMacro);

        System.Console.WriteLine(remoteControl);

        remoteControl.OnButtonPushed(0);
        remoteControl.OffButtonPushed(0);
        remoteControl.OnButtonPushed(1);
        remoteControl.OffButtonPushed(1);
        remoteControl.OnButtonPushed(2);
        remoteControl.OffButtonPushed(2);
        remoteControl.UndoButtonPushed();

        remoteControl.OnButtonPushed(3);
        remoteControl.OnButtonPushed(4);
        remoteControl.OnButtonPushed(5);
        remoteControl.UndoButtonPushed();
        remoteControl.OffButtonPushed(4);

        remoteControl.OnButtonPushed(6);
        remoteControl.OffButtonPushed(6);
        remoteControl.UndoButtonPushed();
    }
}
