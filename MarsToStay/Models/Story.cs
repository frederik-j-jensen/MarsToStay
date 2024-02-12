namespace MarsToStay.Models;

public class Story
{
    public Chapters Chapters { get; init; } = new();
    public Chapter CurrentChapter { get; set; }
    public Characters Characters { get; init; }
    public PlayerOrder ChapterOrder { get; init; }
    public Tracks Tracks { get; init; } = new();
    public DiceRoller DiceRoller { get; init; } = new();

    public Story(Characters characters, IEnumerable<Player> players)
    {
        Characters = characters;
        ChapterOrder = new PlayerOrder(players.First(), players);

        CurrentChapter = Chapters.Prologue;
        StartChapter(CurrentChapter);
    }

    public void AdvanceChapter()
    {
        EndChapter(CurrentChapter);

        if (CurrentChapter == Chapters.Epilogue) return;

        var nextChapter = Chapters.Next(CurrentChapter);

        ChapterOrder.Next();

        StartChapter(nextChapter);

    }

    public void AdvanceScene()
    {
        var sceneOrder = CurrentChapter.SceneOrder;
        if (sceneOrder == null) return;
        sceneOrder.Next();
    }

    private void StartChapter(Chapter chapter)
    {
        CurrentChapter = chapter;
        var playerOrder = new PlayerOrder(ChapterOrder.CurrentPlayer, ChapterOrder.Players);
        CurrentChapter.SceneOrder = playerOrder;

        if (chapter == Chapters.Chapter5)
        {
            var currentPlayer = playerOrder.CurrentPlayer;

            if (currentPlayer.ConnectionCharacter == Characters.Sasha)
                PlaySpotlightChapter(Chapters.Chapter51, Characters.Alex);
            else if (currentPlayer.ConnectionCharacter == Characters.Morgan)
                PlaySpotlightChapter(Chapters.Chapter52, Characters.Brice);
            else if (currentPlayer.ConnectionCharacter == Characters.Tony)
                PlaySpotlightChapter(Chapters.Chapter52, Characters.Francis);
            else if (currentPlayer.ConnectionCharacter == Characters.Adrian)
                PlaySpotlightChapter(Chapters.Chapter53, Characters.Glen);
            else if (currentPlayer.ConnectionCharacter == Characters.Jade)
                PlaySpotlightChapter(Chapters.Chapter53, Characters.Mason);
            else if (currentPlayer.ConnectionCharacter == Characters.Kim)
                PlaySpotlightChapter(Chapters.Chapter51, Characters.Shane);
        }

    }

    private void PlaySpotlightChapter(SpotlightChapter chapter, MainCharacter character)
    {
        chapter.IsVisible = true;
        chapter.SpotlightCharacter = character;
    }

    private void EndChapter(Chapter chapter)
    {
        chapter.IsCompleted = true;
    }

}
