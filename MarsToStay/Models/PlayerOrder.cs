namespace MarsToStay.Models;

public class PlayerOrder
{
    public List<Player> Players { get; private set; } = [];
    public Player CurrentPlayer { get; private set; }
    public Player StartingPlayer { get; private set; }

    public PlayerOrder(Player startingPlayer, IEnumerable<Player> players)
    {
        StartingPlayer = startingPlayer;
        CurrentPlayer = startingPlayer;
        Players = new(players);
    }

    public void Next()
    {
        var player = NextPlayer(CurrentPlayer);
        CurrentPlayer = player;
    }

    public bool CurrentPlayerIsLastPlayer()
    {
        return NextPlayer(CurrentPlayer) == StartingPlayer;
    }

    private Player NextPlayer(Player player)
    {
        var index = Players.IndexOf(player);
        if (index == Players.Count - 1)
            player = Players[0];
        else
            player = Players[index + 1];
        return player;
    }
}
