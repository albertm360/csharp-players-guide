namespace Part2_ObjectOrientedProgramming;

public class Level16SimulasTest
{
    static string GetBoxStatus(BoxStatus box)
    {
        switch (box)
        {
            case BoxStatus.Closed:
                return "closed";
            case BoxStatus.Locked:
                return "locked";
            case BoxStatus.Open:
                return "open";
            default:
                return "unknown";
        }
    }

    static BoxStatus ValidateAction(string prompt, BoxStatus box)
    {
        do
        {
            const string Close = "close";
            const string Lock = "lock";
            const string Unlock = "unlock";
            const string Open = "open";

            Console.Write(prompt);
            string? input = Console.ReadLine()?.ToLower();

            if (!string.IsNullOrWhiteSpace(input))
            {
                if (box == BoxStatus.Open && input == Close) return BoxStatus.Closed;

                if (box == BoxStatus.Closed && input == Lock) return BoxStatus.Locked;

                if (box == BoxStatus.Locked && input == Unlock) return BoxStatus.Closed;

                if (box == BoxStatus.Closed && input == Open) return BoxStatus.Open;
            }

            Console.WriteLine("Wrong input or invalid action, try again with 'close', 'lock', 'unlock' or 'open'");
        } while (true);
    }

    public static void Run()
    {
        BoxStatus box = BoxStatus.Closed;

        while (true)
        {
            string prompt = $"The chest is {GetBoxStatus(box)}. What do you want to do? ";
            box = ValidateAction(prompt, box);
        }
    }
}