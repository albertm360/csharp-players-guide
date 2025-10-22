namespace Part1_TheBasics;

public class VictoryFanfare
{
    public static void Play()
    {
        // Console.Beep only works on Windows. Remember to add control with `OperatingSystem.IsWindows()` 
        // Define note frequencies
        int C5 = 523;
        int G4 = 392;
        int A4 = 440;
        int Asharp4 = 466;
        int Csharp5 = 554;
        int Dsharp5 = 622;

        // Define durations (ms)
        int sixteenth = 125;
        int eighth = 250;
        int quarter = 500;
        
        var fanfare = new[] {
            (C5, sixteenth), (C5, sixteenth), (C5, sixteenth), (C5, eighth + sixteenth),
            (Asharp4, eighth), (Csharp5, quarter),
            (C5, sixteenth), (C5, sixteenth), (C5, sixteenth), (C5, eighth + sixteenth),
            (Dsharp5, eighth), (Csharp5, quarter + eighth),
            (Asharp4, eighth), (Csharp5, quarter)
        };
        
        foreach (var note in fanfare)
        {
            if (note.Item1 > 0)
            {
                Console.Beep(note.Item1, note.Item2);
            }
            else
            {
                Thread.Sleep(note.Item2); // Use Sleep for rests (frequency 0)
            }
        }
    }
}