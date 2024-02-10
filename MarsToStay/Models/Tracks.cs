namespace MarsToStay.Models;

public class Tracks
{
    public ColonyTrack ColonyTrack { get; set; } = new();
    public ReturnTrack ReturnTrack { get; set; } = new();
}
