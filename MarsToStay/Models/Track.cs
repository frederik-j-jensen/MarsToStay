namespace MarsToStay.Models;

public abstract class Track
{
    public string Name { get; set; } = string.Empty;
    public int Value { get; set; } = 0;
    public bool IsVisible { get; set; } = false;

    public void Adjust(int delta)
    {
        Value += delta;
    }

    public abstract bool EvaluateSurvival(int roll);
}

public class ColonyTrack : Track
{
    public ColonyTrack()
    {
        Name = "Colony Track";
        IsVisible = true;
        Value = 4;
    }

    public bool IsDestroyed()
    {
        return Value <= 0;
    }

    public override bool EvaluateSurvival(int roll)
    {
        return Value > 0;
    }
}

public class ReturnTrack : Track
{
    public ReturnTrack()
    {
        Name = "Return Track";
        IsVisible = false;
        Value = 0;
    }

    public override bool EvaluateSurvival(int roll)
    {
        return Value > 0;
    }
}
