namespace MarsToStay.Models;

public class DiceRoller
{
    public int RollDice()
    {
        return new Random().Next(1, 6 + 1);
    }

    public ProgressResult RollProgress()
    {
        int roll = RollDice();
        int trackDelta = 0;
        string result = string.Empty;

        if (roll == 1)
        {
            trackDelta = -1;
            result = "A mishap, misfortune, or setback";
        }
        else if (roll == 2)
        {
            trackDelta = 0;
            result = "Not much to show for your efforts";
        }
        else if (roll == 3 || roll == 4 || roll == 5)
        {
            trackDelta = 1;
            result = "Your hard work paid off";
        }
        else if (roll == 6)
        {
            trackDelta = 2;
            result = "Great progress!";
        }

        return new ProgressResult(roll, trackDelta, result);
    }

}

public record ProgressResult(int Roll, int TrackDelta, string Result);