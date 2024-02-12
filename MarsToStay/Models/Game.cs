using System.Text;

namespace MarsToStay.Models;
public class Game : Entity
{
    public List<Player> Players { get; init; } = [];
    public Characters Characters { get; init; } = new();
    public Story? Story { get; private set; } = null;

    public Game()
    {
        AddHost();
    }

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
            player.AssignCharacter(character);
        }
    }

    public Player AddPlayer(string name)
    {
        var player = new Player { Name = name };
        AddPlayer(player);
        return player;
    }

    private void AddHost()
    {
        var player = new Player { Name = "Host", Role = PlayerRoles.Host };
        AddPlayer(player);
    }

    private void AddPlayer(Player player)
    {
        Players.Add(player);
    }

}