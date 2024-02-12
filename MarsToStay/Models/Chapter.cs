namespace MarsToStay.Models;

public class Chapter
{
    public string Title { get; init; } = string.Empty;
    public bool IsCompleted { get; set; } = false;
    public bool IsVisible { get; set; } = true;
    public PlayerOrder? SceneOrder { get; set; }
}

public class SpotlightChapter : Chapter
{
    public MainCharacter? SpotlightCharacter { get; set; }
    public SpotlightChapter()
    {
        IsVisible = false;
    }
}