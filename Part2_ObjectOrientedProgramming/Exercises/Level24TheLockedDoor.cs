using System.Text;
using Part2_ObjectOrientedProgramming.Models;
using Part2_ObjectOrientedProgramming.Models.Enums;

namespace Part2_ObjectOrientedProgramming.Exercises;

public class Level24TheLockedDoor
{
    public static Door CreateDoor()
    {
        const int Min = 0;
        const int Max = 9999;
        const string CreateDoorPrompt =
            "🚪 - You need to specify a passcode to create a Door. Enter a 4 digit code: ";

        int passcode = Utils.GetValidChoiceInRange(CreateDoorPrompt, Min, Max);
        return new Door(passcode);
    }

    public static void PrintOptionsMenu()
    {
        Utils.PrintEnumValues<DoorAction>();
    }

    public static int GetUserAction()
    {
        string prompt = "User options: \n1 - Change door passcode\n2 - Interact with door\n";

        int choice = Utils.GetValidChoice(prompt, 2);
        return choice;
    }

    public static void InvokeChangePasscode()
    {
        // TODO: Implement prompting the user for the current pwd and the new one
    }

    public static void Run()
    {
        Console.OutputEncoding = Encoding.UTF8;

        const string Close = "close";
        const string Open = "open";
        const string Lock = "lock";
        const string Unlock = "unlock";

        Door door = CreateDoor();

        Console.WriteLine($"The door has been created and is now {door.DoorState.ToString().ToLower()}.");

        int choice = GetUserAction();

        switch (choice)
        {
            case 1:
                InvokeChangePasscode(); // TODO: This method is still empty
                break;
            case 2:
                PrintOptionsMenu();
                break;
        }

        // TODO: Implement door state change from user interaction
    }
}