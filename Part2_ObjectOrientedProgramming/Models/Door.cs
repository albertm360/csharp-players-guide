using Part2_ObjectOrientedProgramming.Models.Enums;

namespace Part2_ObjectOrientedProgramming.Models;

public class Door
{
    /*
     *  - An open door can always be closed ✅
     *  - A closed (but not locked door) can always be opened ✅
     *  - A closed door can always be locked ✅
     *  - A locked door can be unlocked, but a numeric passcode is needed, and the door will
     *  only unlock if the code supplied matches the door's current passcode ✅
     *  - When a door is created, it must be given an initial passcode ✅
     *  - Additionally, you should be able to change the passcode by supplying the current code and a new one.
     *  The passcode should only change if the correct, current code is given. ✅
     */

    public DoorState DoorState { get; private set; }
    private int Passcode { get; set; }

    public Door(int passcode)
    {
        if (passcode < 0 || passcode > 9999)
        {
            throw new ArgumentOutOfRangeException(nameof(passcode), passcode, "Please, provide a 4 digit passcode.");
        }

        DoorState = DoorState.Locked;
        Passcode = passcode;
    }

    public bool UnlockDoor(int guess)
    {
        if (guess == Passcode)
        {
            DoorState = DoorState.Closed;
            return true;
        }

        return false;
    }

    public void LockDoor()
    {
        DoorState = DoorState.Locked;
    }

    public void CloseDoor()
    {
        DoorState = DoorState.Closed;
    }

    public void OpenDoor()
    {
        DoorState = DoorState.Open;
    }

    public bool ChangePasscode(int currentPassword, int newPasscode)
    {
        if (currentPassword == Passcode)
        {
            Passcode = newPasscode;
            return true;
        }
        else
        {
            return false;
        }
    }
}