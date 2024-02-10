namespace MarsToStayTest.Models;

public class StoryTest
{
    [Fact]
    public void CreateStory()
    {
        var players = new List<Player> { new(), new(), new() };
        var characters = new Characters();
        players[0].AssignRole(characters.MainCharacters[0]);
        players[1].AssignRole(characters.MainCharacters[1]);
        players[2].AssignRole(characters.MainCharacters[2]);

        var story = new Story(characters, players);

        Assert.Equal(story.CurrentChapter, story.Chapters.Prologue);
        Assert.Equal(story.ChapterOrder.CurrentPlayer, players[0]);
        Assert.NotNull(story.CurrentChapter.SceneOrder);
    }

    [Fact]
    public void CreateAndAdvanceStory()
    {
        var players = new List<Player> { new(), new(), new() };
        var characters = new Characters();
        players[0].AssignRole(characters.MainCharacters[0]);
        players[1].AssignRole(characters.MainCharacters[1]);
        players[2].AssignRole(characters.MainCharacters[2]);

        var story = new Story(characters, players);

        story.AdvanceChapter();

        Assert.Equal(story.CurrentChapter, story.Chapters.Chapter1);
        Assert.Equal(story.ChapterOrder.CurrentPlayer, players[1]);
        Assert.NotNull(story.CurrentChapter.SceneOrder);
    }
}
