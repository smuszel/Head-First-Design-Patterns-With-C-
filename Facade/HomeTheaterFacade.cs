
public class HomeTheaterFacade
{
    Amplifier amp;
    Tuner tuner;
    DvdPlayer dvd;
    CdPlayer cd;
    Projector projector;
    Screen screen;
    TheaterLights lights;
    PopcornPopper popper;

    public HomeTheaterFacade(
        Amplifier amp,
        Tuner tuner,
        DvdPlayer dvd,
        CdPlayer cd,
        Projector projector,
        Screen screen,
        TheaterLights lights,
        PopcornPopper popper)
    {
        this.amp = amp;
        this.tuner = tuner;
        this.dvd = dvd;
        this.cd = cd;
        this.projector = projector;
        this.screen = screen;
        this.lights = lights;
        this.popper = popper;
    }

    public void WatchMovie(string movie)
    {
        System.Console.WriteLine("Get ready to watch movie...");
        popper.On();
        popper.Pop();
        lights.Dim(10);
        screen.Down();
        projector.On();
        projector.WideScreenMode();
        amp.On();
        amp.Dvd = dvd;
        amp.SetSurroundSound();
        amp.Volume = 5;
        dvd.On();
        dvd.Play(movie);
    }

    public void EndMovie()
    {
        System.Console.WriteLine("Shutting movie theater down");
        popper.Off();
        lights.On();
        screen.Up();
        projector.Off();
        amp.Off();
        dvd.Stop();
        dvd.Eject();
        dvd.Off();
    }
}