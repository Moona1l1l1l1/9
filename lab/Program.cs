using System;

class AudioSystem
{
    public void TurnOn() => Console.WriteLine("Audio is turned on.");
    public void TurnOff() => Console.WriteLine("Audio is turned off.");
}

class VideoProjector
{
    public void TurnOn() => Console.WriteLine("Video is turned on.");
    public void TurnOff() => Console.WriteLine("Video is turned off.");
}

class LightingSystem
{
    public void Dim() => Console.WriteLine("Lights are dimmed.");
    public void TurnOn() => Console.WriteLine("Lights are on.");
}

class HomeTheaterFacade
{
    private AudioSystem audio;
    private VideoProjector video;
    private LightingSystem lights;

    public HomeTheaterFacade(AudioSystem a, VideoProjector v, LightingSystem l)
    {
        audio = a;
        video = v;
        lights = l;
    }

    public void StartMovie()
    {
        Console.WriteLine("Starting movie...");
        lights.Dim();
        audio.TurnOn();
        video.TurnOn();
    }

    public void EndMovie()
    {
        Console.WriteLine("Ending movie...");
        video.TurnOff();
        audio.TurnOff();
        lights.TurnOn();
    }
}

class Program
{
    static void Main()
    {
        AudioSystem audio = new AudioSystem();
        VideoProjector video = new VideoProjector();
        LightingSystem lights = new LightingSystem();

        HomeTheaterFacade home = new HomeTheaterFacade(audio, video, lights);

        Console.WriteLine("Press 1 to start the movie, 2 to end the movie:");
        string choice = Console.ReadLine();

        if (choice == "1")
            home.StartMovie();
        else if (choice == "2")
            home.EndMovie();
        else
            Console.WriteLine("Invalid input.");
    }
}
