namespace Part2_ObjectOrientedProgramming.Models;

public class Player(string name)
{
    public string Name { get; } = name;
    public int Score { get; private set; }

    public void IncrementScore()
    {
        Score++;
    }
}