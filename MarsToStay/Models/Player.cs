namespace MarsToStay.Models;

public class Player
{
    public MainCharacter? MainCharacter { get; set; }
    public ConnectionCharacter? ConnectionCharacter { get; set; }
    public string Name { get; set; } = string.Empty;

    public void AssignRole(MainCharacter character)
    {
        MainCharacter = character;
        character.Player = this;
    }

}
