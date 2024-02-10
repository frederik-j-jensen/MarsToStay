namespace MarsToStayTest.Models;

public class GameTest
{
    [Fact]
    public void CreateGame()
    {
        var game = new Game();

        Assert.Empty(game.Players);
        Assert.Null(game.Story);
        Assert.False(game.CastCompleted());
    }

    [Fact]
    public void CreateGameAndAddOnePlayer()
    {
        var game = new Game();
        game.AddPlayer("Player 1");

        Assert.NotEmpty(game.Players);
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

        Assert.NotEmpty(game.Players);
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

        Assert.NotEmpty(game.Players);
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

        game.BeginStory();

        Assert.NotNull(game.Story);
    }

}
