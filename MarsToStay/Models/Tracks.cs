namespace MarsToStay.Models;

public class Tracks
{
    public ColonyTrack ColonyTrack { get; init; } = new();
    public ReturnTrack ReturnTrack { get; init; } = new();
}
