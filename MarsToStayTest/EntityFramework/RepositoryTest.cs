namespace MarsToStayTest.EntityFramework;

public class RepositoryTest
{
    [Fact]
    public void Test1()
    {
        var repo = new Repository<Entity>();
        var entity = repo.Create();
        var found = repo.FindById(entity.Id);
        Assert.Equal(entity, found);
    }
}