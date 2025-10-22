namespace Part1_TheBasics;

public class VictoryFanfare
{
    public static void Play()
    {
        // D5, D5, D5, D5, A#4, C5, D5, C5, D5
        // Console.Beep only works on Windows. Remember to add control with `OperatingSystem.IsWindows()` 
        // Define note frequencies
        int Asharp4 = 466;
        int C5 = 523;
        int D5 = 587;
        int Rest = 0; // Use 0 frequency for rests

        // Define durations (ms)
        int veryShort = 80;  // Quicker than sixteenth
        int shortPause = 50;
        int medium = 200;
        int longNote = 300;
        int finalNote = 400;
        
        var fanfare = new[] {
            // Triplets then longer note
            (D5, veryShort), (Rest, shortPause), (D5, veryShort), (Rest, shortPause), (D5, veryShort), (D5, longNote),
            // A#4 C5 D5...
            (Asharp4, medium), (C5, medium), (D5, longNote),
            // ...C5 D5
            (C5, medium), (D5, finalNote)
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