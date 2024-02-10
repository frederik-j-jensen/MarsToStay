namespace MarsToStay.Models;

public class Characters
{

    public MainCharacter Brice { get; } = new MainCharacter { Name = "Brice the Explorer" };
    public MainCharacter Francis { get; } = new MainCharacter { Name = "Francis the Specialist" };
    public MainCharacter Shane { get; } = new MainCharacter { Name = "Shane the Visionary" };
    public MainCharacter Glen { get; } = new MainCharacter { Name = "Glen the Inventor" };
    public MainCharacter Alex { get; } = new MainCharacter { Name = "Alex the Shepherd" };
    public MainCharacter Mason { get; } = new MainCharacter { Name = "Mason the Scientist" };

    public ConnectionCharacter Adrian { get; } = new ConnectionCharacter { Name = "Adrian" };
    public ConnectionCharacter Jade { get; } = new ConnectionCharacter { Name = "Jade" };
    public ConnectionCharacter Kim { get; } = new ConnectionCharacter { Name = "Kim" };
    public ConnectionCharacter Morgan { get; } = new ConnectionCharacter { Name = "Morgan" };
    public ConnectionCharacter Sasha { get; } = new ConnectionCharacter { Name = "Sasha" };
    public ConnectionCharacter Tony { get; } = new ConnectionCharacter { Name = "Tony" };

    public SupportingCharacter Evan { get; } = new SupportingCharacter { Name = "Evan" };
    public SupportingCharacter Kelly { get; } = new SupportingCharacter { Name = "Kelly the Hammer" };
    public SupportingCharacter Lewis { get; } = new SupportingCharacter { Name = "Lewis the Joker" };
    public SupportingCharacter Robin { get; } = new SupportingCharacter { Name = "Clockwork Robin" };
    public SupportingCharacter Stacey { get; } = new SupportingCharacter { Name = "Stacey the Kid" };
    public SupportingCharacter Terry { get; } = new SupportingCharacter { Name = "Terry the Veteran" };

    public List<MainCharacter> MainCharacters { get; } = [];
    public List<ConnectionCharacter> ConnectionCharacters { get; } = [];
    public List<SupportingCharacter> SupportingCharacters { get; } = [];

    public Characters()
    {
        MainCharacters.Add(Alex);
        MainCharacters.Add(Brice);
        MainCharacters.Add(Francis);
        MainCharacters.Add(Glen);
        MainCharacters.Add(Mason);
        MainCharacters.Add(Shane);

        ConnectionCharacters.Add(Adrian);
        ConnectionCharacters.Add(Jade);
        ConnectionCharacters.Add(Kim);
        ConnectionCharacters.Add(Morgan);
        ConnectionCharacters.Add(Sasha);
        ConnectionCharacters.Add(Tony);

        Alex.ConnectionOnEarth = Sasha; Sasha.ConnectionOnMars = Alex;
        Brice.ConnectionOnEarth = Morgan; Morgan.ConnectionOnMars = Alex;
        Francis.ConnectionOnEarth = Tony; Tony.ConnectionOnMars = Alex;
        Glen.ConnectionOnEarth = Adrian; Adrian.ConnectionOnMars = Alex;
        Mason.ConnectionOnEarth = Jade; Jade.ConnectionOnMars = Mason;
        Shane.ConnectionOnEarth = Kim; Kim.ConnectionOnMars = Shane;

        SupportingCharacters.Add(Evan);
        SupportingCharacters.Add(Kelly);
        SupportingCharacters.Add(Lewis);
        SupportingCharacters.Add(Robin);
        SupportingCharacters.Add(Stacey);
        SupportingCharacters.Add(Terry);
    }
}
