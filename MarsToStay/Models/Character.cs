namespace MarsToStay.Models;

public class Character
{
    public string Name { get; init; } = string.Empty;
}

public class MainCharacter : Character
{
    public Player? Player { get; set; }
    public ConnectionCharacter? ConnectionOnEarth { get; set; }
    public int NumberOfRerollsLeft { get; set; } = 1;
    public List<string> Seeds = [];
}

public class SupportingCharacter : Character
{
    public bool IsDead { get; set; } = false;
}

public class ConnectionCharacter : Character
{
    public Player? Player { get; set; }
    public MainCharacter? ConnectionOnMars { get; set; }

}