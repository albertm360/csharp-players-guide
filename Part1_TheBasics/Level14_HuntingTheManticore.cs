namespace Part1_TheBasics;

public enum BlastType
{
    Normal,
    Fire,
    Electric,
    Special
}

public class Level14_HuntingTheManticore
{
    static BlastType GetBlastType(int turn)
    {
        if (turn % 5 == 0 && turn % 3 == 0) return BlastType.Special;

        if (turn % 3 == 0) return BlastType.Fire;

        if (turn % 5 == 0) return BlastType.Electric;

        return BlastType.Normal;
    }

    static void SetConsoleForegroundColor(BlastType blastType)
    {
        switch (blastType)
        {
            case BlastType.Fire:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case BlastType.Electric:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case BlastType.Special:
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }
    }

    static int CalculateDamage(BlastType blastType)
    {
        const int NormalDamage = 1;
        const int FireDamage = 3;
        const int ElectricDamage = 3;
        const int FireElectricDamage = 10;

        switch (blastType)
        {
            case BlastType.Fire:
                return FireDamage;
            case BlastType.Electric:
                return ElectricDamage;
            case BlastType.Special:
                return FireElectricDamage;
            default:
                return NormalDamage;
        }
    }

    static int ValidateNumberInRange(string prompt)
    {
        do
        {
            const int Min = 0;
            const int Max = 100;

            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int number) && number >= Min && number <= Max)
            {
                return number;
            }

            Console.WriteLine("Wrong Input. The number must be between 1 and 100.");
        } while (true);
    }

    static int GetManticoreDistance()
    {
        const string ManticoreDistancePrompt =
            "Player 1, how far away from the city do you want to station the Manticore?";
        return ValidateNumberInRange(ManticoreDistancePrompt);
    }

    static void DamageLoop(int manticoreDistance)
    {
        int turn = 1;

        const int CityStartingHealth = 15;
        const int ManticoreStartingHealth = 10;

        int cityHealth = CityStartingHealth;
        int manticoreHealth = ManticoreStartingHealth;

        bool isCityDestroyed = false;
        bool isManticoreDestroyed = false;

        int manticoreLocation = manticoreDistance;

        do
        {
            string statusPrompt =
                $"STATUS: Round: {turn}. City: {cityHealth}/{CityStartingHealth}. Manticore:  {manticoreHealth}/{ManticoreStartingHealth}";

            Console.WriteLine(statusPrompt);
            BlastType blastType = GetBlastType(turn);
            int damage = CalculateDamage(blastType);
            SetConsoleForegroundColor(blastType);
            string damagePrompt = $"The cannon is expected to deal {damage} damage this round.";
            Console.WriteLine(damagePrompt);
            Console.ResetColor();
            const string CannonShotPrompt = "Enter desired cannon range: ";
            int cannonShot = ValidateNumberInRange(CannonShotPrompt);

            if (cannonShot == manticoreLocation)
            {
                manticoreHealth -= damage;
                Console.WriteLine("That round was a DIRECT HIT!");
            }
            else if (cannonShot < manticoreLocation)
            {
                cityHealth -= 1;
                Console.WriteLine("That round FELL SHORT of the target.");
            }
            else if (cannonShot > manticoreLocation)
            {
                cityHealth -= 1;
                Console.WriteLine("That round OVERSHOT the target.");
            }

            string separator = "----------------------------------------------------------";
            Console.WriteLine(separator);

            if (manticoreHealth <= 0)
            {
                isManticoreDestroyed = true;
                Console.WriteLine("The Manticore has been destroyed! The City is safe!");
            }

            if (cityHealth <= 0)
            {
                isCityDestroyed = true;
                Console.WriteLine("The city has been destroyed! Everyone died. :(");
            }

            turn++;
        } while (!isCityDestroyed && !isManticoreDestroyed);
    }

    public static void Run()
    {
        int manticoreDistance = GetManticoreDistance();
        Console.Clear();
        Console.WriteLine("Player 2, it is your turn:");
        DamageLoop(manticoreDistance);
    }
}