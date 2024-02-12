namespace MarsToStayTest.Models;

public class GameTest
{
    [Fact]
    public void CreateGame()
    {
        var game = new Game();

        Assert.Single(game.Players);
        Assert.Equal(PlayerRoles.Host, game.Players.First().Role);

        Assert.Null(game.Story);
        Assert.False(game.CastCompleted());
    }

    [Fact]
    public void CreateGameAndAddOnePlayer()
    {
        var game = new Game();
        var player = game.AddPlayer("Player 1");

        Assert.Equal(2, game.Players.Count);
        Assert.Equal(PlayerRoles.Player, game.Players.Last().Role);

        Assert.Null(game.Story);
        Assert.False(game.CastCompleted());
    }

    [Fact]
    public void CreateGameAndAddThreePlayers()
    {
        var game = new Game();
        game.AddPlayer("Player 1");
        game.AddPlayer("Player 2");
        game.AddPlayer("Player 3");

        Assert.Equal(4, game.Players.Count);

        Assert.Null(game.Story);
        Assert.False(game.CastCompleted());
    }

    [Fact]
    public void CreateGameAddThreePlayersAndAssignCharacters()
    {
        var game = new Game();
        game.AddPlayer("Player 1");
        game.AddPlayer("Player 2");
        game.AddPlayer("Player 3");

        game.AssignCharacter(game.Players[0], game.Characters.MainCharacters[0]);
        game.AssignCharacter(game.Players[1], game.Characters.MainCharacters[1]);
        game.AssignCharacter(game.Players[2], game.Characters.MainCharacters[2]);
        game.AssignCharacter(game.Players[3], game.Characters.MainCharacters[3]);

        Assert.Null(game.Story);
        Assert.True(game.CastCompleted());
    }

    [Fact]
    public void CreateGameAddPlayersAssignCharactersBeginStory()
    {
        var game = new Game();
        game.AddPlayer("Player 1");
        game.AddPlayer("Player 2");
        game.AddPlayer("Player 3");

        game.AssignCharacter(game.Players[0], game.Characters.MainCharacters[0]);
        game.AssignCharacter(game.Players[1], game.Characters.MainCharacters[1]);
        game.AssignCharacter(game.Players[2], game.Characters.MainCharacters[2]);
        game.AssignCharacter(game.Players[3], game.Characters.MainCharacters[3]);

        game.BeginStory();

        Assert.NotNull(game.Story);
    }

}
