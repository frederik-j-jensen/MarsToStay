namespace MarsToStayTest.Models;

public class PlayerOrderTest
{
    [Fact]
    public void CreatePlayerOrderWithTwoPlayers()
    {
        var players = new List<Player> { new Player(), new Player() };
        var playerOrder = new PlayerOrder(players[0], players);

        Assert.Equal(players[0], playerOrder.StartingPlayer);
        Assert.Equal(players[0], playerOrder.CurrentPlayer);
    }

    [Fact]
    public void IterateOnceOverPlayerOrderWithTwoPlayers()
    {
        var players = new List<Player> { new(), new() };
        var playerOrder = new PlayerOrder(players[0], players);

        playerOrder.Next();

        Assert.Equal(players[1], playerOrder.CurrentPlayer);
    }

    [Fact]
    public void IterateUntilEndOverPlayerOrderWithTwoPlayers()
    {
        var players = new List<Player> { new(), new() };
        var playerOrder = new PlayerOrder(players[0], players);

        int count = 0;
        while (!playerOrder.CurrentPlayerIsLastPlayer())
        {
            playerOrder.Next();
            count++;
        }

        Assert.Equal(1, count);
        Assert.Equal(players[1], playerOrder.CurrentPlayer);
        Assert.Equal(players[0], playerOrder.StartingPlayer);
    }

}
