namespace MarsToStay.Models;

public class Player
{
    public MainCharacter? MainCharacter { get; set; }
    public ConnectionCharacter? ConnectionCharacter { get; set; }
    public string Name { get; set; } = string.Empty;
    public PlayerRoles Role { get; set; } = PlayerRoles.Player;

    public void AssignCharacter(MainCharacter character)
    {
        MainCharacter = character;
        character.Player = this;
    }
}

public enum PlayerRoles
{
    Host,
    Player
}
