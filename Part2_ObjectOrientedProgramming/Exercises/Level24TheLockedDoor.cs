using System.Text;
using Part2_ObjectOrientedProgramming.Models;
using Part2_ObjectOrientedProgramming.Models.Enums;

namespace Part2_ObjectOrientedProgramming.Exercises;

public class Level24TheLockedDoor
{
    private readonly Door _door;

    private const int PasscodeMin = 0;
    private const int PasscodeMax = 9999;

    private const string Close = "close";
    private const string Open = "open";
    private const string Lock = "lock";
    private const string Unlock = "unlock";
    private const string Quit = "quit";

    public Level24TheLockedDoor()
    {
        _door = CreateDoor();
    }

    private Door CreateDoor()
    {
        const string CreateDoorPrompt =
            "🚪 - You need to specify a passcode to create a Door. Enter a 4 digit code: ";

        int passcode = Utils.GetValidChoiceInRange(CreateDoorPrompt, PasscodeMin, PasscodeMax);
        return new Door(passcode);
    }

    private static void PrintOptionsMenu()
    {
        Utils.PrintEnumValues<DoorAction>();
    }

    private static int GetUserAction()
    {
        string prompt = "User options: \n1 - Change door passcode\n2 - Interact with door\n3 - Quit\n";

        int choice = Utils.GetValidChoice(prompt, 3);
        return choice;
    }

    private void InvokeChangePasscode()
    {
        const string CurrentPassPrompt = "Enter the current passcode: ";
        const string NewPassPrompt = "Enter the new passcode: ";

        int currentPasscode = Utils.GetValidChoiceInRange(CurrentPassPrompt, PasscodeMin, PasscodeMax);
        int newPasscode = Utils.GetValidChoiceInRange(NewPassPrompt, PasscodeMin, PasscodeMax);

        if (_door.ChangePasscode(currentPasscode, newPasscode))
        {
            Console.WriteLine("The passcode has been successfully changed.");
        }
        else
        {
            Console.WriteLine("Invalid current passcode.");
        }
    }

    private void GetUserDoorAction()
    {
        const string doorActionPrompt = "Write your action (write 'quit' to exit): ";

        while (true)
        {
            string doorState = $"The door is now {_door.DoorState.ToString().ToLower()}.";
            Console.WriteLine(doorState);
            PrintOptionsMenu();
            string doorAction = Utils.GetValidString(doorActionPrompt).ToLower();

            switch (doorAction)
            {
                case Open:
                    if (_door.DoorState == DoorState.Closed)
                    {
                        _door.OpenDoor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The door must be closed before opening the door.");
                        Console.ResetColor();
                    }

                    break;
                case Close:
                    if (_door.DoorState == DoorState.Open)
                    {
                        _door.CloseDoor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The door must be open before closing the door.");
                        Console.ResetColor();
                    }

                    break;
                case Lock:
                    if (_door.DoorState == DoorState.Closed)
                    {
                        _door.LockDoor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The door must be closed before locking the door.");
                        Console.ResetColor();
                    }

                    break;
                case Unlock:
                    if (_door.DoorState == DoorState.Locked)
                    {
                        bool isDoorUnlocked = false;
                        while (!isDoorUnlocked)
                        {
                            const string guessPrompt = "Enter your current passcode: ";
                            int guess = Utils.GetValidChoiceInRange(guessPrompt, PasscodeMin, PasscodeMax);
                            isDoorUnlocked = _door.UnlockDoor(guess);
                            if (!isDoorUnlocked)
                            {
                                Console.WriteLine("Invalid passcode. Try again.");
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The door must be locked before unlocking the door.");
                        Console.ResetColor();
                    }

                    break;
                case Quit:
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice.");
                    Console.ResetColor();
                    break;
            }
        }
    }

    public void Run()
    {
        Console.WriteLine($"The door has been created and is now {_door.DoorState.ToString().ToLower()}.");

        while (true)
        {
            int choice = GetUserAction();

            switch (choice)
            {
                case 1:
                    InvokeChangePasscode();
                    break;
                case 2:
                    GetUserDoorAction();
                    break;
                case 3:
                    Console.WriteLine("Goodbye!");
                    return;
            }
        }
    }
}