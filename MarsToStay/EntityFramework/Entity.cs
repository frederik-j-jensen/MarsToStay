namespace MarsToStay.EntityFramework;
public class Entity
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public override string ToString()
    {
        return Id.ToString();
    }
}
