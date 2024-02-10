namespace MarsToStay.Models;
public class Game : Entity
{
    public List<Player> Players { get; private set; } = [];
    public Characters Characters { get; private set; } = new();
    public Story? Story { get; private set; } = null;

    public DiceRoller DiceRoller { get; private set; } = new();

    public void BeginStory()
    {
        if (CastCompleted())
            Story = new Story(Characters, Players);
    }

    public bool CastCompleted()
    {
        return Players.Count >= 3
            && Players.All(p => p.MainCharacter != null);
    }

    public void AssignCharacter(Player player, MainCharacter character)
    {
        if (Players.Contains(player) && Characters.MainCharacters.Contains(character))
        {
            player.AssignRole(character);
        }
    }

    public Player AddPlayer(string name)
    {
        var player = new Player { Name = name };
        Players.Add(player);
        return player;
    }
}