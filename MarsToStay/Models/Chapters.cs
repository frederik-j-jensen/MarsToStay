namespace MarsToStay.Models;

public class Chapters
{
    private readonly List<Chapter> _chapters = [];
    public readonly Chapter Prologue = new() { Title = "Prologue: Journey to Mars" };
    public readonly Chapter Chapter1 = new() { Title = "Chapter 1: A new home" };
    public readonly Chapter Chapter2 = new() { Title = "Chapter 2: Message home" };
    public readonly Chapter Chapter3 = new() { Title = "Chapter 3: Mission Two" };
    public readonly Chapter Chapter4 = new() { Title = "Chapter 4: First blood" };
    public readonly Chapter Chapter5 = new() { Title = "Chapter 5: Complications" };
    public readonly SpotlightChapter Chapter51 = new() { Title = "Chapter 5.1: Lost contact" };
    public readonly SpotlightChapter Chapter52 = new() { Title = "Chapter 5.2: New investor" };
    public readonly SpotlightChapter Chapter53 = new() { Title = "Chapter 5.3: Dust storm" };
    public readonly Chapter Chapter6 = new() { Title = "Chapter 6: Final hours" };
    public readonly Chapter Chapter7 = new() { Title = "Chapter 7: Point of no return" };
    public readonly Chapter Epilogue = new() { Title = "Epilogue: The dust settles" };

    public Chapters()
    {
        _chapters.Add(Prologue);
        _chapters.Add(Chapter1);
        _chapters.Add(Chapter2);
        _chapters.Add(Chapter3);
        _chapters.Add(Chapter4);
        _chapters.Add(Chapter5);
        _chapters.Add(Chapter6);
        _chapters.Add(Chapter7);
        _chapters.Add(Epilogue);
    }

    public Chapter Next(Chapter chapter)
    {
        var index = _chapters.IndexOf(chapter);
        var nextChapter = _chapters[index + 1];
        return nextChapter;
    }
}
